namespace BearingMachineSimulation
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CostOfBearings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfDelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfDownTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfRepairPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostOfBearings,
            this.CostOfDelayTime,
            this.CostOfDownTime,
            this.CostOfRepairPerson,
            this.TotalCost});
            this.dataGridView2.Location = new System.Drawing.Point(12, 350);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(810, 50);
            this.dataGridView2.TabIndex = 2;
            // 
            // CostOfBearings
            // 
            this.CostOfBearings.FillWeight = 150F;
            this.CostOfBearings.HeaderText = "Cost Of Bearings";
            this.CostOfBearings.Name = "CostOfBearings";
            this.CostOfBearings.Width = 130;
            // 
            // CostOfDelayTime
            // 
            this.CostOfDelayTime.HeaderText = "Cost Of Delay Time";
            this.CostOfDelayTime.Name = "CostOfDelayTime";
            this.CostOfDelayTime.Width = 150;
            // 
            // CostOfDownTime
            // 
            this.CostOfDownTime.HeaderText = "Cost Of Down Time";
            this.CostOfDownTime.Name = "CostOfDownTime";
            this.CostOfDownTime.Width = 160;
            // 
            // CostOfRepairPerson
            // 
            this.CostOfRepairPerson.HeaderText = "Cost Of Repair Person";
            this.CostOfRepairPerson.Name = "CostOfRepairPerson";
            this.CostOfRepairPerson.Width = 160;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Simulation Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Performance Measures";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Proposed Method";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfBearings;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfDelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfDownTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfRepairPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}