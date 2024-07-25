namespace MonitorEmployeeTracker
{
    partial class StatisticsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnGeneralStatistics = new System.Windows.Forms.Button();
            this.btnDepartmentStatistics = new System.Windows.Forms.Button();
            this.btnEmployeeRatings = new System.Windows.Forms.Button();
            this.btnDepartmentRatings = new System.Windows.Forms.Button();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(289, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(223, 50);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(184, 21);
            this.cmbMonth.TabIndex = 2;
            // 
            // btnGeneralStatistics
            // 
            this.btnGeneralStatistics.BackColor = System.Drawing.Color.Chocolate;
            this.btnGeneralStatistics.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralStatistics.Location = new System.Drawing.Point(55, 103);
            this.btnGeneralStatistics.Name = "btnGeneralStatistics";
            this.btnGeneralStatistics.Size = new System.Drawing.Size(132, 28);
            this.btnGeneralStatistics.TabIndex = 3;
            this.btnGeneralStatistics.Text = "General Statistics";
            this.btnGeneralStatistics.UseVisualStyleBackColor = false;
            this.btnGeneralStatistics.Click += new System.EventHandler(this.btnGeneralStatistics_Click);
            // 
            // btnDepartmentStatistics
            // 
            this.btnDepartmentStatistics.BackColor = System.Drawing.Color.Chocolate;
            this.btnDepartmentStatistics.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentStatistics.Location = new System.Drawing.Point(223, 103);
            this.btnDepartmentStatistics.Name = "btnDepartmentStatistics";
            this.btnDepartmentStatistics.Size = new System.Drawing.Size(142, 28);
            this.btnDepartmentStatistics.TabIndex = 4;
            this.btnDepartmentStatistics.Text = "Department Statistics";
            this.btnDepartmentStatistics.UseVisualStyleBackColor = false;
            this.btnDepartmentStatistics.Click += new System.EventHandler(this.btnDepartmentStatistics_Click);
            // 
            // btnEmployeeRatings
            // 
            this.btnEmployeeRatings.BackColor = System.Drawing.Color.Chocolate;
            this.btnEmployeeRatings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRatings.Location = new System.Drawing.Point(400, 103);
            this.btnEmployeeRatings.Name = "btnEmployeeRatings";
            this.btnEmployeeRatings.Size = new System.Drawing.Size(135, 28);
            this.btnEmployeeRatings.TabIndex = 5;
            this.btnEmployeeRatings.Text = "Employee Ratings";
            this.btnEmployeeRatings.UseVisualStyleBackColor = false;
            this.btnEmployeeRatings.Click += new System.EventHandler(this.btnEmployeeRatings_Click);
            // 
            // btnDepartmentRatings
            // 
            this.btnDepartmentRatings.BackColor = System.Drawing.Color.Chocolate;
            this.btnDepartmentRatings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentRatings.Location = new System.Drawing.Point(592, 103);
            this.btnDepartmentRatings.Name = "btnDepartmentRatings";
            this.btnDepartmentRatings.Size = new System.Drawing.Size(126, 28);
            this.btnDepartmentRatings.TabIndex = 6;
            this.btnDepartmentRatings.Text = "Department Ratings";
            this.btnDepartmentRatings.UseVisualStyleBackColor = false;
            this.btnDepartmentRatings.Click += new System.EventHandler(this.btnDepartmentRatings_Click);
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(55, 156);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.Size = new System.Drawing.Size(663, 255);
            this.dataGridViewStatistics.TabIndex = 7;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.btnDepartmentRatings);
            this.Controls.Add(this.btnEmployeeRatings);
            this.Controls.Add(this.btnDepartmentStatistics);
            this.Controls.Add(this.btnGeneralStatistics);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnGeneralStatistics;
        private System.Windows.Forms.Button btnDepartmentStatistics;
        private System.Windows.Forms.Button btnEmployeeRatings;
        private System.Windows.Forms.Button btnDepartmentRatings;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;
    }
}