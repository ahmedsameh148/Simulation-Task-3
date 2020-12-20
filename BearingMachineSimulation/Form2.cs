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
        }
    }
}
