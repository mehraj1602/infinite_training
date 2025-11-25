using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ_Demo
{
    public class Client1
    {
        DbInter d;
        public Client1(DbInter m)
        {
            d = m;
        }

        public List<string> AddClient(string st)
        {
            return d.GetData(st);
        }
    }

}
