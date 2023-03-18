using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaplich
{
    public class PlanItem
    {
        private DateTime date;
        public DateTime Date { get => date; set => date=value; }
        private string name;

        public string Name { get => name; set => name=value; }
        private Point fromHour;
        public Point FromHour { get => fromHour; set => fromHour=value; }
        

        

        private Point toHour;
        public Point ToHour { get => toHour; set => toHour=value; }
        private string status;
        public string Status { get => status; set => status=value; }
        

        public static List<string> listStatus = new List<string>() {"DONE","COMING","DOING","MISED","NONE" };

         public enum EPlanItem
        {
            DONE,
            COMING,
            DOING,
            MISED,
            NONE
        }

    }
}
