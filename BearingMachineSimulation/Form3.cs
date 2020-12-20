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
            DataTable dt = new DataTable();
            dt.Columns.Add("#", typeof(string));
            for (int i = 1; i <= simulationTask.system.NumberOfBearings; i++)
            {
                dt.Columns.Add("Bearing " + i.ToString() + " Life", typeof(string));
            }
            dt.Columns.Add("First Failure", typeof(string));
            dt.Columns.Add("AccLife", typeof(string));
            dt.Columns.Add("Random Delay", typeof(string));
            dt.Columns.Add("Delay Time", typeof(string));
            dataGridView1.DataSource = dt;
        }
    }
}
