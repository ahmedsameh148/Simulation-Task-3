using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BearingMachineModels
{
    public class SimulationTask
    {
        public SimulationSystem system;
        Random random;
        public SimulationTask()
        {
            system = new SimulationSystem();
            random = new Random();
        }

        public void readData(string path)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "DowntimeCost")
                {
                    i++;
                    system.DowntimeCost = int.Parse(lines[i]);
                }
                if (lines[i] == "RepairPersonCost")
                {
                    i++;
                    system.RepairPersonCost = int.Parse(lines[i]);
                }
                if (lines[i] == "BearingCost")
                {
                    i++;
                    system.BearingCost = int.Parse(lines[i]);
                }
                if (lines[i] == "NumberOfHours")
                {
                    i++;
                    system.NumberOfHours = int.Parse(lines[i]);
                }
                if (lines[i] == "NumberOfBearings")
                {
                    i++;
                    system.NumberOfBearings = int.Parse(lines[i]);
                }
                if (lines[i] == "RepairTimeForOneBearing")
                {
                    i++;
                    system.RepairTimeForOneBearing = int.Parse(lines[i]);
                }
                if (lines[i] == "RepairTimeForAllBearings")
                {
                    i++;
                    system.RepairTimeForAllBearings = int.Parse(lines[i]);
                }
                if (lines[i] == "DelayTimeDistribution")
                {
                    i++;
                    int ac = 0;
                    while (lines[i].Length > 0)
                    {
                        TimeDistribution time = new TimeDistribution();
                        string[] timeDisLine = lines[i].Split(',');
                        time.Time = int.Parse(timeDisLine[0]);
                        time.Probability = decimal.Parse(timeDisLine[1]);
                        time.MinRange = ac + 1;
                        ac += (int)(double.Parse(timeDisLine[1]) * 100.0);
                        time.MaxRange = ac; i++;
                        system.DelayTimeDistribution.Add(time);
                    }
                }
                if (lines[i] == "BearingLifeDistribution")
                {
                    i++;
                    int ac = 0;
                    while (i < lines.Length && lines[i].Length > 0)
                    {
                        TimeDistribution time = new TimeDistribution();
                        string[] timeDisLine = lines[i].Split(',');
                        time.Time = int.Parse(timeDisLine[0]);
                        time.Probability = decimal.Parse(timeDisLine[1]);
                        time.MinRange = ac + 1;
                        ac += (int)(double.Parse(timeDisLine[1]) * 100.0);
                        time.MaxRange = ac; i++;
                        system.BearingLifeDistribution.Add(time);
                    }
                }
            }
        }

        public KeyValuePair<int, int> generateBearingLife()
        {
            int num = random.Next(1, 101);
            foreach (TimeDistribution time in system.BearingLifeDistribution)
            {
                if (time.MinRange <= num && time.MaxRange >= num)
                    return new KeyValuePair<int, int>(num, time.Time);
            }
            return new KeyValuePair<int, int>();
        }
        public KeyValuePair<int, int> generateDelayTime()
        {
            int num = random.Next(1, 101);
            foreach (TimeDistribution time in system.DelayTimeDistribution)
            {
                if (time.MinRange <= num && time.MaxRange >= num)
                    return new KeyValuePair<int, int>(num, time.Time);
            }
            return new KeyValuePair<int, int>();
        }
        public void FillCurrentSimulationTable()
        {
            system.CurrentTableValues = new List<KeyValuePair<int, int>>[system.NumberOfBearings + 1];
            decimal totalBearings = 0;
            for (int i = 1; i <= system.NumberOfBearings; i++)
            {
                system.CurrentTableValues[i] = new List<KeyValuePair<int, int>>();
                int ac = 0;
                while (ac < system.NumberOfHours)
                {
                    totalBearings++;
                    KeyValuePair<int, int> bearingLife = generateBearingLife();
                    KeyValuePair<int, int> delayTime = generateDelayTime();

                    ac += bearingLife.Value;

                    CurrentSimulationCase simcase = new CurrentSimulationCase();
                    simcase.Bearing.Index = i;
                    simcase.Bearing.RandomHours = bearingLife.Key;
                    simcase.Bearing.Hours = bearingLife.Value;

                    simcase.AccumulatedHours = ac;
                    simcase.Delay = delayTime.Value;
                    simcase.RandomDelay = delayTime.Key;

                    system.CurrentSimulationTable.Add(simcase);
                    system.CurrentTableValues[i].Add(bearingLife);

                    system.CurrentPerformanceMeasures.BearingCost += system.BearingCost;
                    system.CurrentPerformanceMeasures.DelayCost += simcase.Delay * system.DowntimeCost;
                    system.CurrentPerformanceMeasures.DowntimeCost += system.RepairTimeForOneBearing * system.DowntimeCost;                    
                }
            }
            system.CurrentPerformanceMeasures.RepairPersonCost = totalBearings * system.RepairPersonCost * system.RepairTimeForOneBearing / ((decimal)60.0);
            system.CurrentPerformanceMeasures.TotalCost =
                system.CurrentPerformanceMeasures.BearingCost +
                system.CurrentPerformanceMeasures.DelayCost +
                system.CurrentPerformanceMeasures.DowntimeCost +
                system.CurrentPerformanceMeasures.RepairPersonCost;
        }
        public void FillProposedSimulationTable()
        {
            int[] lastIndices = new int[system.NumberOfBearings + 1];
            int ac = 0;
            decimal counter = 0;
            while (ac < system.NumberOfHours)
            {
                counter++;
                ProposedSimulationCase simcase = new ProposedSimulationCase();
                int mnValue = 1000000000, mnIndex = 0;
                for (int i = 1; i <= system.NumberOfBearings; i++)
                {
                    if (lastIndices[i] == system.CurrentTableValues[i].Count)
                    {
                        KeyValuePair<int, int> bearingLife = generateBearingLife();
                        system.CurrentTableValues[i].Add(new KeyValuePair<int, int>(-1 * bearingLife.Key, bearingLife.Value));
                    }
                    if (system.CurrentTableValues[i][lastIndices[i]].Value < mnValue)
                    {
                        mnValue = Math.Abs(system.CurrentTableValues[i][lastIndices[i]].Value);
                        mnIndex = i;
                    }
                    Bearing bearing = new Bearing();
                    bearing.Index = i;
                    bearing.RandomHours = Math.Abs(system.CurrentTableValues[i][lastIndices[i]].Key);
                    bearing.Hours = system.CurrentTableValues[i][lastIndices[i]].Value;
                    simcase.Bearings.Add(bearing);

                    lastIndices[i]++;
                }

                KeyValuePair<int, int> delayTime = generateDelayTime();
                simcase.RandomDelay = delayTime.Key;
                simcase.Delay = delayTime.Value;
                simcase.FirstFailure = mnValue;
                ac += mnValue;
                simcase.AccumulatedHours = ac;
                system.ProposedSimulationTable.Add(simcase);

                system.ProposedPerformanceMeasures.BearingCost += system.BearingCost * system.NumberOfBearings;
                system.ProposedPerformanceMeasures.DelayCost += simcase.Delay * system.DowntimeCost;
                system.ProposedPerformanceMeasures.DowntimeCost += system.RepairTimeForAllBearings * system.DowntimeCost;
            }
            system.ProposedPerformanceMeasures.RepairPersonCost = counter * system.RepairTimeForAllBearings * system.RepairPersonCost / ((decimal)60.0);
            system.ProposedPerformanceMeasures.TotalCost =
                system.ProposedPerformanceMeasures.BearingCost +
                system.ProposedPerformanceMeasures.DelayCost +
                system.ProposedPerformanceMeasures.DowntimeCost +
                system.ProposedPerformanceMeasures.RepairPersonCost;
        }
    }
}
