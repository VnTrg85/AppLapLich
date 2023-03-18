using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLaplich
{
    public partial class AJob : UserControl
    {
        PlanItem job;
        public AJob(PlanItem job)
        {
            InitializeComponent();
            cmbStatus.DataSource = PlanItem.listStatus;
            this.Job = job;
            checkDone.Enabled  =false;
            showInfo();
           
        }

        public PlanItem Job { get => job; set => job=value; }

        void showInfo()
        {
            txtWork.Text = Job.Name;
            nmrFromHour.Value = Job.FromHour.X;
            nmrFromMinute.Value =Job.FromHour.Y;
            nmrToHour.Value = Job.ToHour.X;
            nmrToMinute.Value = Job.ToHour.Y;
            cmbStatus.SelectedIndex = PlanItem.listStatus.IndexOf(Job.Status);
            checkDone.Checked = PlanItem.listStatus.IndexOf(Job.Status) == 0 ? true: false;
        }
       
        event EventHandler delete;
        public event EventHandler Delete
        {
            add { delete += value; }
            remove { delete -= value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
                job.Name = txtWork.Text;
                job.FromHour = new Point((int)nmrFromHour.Value,(int) nmrFromMinute.Value);
                job.ToHour = new Point((int)nmrToHour.Value, (int)nmrToMinute.Value);
                job.Status = cmbStatus.SelectedItem.ToString();                
                showInfo();         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(delete != null)
                delete(this, new EventArgs());
        }

        private void nmrFromHour_ValueChanged(object sender, EventArgs e)
        {
            nmrToHour.Minimum = (int)nmrFromHour.Value;
            checkTime();
        }

        private void nmrFromMinute_ValueChanged(object sender, EventArgs e)
        {
            checkTime();
        }
        private void checkTime()
        {
            if (nmrFromHour.Value == nmrToHour.Value)
            {
                nmrToMinute.Minimum = nmrFromMinute.Value;
            }
            else
                nmrToMinute.Minimum =0;
        }

        private void nmrToHour_ValueChanged(object sender, EventArgs e)
        {
            checkTime();
        }        
    }
}
