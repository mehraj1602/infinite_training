using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    internal class PrototypePattern
    
        
        {
            public int p1 { get; set; }
            public int p2 { get; set; }


            public object Clone()
            {//copies all data to second object
                return this.MemberwiseClone(); // Shallow copy
            }
        }

    }

