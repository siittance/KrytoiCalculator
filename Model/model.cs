using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KrytoiKalculator.Model
{
    public class model
    {
        public model(double Result)
        {
            result = Result;
        }
        public double result { get; set; }
    }
}
