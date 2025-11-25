using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ_Demo
{
    public class Client
    {
        IMath math;
        public Client(IMath m)
        {
            math = m;
        }

        public string AddClient(int x, int y)
        {
            // other logic goes here
            // other logic goes here
            return math.Add(x, y);
        }
    }
}
