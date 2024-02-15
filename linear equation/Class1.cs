using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_equation
{
    struct LinEquation
    {
        double k;        
        double b;

        public LinEquation(double k, double b)
        {
            this.k = k;            
            this.b = b;
        }

        public string Root()
        {
            if (k == 0) return "infinity";
            double x = -b / k;
            return $"x = {x:0.000}";
        }

    }
}
