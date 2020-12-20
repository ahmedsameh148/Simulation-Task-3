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
    public partial class Form2 : Form
    {
        SimulationTask simulationTask;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(SimulationTask task)
        {
            InitializeComponent();
            simulationTask = task;
            ShowData();
            MessageBox.Show(task.system.CurrentSimulationTable.Count.ToString());
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ShowData()
        {
            foreach (CurrentSimulationCase simcase in simulationTask.system.CurrentSimulationTable)
            {
                dataGridView1.Rows.Add(simcase.Bearing.Index, simcase.Bearing.RandomHours, simcase.Bearing.Hours, simcase.AccumulatedHours, simcase.RandomDelay, simcase.Delay);
            }
            dataGridView2.Rows.Add(simulationTask.system.CurrentPerformanceMeasures.BearingCost,
                simulationTask.system.CurrentPerformanceMeasures.DelayCost,
                simulationTask.system.CurrentPerformanceMeasures.DowntimeCost,
                simulationTask.system.CurrentPerformanceMeasures.RepairPersonCost,
                simulationTask.system.CurrentPerformanceMeasures.TotalCost
                );
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
