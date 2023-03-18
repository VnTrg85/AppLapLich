namespace AppLaplich
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.nmrToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmrToHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nmrFromHour = new System.Windows.Forms.NumericUpDown();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.checkDone = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromHour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.pnlTime);
            this.panel1.Controls.Add(this.txtWork);
            this.panel1.Controls.Add(this.checkDone);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1498, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1401, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 46);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(1171, 13);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(224, 40);
            this.cmbStatus.TabIndex = 3;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.nmrToMinute);
            this.pnlTime.Controls.Add(this.nmrToHour);
            this.pnlTime.Controls.Add(this.label1);
            this.pnlTime.Controls.Add(this.nmrFromMinute);
            this.pnlTime.Controls.Add(this.nmrFromHour);
            this.pnlTime.Location = new System.Drawing.Point(741, 3);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(424, 56);
            this.pnlTime.TabIndex = 2;
            // 
            // nmrToMinute
            // 
            this.nmrToMinute.Location = new System.Drawing.Point(336, 10);
            this.nmrToMinute.Name = "nmrToMinute";
            this.nmrToMinute.Size = new System.Drawing.Size(76, 39);
            this.nmrToMinute.TabIndex = 4;
            // 
            // nmrToHour
            // 
            this.nmrToHour.Location = new System.Drawing.Point(254, 10);
            this.nmrToHour.Name = "nmrToHour";
            this.nmrToHour.Size = new System.Drawing.Size(76, 39);
            this.nmrToHour.TabIndex = 3;
            this.nmrToHour.ValueChanged += new System.EventHandler(this.nmrToHour_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // nmrFromMinute
            // 
            this.nmrFromMinute.Location = new System.Drawing.Point(95, 10);
            this.nmrFromMinute.Name = "nmrFromMinute";
            this.nmrFromMinute.Size = new System.Drawing.Size(76, 39);
            this.nmrFromMinute.TabIndex = 1;
            this.nmrFromMinute.ValueChanged += new System.EventHandler(this.nmrFromMinute_ValueChanged);
            // 
            // nmrFromHour
            // 
            this.nmrFromHour.Location = new System.Drawing.Point(13, 10);
            this.nmrFromHour.Name = "nmrFromHour";
            this.nmrFromHour.Size = new System.Drawing.Size(76, 39);
            this.nmrFromHour.TabIndex = 0;
            this.nmrFromHour.ValueChanged += new System.EventHandler(this.nmrFromHour_ValueChanged);
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(37, 13);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(685, 39);
            this.txtWork.TabIndex = 1;
            // 
            // checkDone
            // 
            this.checkDone.AutoSize = true;
            this.checkDone.Location = new System.Drawing.Point(3, 20);
            this.checkDone.Name = "checkDone";
            this.checkDone.Size = new System.Drawing.Size(28, 27);
            this.checkDone.TabIndex = 0;
            this.checkDone.UseVisualStyleBackColor = true;
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(1656, 64);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtWork;
        private CheckBox checkDone;
        private Panel pnlTime;
        private NumericUpDown nmrFromMinute;
        private NumericUpDown nmrFromHour;
        private Button btnDelete;
        private Button btnEdit;
        private ComboBox cmbStatus;
        private NumericUpDown nmrToMinute;
        private NumericUpDown nmrToHour;
        private Label label1;
    }
}
