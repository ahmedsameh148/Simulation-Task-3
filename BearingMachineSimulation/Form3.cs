using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    public partial class Form3 : Form
    {
        SimulationTask simulationTask;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(SimulationTask task)
        {
            InitializeComponent();
            simulationTask = task;
            ShowData();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void ShowData()
        {
            dataGridView1.ColumnCount = 5 + simulationTask.system.NumberOfBearings;
            dataGridView1.Columns[0].HeaderText = "#";
            int n = simulationTask.system.NumberOfBearings;
            for (int i = 1; i <= simulationTask.system.NumberOfBearings; i++)
            {
                dataGridView1.Columns[i].HeaderText = "Bearing " + i.ToString() + " Life";
            }
            dataGridView1.Columns[n + 1].HeaderText = "First Failure";
            dataGridView1.Columns[n + 2].HeaderText = "Acc Life";
            dataGridView1.Columns[n + 3].HeaderText = "Random Delay";
            dataGridView1.Columns[n + 4].HeaderText = "Delay Time";
            int counter = 1;
            foreach (ProposedSimulationCase simcase in simulationTask.system.ProposedSimulationTable)
            {
                List<string> list = new List<string>();
                list.Add(counter.ToString()); counter++;
                foreach (Bearing bearing in simcase.Bearings)
                {
                    if (bearing.RandomHours < 0)
                        list.Add((-1 * bearing.RandomHours).ToString() + " / " + bearing.Hours.ToString());
                    else list.Add(bearing.Hours.ToString());
                }
                list.Add(simcase.FirstFailure.ToString());
                list.Add(simcase.AccumulatedHours.ToString());
                list.Add(simcase.RandomDelay.ToString());
                list.Add(simcase.Delay.ToString());
                dataGridView1.Rows.Add(list.ToArray<string>());
            }
            dataGridView2.Rows.Add(simulationTask.system.ProposedPerformanceMeasures.BearingCost,
                simulationTask.system.ProposedPerformanceMeasures.DelayCost,
                simulationTask.system.ProposedPerformanceMeasures.DowntimeCost,
                simulationTask.system.ProposedPerformanceMeasures.RepairPersonCost,
                simulationTask.system.ProposedPerformanceMeasures.TotalCost
                );
        }
    }
}
