using System.Drawing;
using System.Xml.Serialization;

namespace AppLaplich
{
    public partial class Form1 : Form
    {
        #region Properties
        List<List<Button>> matrix;
        List<string> dayOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        List<Button> buttonOfWeek;
        private PlanData job;
        string filePath = "data.xml";
        public PlanData Jobs { get => job; set => job=value; }
        #endregion
        public Form1()
        {
            InitializeComponent();
            loadMaTrix(); 
            addNumberIntoMatrix(dateTimePickerApp.Value);
            drawDayOfWeek();
            setDefaultDateTimePicker();
            nmrNotify.Enabled = false;
            timerNotify.Start();
            try
            {
                Jobs = deSerializeXml(filePath) as PlanData;
            }
            catch (Exception)
            {
                setDefaultsData();
            }
        }
        
        void setDefaultsData()
        {
            job = new PlanData();
            job.Jobs = new List<PlanItem>();
        }
        void drawDayOfWeek()
        {
            buttonOfWeek = new List<Button>();
            Button oldButton = new Button() { Location = new Point(163, 7) };
            for (int i = 0; i<=6; i++)
            {
                Button btn = new Button() {Location = new Point(oldButton.Location.X,oldButton.Location.Y) ,Width = CONS.widthOfButton,Height =CONS.heightOfButton,BackColor =Color.CornflowerBlue};
                pnlWeekDay.Controls.Add(btn);
                buttonOfWeek.Add(btn);
                oldButton = new Button() { Location = new Point(oldButton.Location.X+CONS.widthOfButton+10, oldButton.Location.Y) };
            }
            nameButtonOfWeek();
        }
        void nameButtonOfWeek()
        {
            for(int i = 0; i<buttonOfWeek.Count;i++)
            {
                Button btn = buttonOfWeek[i];
                btn.Text = dayOfWeek[i].ToString();
            }
        }
        int countDays(DateTime date)
        {
            switch (date.Month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                case 4: case 6: case 9: case 11:
                    return 30;
                case 2: if ((date.Year % 4 == 0 && date.Year%100 !=0) || date.Year %400 == 0)
                    {
                        return 29;
                    }
                    else
                        return 28;
            }
            return 0;
        }
        void clearMatrix()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    btn.Text = "";
                }
            }
        }

        public void loadMaTrix()
        {         
            matrix = new List<List<Button>>();
            Button oldButton = new Button() { Location = new Point(CONS.btnX,CONS.btnY)};
            for (int i = 0; i < CONS.dayOfColumn; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < CONS.dayOfWeek; j++)
                {
                    Button btn = new Button() { Location = new Point(oldButton.Location.X+CONS.widthOfButton+10, oldButton.Location.Y),Height = CONS.heightOfButton,Width = CONS.widthOfButton };
                    btn.Click+=Btn_Click;
                    matrix[i].Add(btn);
                    pnlMonthDays.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton = new Button() { Location = new Point(0, oldButton.Location.Y+CONS.heightOfButton) };
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan dalPlan = new DailyPlan(new DateTime(dateTimePickerApp.Value.Year, dateTimePickerApp.Value.Month, Convert.ToInt32((sender as Button).Text)), Jobs);
            dalPlan.ShowDialog();
        }

        public void addNumberIntoMatrix(DateTime date)
        {
            clearMatrix();
            clearBackColor();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;

            for (int i = 1; i <= countDays(date); i++)
            {
                int column = dayOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = matrix[line][column];
                btn.Text = i.ToString();
                
                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
            
            setColorForNowDate();
        }
        void clearBackColor()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    btn.BackColor = Color.White;
                }
            }
        }
        public void setDefaultDateTimePicker()
        {
            dateTimePickerApp.Value = DateTime.Now;
            setColorForNowDate();
        }
        void setColorForNowDate()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    if (dateTimePickerApp.Value.Month == DateTime.Now.Month && dateTimePickerApp.Value.Year == DateTime.Now.Year)
                    {
                        if (btn.Text == DateTime.Now.Day.ToString())
                            btn.BackColor= Color.BlueViolet;
                    }
                }
            }
        }
        private void dateTimePickerApp_ValueChanged(object sender, EventArgs e)
        {            
            DateTimePicker? date = sender as DateTimePicker;
            if(date != null)
            {
                addNumberIntoMatrix(date.Value);
                setBackColorForButton(dateTimePickerApp, Color.Aqua);
                if (date.Value.Year != DateTime.Now.Year || date.Value.Month != DateTime.Now.Month || date.Value.Day != DateTime.Now.Day)
                {
                    checkNotify.Enabled = false;
                    nmrNotify.Enabled =false;
                }else
                {
                    checkNotify.Enabled = true;
                    nmrNotify.Enabled =true;
                }
                
            }

            
        }
        public void setBackColorForButton(DateTimePicker dateTime,Color color)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    if (btn.Text == dateTime.Value.Day.ToString() && dateTime.Value.Year!=DateTime.Now.Year)
                        btn.BackColor= color;
                    if(btn.Text == dateTime.Value.Day.ToString() && dateTime.Value.Month != DateTime.Now.Month )
                        btn.BackColor= color;
                    if (btn.Text == dateTime.Value.Day.ToString() && dateTime.Value.Day != DateTime.Now.Day)
                        btn.BackColor= color;
                }
            }
        }
        private void btnPreMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerApp.Value = dateTimePickerApp.Value.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerApp.Value = dateTimePickerApp.Value.AddMonths(1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            setDefaultDateTimePicker();  
        }
        private void serializeXml(object ob, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate,FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs, ob);
            fs.Close();
        }
        private object deSerializeXml(string filePath)
        {
         
            FileStream fs = new FileStream(filePath,FileMode.Open,FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object? results = sr.Deserialize(fs);
                fs.Close();
                return results;
            }
            catch (Exception)
            {
                fs.Close();
                throw;
            }            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerNotify.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serializeXml(Jobs, filePath);  
        }

        private void numerNotify_ValueChanged(object sender, EventArgs e)
        {
            CONS.timeNotify = (int)nmrNotify.Value;
            timerNotify.Interval = CONS.timeNotify*60000;
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            if (checkNotify.Checked == false)
                return;
            if (Jobs == null && Jobs.Jobs == null)
                return;
            List<PlanItem> items = Jobs.Jobs.Where(p => p.Date.Year == DateTime.Now.Year && p.Date.Month == DateTime.Now.Month && p.Date.Day == DateTime.Now.Day && p.Status != "DONE").ToList();          
            notifyIcon.ShowBalloonTip(CONS.timeOutNotify,"Thong bao",String.Format("Ban co {0} viec can lam",items.Count),ToolTipIcon.Info);       
        }

        private void checkNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNotify.Checked == true)
                nmrNotify.Enabled = true;
            else
                nmrNotify.Enabled = false;
        }
    } 
}