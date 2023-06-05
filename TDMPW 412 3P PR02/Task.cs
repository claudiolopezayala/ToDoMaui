using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_3P_PR02
{
    public class Task : ICloneable
    {
        public string title;
        public string description;

        public Task(string _title, string _description)
        {
            title = _title;
            description = _description;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
