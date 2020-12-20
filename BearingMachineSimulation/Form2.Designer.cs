namespace BearingMachineSimulation
{
    partial class Form2
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
            this.BearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomForLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccBearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomForDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostOfBearings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfDelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfDownTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfRepairPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BearID,
            this.RandomForLife,
            this.BearingLife,
            this.AccBearingLife,
            this.RandomForDelay,
            this.DelayTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BearID
            // 
            this.BearID.HeaderText = "BearID";
            this.BearID.Name = "BearID";
            // 
            // RandomForLife
            // 
            this.RandomForLife.HeaderText = "RandomForLife";
            this.RandomForLife.Name = "RandomForLife";
            // 
            // BearingLife
            // 
            this.BearingLife.HeaderText = "BearingLife";
            this.BearingLife.Name = "BearingLife";
            // 
            // AccBearingLife
            // 
            this.AccBearingLife.HeaderText = "AccBearingLife";
            this.AccBearingLife.Name = "AccBearingLife";
            // 
            // RandomForDelay
            // 
            this.RandomForDelay.HeaderText = "RandomForDelay";
            this.RandomForDelay.Name = "RandomForDelay";
            // 
            // DelayTime
            // 
            this.DelayTime.HeaderText = "DelayTime";
            this.DelayTime.Name = "DelayTime";
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
            this.dataGridView2.Location = new System.Drawing.Point(12, 358);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(662, 63);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simulation Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Performance Measures";
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
            this.CostOfDelayTime.Width = 120;
            // 
            // CostOfDownTime
            // 
            this.CostOfDownTime.HeaderText = "Cost Of Down Time";
            this.CostOfDownTime.Name = "CostOfDownTime";
            // 
            // CostOfRepairPerson
            // 
            this.CostOfRepairPerson.HeaderText = "Cost Of Repair Person";
            this.CostOfRepairPerson.Name = "CostOfRepairPerson";
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Current Method";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BearID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomForLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn BearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccBearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomForDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfBearings;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfDelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfDownTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfRepairPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}