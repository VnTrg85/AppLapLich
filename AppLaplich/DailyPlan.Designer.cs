namespace AppLaplich
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlJobs = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlJobs);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1688, 794);
            this.panel1.TabIndex = 0;
            // 
            // pnlJobs
            // 
            this.pnlJobs.Location = new System.Drawing.Point(13, 152);
            this.pnlJobs.Name = "pnlJobs";
            this.pnlJobs.Size = new System.Drawing.Size(1670, 639);
            this.pnlJobs.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTomorrow);
            this.panel2.Controls.Add(this.btnYesterday);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Location = new System.Drawing.Point(13, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1670, 103);
            this.panel2.TabIndex = 0;
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTomorrow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTomorrow.Location = new System.Drawing.Point(1346, 17);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(298, 69);
            this.btnTomorrow.TabIndex = 2;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYesterday.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnYesterday.Location = new System.Drawing.Point(32, 17);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(312, 69);
            this.btnYesterday.TabIndex = 1;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(595, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(529, 39);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkToolStripMenuItem,
            this.todayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1688, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addWorkToolStripMenuItem
            // 
            this.addWorkToolStripMenuItem.Name = "addWorkToolStripMenuItem";
            this.addWorkToolStripMenuItem.Size = new System.Drawing.Size(135, 38);
            this.addWorkToolStripMenuItem.Text = "Add work";
            this.addWorkToolStripMenuItem.Click += new System.EventHandler(this.addWorkToolStripMenuItem_Click);
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.todayToolStripMenuItem_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 808);
            this.Controls.Add(this.panel1);
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan in Day";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlJobs;
        private Panel panel2;
        private Button btnTomorrow;
        private Button btnYesterday;
        private DateTimePicker dateTimePicker;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addWorkToolStripMenuItem;
        private ToolStripMenuItem todayToolStripMenuItem;
    }
}