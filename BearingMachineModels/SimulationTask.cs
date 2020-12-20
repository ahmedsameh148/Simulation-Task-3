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
                        ac += (int)(double.Parse(timeDisLine[1]) * 10.0);
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
            int num = random.Next(1, 11);
            foreach (TimeDistribution time in system.BearingLifeDistribution)
            {
                if (time.MinRange <= num && time.MaxRange >= num)
                    return new KeyValuePair<int, int>(num, time.Time);
            }
            return new KeyValuePair<int, int>();
        }
        
    }
}
