using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice
{
    public class OrdinaryClient : Client
    {
        public OrdinaryClient(string name, string sname)
        {
            SetDefaultValues(name, sname);
        }
        public OrdinaryClient(string name,string sname,bool discount)
        {
            SetDefaultValues(name, sname);
            if (discount) this.SetDiscount(10);
        }

        private void SetDefaultValues(string name, string sname)
        {
            this.firstName = name;
            this.secondName = sname;
            this.AccumulativeDiscount = 5;
        }
    }
}
