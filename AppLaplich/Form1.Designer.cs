namespace AppLaplich
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMonthDays = new System.Windows.Forms.Panel();
            this.pnlWeekDay = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPreMonth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmrNotify = new System.Windows.Forms.NumericUpDown();
            this.checkNotify = new System.Windows.Forms.CheckBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.dateTimePickerApp = new System.Windows.Forms.DateTimePicker();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlWeekDay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 901);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlMonthDays);
            this.panel3.Controls.Add(this.pnlWeekDay);
            this.panel3.Location = new System.Drawing.Point(8, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1665, 779);
            this.panel3.TabIndex = 1;
            // 
            // pnlMonthDays
            // 
            this.pnlMonthDays.Location = new System.Drawing.Point(3, 96);
            this.pnlMonthDays.Name = "pnlMonthDays";
            this.pnlMonthDays.Size = new System.Drawing.Size(1469, 683);
            this.pnlMonthDays.TabIndex = 1;
            // 
            // pnlWeekDay
            // 
            this.pnlWeekDay.Controls.Add(this.btnNextMonth);
            this.pnlWeekDay.Controls.Add(this.btnPreMonth);
            this.pnlWeekDay.Controls.Add(this.button1);
            this.pnlWeekDay.Location = new System.Drawing.Point(0, 0);
            this.pnlWeekDay.Name = "pnlWeekDay";
            this.pnlWeekDay.Size = new System.Drawing.Size(1472, 92);
            this.pnlWeekDay.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNextMonth.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNextMonth.Location = new System.Drawing.Point(1288, 5);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(148, 84);
            this.btnNextMonth.TabIndex = 7;
            this.btnNextMonth.Text = "NexMonth";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreMonth
            // 
            this.btnPreMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPreMonth.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreMonth.Location = new System.Drawing.Point(-5, 6);
            this.btnPreMonth.Name = "btnPreMonth";
            this.btnPreMonth.Size = new System.Drawing.Size(148, 84);
            this.btnPreMonth.TabIndex = 6;
            this.btnPreMonth.Text = "PreMonth";
            this.btnPreMonth.UseVisualStyleBackColor = false;
            this.btnPreMonth.Click += new System.EventHandler(this.btnPreMonth_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnToday);
            this.panel2.Controls.Add(this.dateTimePickerApp);
            this.panel2.Location = new System.Drawing.Point(8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1472, 97);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmrNotify);
            this.panel4.Controls.Add(this.checkNotify);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 91);
            this.panel4.TabIndex = 2;
            // 
            // nmrNotify
            // 
            this.nmrNotify.Location = new System.Drawing.Point(152, 28);
            this.nmrNotify.Name = "nmrNotify";
            this.nmrNotify.Size = new System.Drawing.Size(162, 39);
            this.nmrNotify.TabIndex = 1;
            this.nmrNotify.ValueChanged += new System.EventHandler(this.numerNotify_ValueChanged);
            // 
            // checkNotify
            // 
            this.checkNotify.AutoSize = true;
            this.checkNotify.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkNotify.Location = new System.Drawing.Point(14, 24);
            this.checkNotify.Name = "checkNotify";
            this.checkNotify.Size = new System.Drawing.Size(132, 41);
            this.checkNotify.TabIndex = 0;
            this.checkNotify.Text = "Notify";
            this.checkNotify.UseVisualStyleBackColor = true;
            this.checkNotify.CheckedChanged += new System.EventHandler(this.checkNotify_CheckedChanged);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToday.Location = new System.Drawing.Point(1288, 19);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(150, 61);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dateTimePickerApp
            // 
            this.dateTimePickerApp.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePickerApp.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerApp.Location = new System.Drawing.Point(486, 23);
            this.dateTimePickerApp.Name = "dateTimePickerApp";
            this.dateTimePickerApp.Size = new System.Drawing.Size(460, 43);
            this.dateTimePickerApp.TabIndex = 0;
            this.dateTimePickerApp.ValueChanged += new System.EventHandler(this.dateTimePickerApp_ValueChanged);
            // 
            // timerNotify
            // 
            this.timerNotify.Interval = 60000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 925);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppLapLich";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlWeekDay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel pnlMonthDays;
        private Panel pnlWeekDay;
        private Button button1;
        private Panel panel2;
        private Button btnToday;
        private DateTimePicker dateTimePickerApp;
        private Button btnPreMonth;
        private Panel panel4;
        private NumericUpDown nmrNotify;
        private CheckBox checkNotify;
        private Button btnNextMonth;
        private System.Windows.Forms.Timer timerNotify;
        private NotifyIcon notifyIcon;
    }
}