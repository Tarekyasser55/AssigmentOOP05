using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP05
{
    public static class Maths
    {
        
        public static double Add(double n1,double n2)
        {

            return n1 + n2;
        }
        public static double Subtract(double n1 , double n2 )
        {
            return n1 - n2;
        }
        public static double Multiply(double n1, double n2)
        {

            return n1 * n2;
        }
        public static double Divide(double n1, double n2)
        {
            if (n2 != 0)
                return n1 / n2;
            else
                return -999;
        }

    }
}
