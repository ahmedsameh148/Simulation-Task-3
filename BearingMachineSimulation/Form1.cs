using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineTesting;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    public partial class dgvInputData : Form
    {
        SimulationTask simulationTask;
        public dgvInputData()
        {
            InitializeComponent();
            simulationTask = new SimulationTask();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLifeDis.Rows.Clear();
            dgvTimeDis.Rows.Clear();
            dgvInput.Rows.Clear();
            simulationTask = new SimulationTask();
            simulationTask.readData("e:\\collage\\[students]_template\\bearingmachinesimulation\\testcases\\testcase1.txt");
            ShowData();
        }
        public void ShowData()
        {
            dgvInput.Rows.Add("DowntimeCost", simulationTask.system.DowntimeCost);
            dgvInput.Rows.Add("RepairPersonCost", simulationTask.system.RepairPersonCost);
            dgvInput.Rows.Add("BearingCost", simulationTask.system.BearingCost);
            dgvInput.Rows.Add("NumberOfHours", simulationTask.system.NumberOfHours);
            dgvInput.Rows.Add("NumberOfBearings", simulationTask.system.NumberOfBearings);
            dgvInput.Rows.Add("RepairTimeForOneBearing", simulationTask.system.RepairTimeForOneBearing);
            dgvInput.Rows.Add("RepairTimeForAllBearings", simulationTask.system.RepairTimeForAllBearings);

            foreach (TimeDistribution time in simulationTask.system.DelayTimeDistribution)
            {
                dgvTimeDis.Rows.Add(time.Time, time.MinRange, time.MaxRange);
            }
            foreach (TimeDistribution life in simulationTask.system.BearingLifeDistribution)
            {
                dgvLifeDis.Rows.Add(life.Time, life.MinRange, life.MaxRange);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 currentMethod = new Form2(simulationTask);
            currentMethod.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 porposedMethod = new Form3(simulationTask);
            porposedMethod.Show();
        }
    }
}
