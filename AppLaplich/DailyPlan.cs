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
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlanData jobs;
        List<PlanItem> items;
        FlowLayoutPanel pnl = new FlowLayoutPanel();
        public DailyPlan(DateTime date, PlanData jobs)
        {
            InitializeComponent();
            this.date=date;
            this.jobs=jobs;
            checkDoneDay();
            setFlowPnl();
            setDateTimePicker();            
        }
        void checkDoneDay()
        {
            if (Jobs== null || Jobs.Jobs == null)
                return;
            for(int i = 0; i<Jobs.Jobs.Count;i++)
            {
                if (Jobs.Jobs[i].Date < DateTime.Now)
                {
                    if (Jobs.Jobs[i].Status !="DONE")
                        Jobs.Jobs[i].Status = PlanItem.listStatus[(int)PlanItem.EPlanItem.MISED];
                }
            }
        }
        void setFlowPnl()
        {
            pnl = new FlowLayoutPanel();
            pnl.Width = pnlJobs.Width;
            pnl.Height = pnlJobs.Height;
            pnlJobs.Controls.Add(pnl);
        }
        public DateTime Date { get => date; set => date=value; }
        public PlanData Jobs { get => jobs; set => jobs=value; }
       
        void setDateTimePicker()
        {
            dateTimePicker.Value = Date;
        }
        private void showJobsByDate(DateTime date)
        {
            pnl.Controls.Clear();
            items = getJobsByDate(date);
            if (Jobs != null && Jobs.Jobs != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    AJob job = new AJob(items[i]);
                    job.Delete += Job_Delete;
                    pnl.Controls.Add(job);
                }
            }
        }
       
        private void Job_Delete(object? sender, EventArgs e)
        {
            AJob? aj = sender as AJob;
            PlanItem item = aj.Job;
            if(aj!=null)
            {
                pnl.Controls.Remove(aj);
                Jobs.Jobs.Remove(item);
            }
        }

        List<PlanItem> getJobsByDate(DateTime date)
        {
            if (Jobs== null || Jobs.Jobs == null)
                return null;
            return Jobs.Jobs.Where(p=>p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker? date = sender as DateTimePicker;
            showJobsByDate(dateTimePicker.Value);
            if (date.Value.Year < DateTime.Now.Year )
            {
                addWorkToolStripMenuItem.Enabled = false;
            }
            else
            {
                addWorkToolStripMenuItem.Enabled = true;
            }
            if (date.Value.Year == DateTime.Now.Year && date.Value.Month < DateTime.Now.Month)
            {            
                addWorkToolStripMenuItem.Enabled = false;             
            }
            else
            {
                addWorkToolStripMenuItem.Enabled = true;
            }
            if (date.Value.Year == DateTime.Now.Year && date.Value.Month == DateTime.Now.Month && date.Value.Day < DateTime.Now.Day)
            {
                addWorkToolStripMenuItem.Enabled = false;
            }
            else
            {
                addWorkToolStripMenuItem.Enabled = true;
            }
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
        }

        private void addWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Name = "",FromHour = new Point(0,0),ToHour = new Point(0,0),Status = "NONE",Date = dateTimePicker.Value};
            AJob job = new AJob(item);
            job.Delete += Job_Delete;
            pnl.Controls.Add(job);
            Jobs.Jobs.Add(item);           
        }
    }
}
