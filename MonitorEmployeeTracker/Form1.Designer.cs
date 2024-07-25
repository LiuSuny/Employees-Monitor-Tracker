namespace MonitorEmployeeTracker
{
    partial class Form1
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
            this.btnManageEmployees_Click = new System.Windows.Forms.Button();
            this.btnEnterWorkHours_Click = new System.Windows.Forms.Button();
            this.btnViewStatistics_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageEmployees_Click
            // 
            this.btnManageEmployees_Click.BackColor = System.Drawing.Color.Chocolate;
            this.btnManageEmployees_Click.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployees_Click.Location = new System.Drawing.Point(51, 156);
            this.btnManageEmployees_Click.Name = "btnManageEmployees_Click";
            this.btnManageEmployees_Click.Size = new System.Drawing.Size(165, 63);
            this.btnManageEmployees_Click.TabIndex = 0;
            this.btnManageEmployees_Click.Text = "Manage Employees";
            this.btnManageEmployees_Click.UseVisualStyleBackColor = false;
            this.btnManageEmployees_Click.Click += new System.EventHandler(this.btnManageEmployees_Click_Click);
            // 
            // btnEnterWorkHours_Click
            // 
            this.btnEnterWorkHours_Click.BackColor = System.Drawing.Color.Chocolate;
            this.btnEnterWorkHours_Click.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterWorkHours_Click.Location = new System.Drawing.Point(237, 156);
            this.btnEnterWorkHours_Click.Name = "btnEnterWorkHours_Click";
            this.btnEnterWorkHours_Click.Size = new System.Drawing.Size(166, 63);
            this.btnEnterWorkHours_Click.TabIndex = 1;
            this.btnEnterWorkHours_Click.Text = "Enter Work Hours";
            this.btnEnterWorkHours_Click.UseVisualStyleBackColor = false;
            this.btnEnterWorkHours_Click.Click += new System.EventHandler(this.btnEnterWorkHours_Click_Click);
            // 
            // btnViewStatistics_Click
            // 
            this.btnViewStatistics_Click.BackColor = System.Drawing.Color.Chocolate;
            this.btnViewStatistics_Click.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatistics_Click.Location = new System.Drawing.Point(460, 156);
            this.btnViewStatistics_Click.Name = "btnViewStatistics_Click";
            this.btnViewStatistics_Click.Size = new System.Drawing.Size(169, 63);
            this.btnViewStatistics_Click.TabIndex = 2;
            this.btnViewStatistics_Click.Text = "View Statistics";
            this.btnViewStatistics_Click.UseVisualStyleBackColor = false;
            this.btnViewStatistics_Click.Click += new System.EventHandler(this.btnViewStatistics_Click_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(182, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Working Hours Monitoring  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewStatistics_Click);
            this.Controls.Add(this.btnEnterWorkHours_Click);
            this.Controls.Add(this.btnManageEmployees_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageEmployees_Click;
        private System.Windows.Forms.Button btnEnterWorkHours_Click;
        private System.Windows.Forms.Button btnViewStatistics_Click;
        private System.Windows.Forms.Label label1;
    }
}

