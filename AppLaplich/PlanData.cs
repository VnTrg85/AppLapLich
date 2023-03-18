using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaplich
{
    [Serializable]
    public class PlanData
    {
        private bool isNotify;
        public bool IsNotify { get => isNotify; set => isNotify=value; }
        private List<PlanItem> jobs;
        public List<PlanItem> Jobs { get => jobs; set => jobs=value; }

    }
}
