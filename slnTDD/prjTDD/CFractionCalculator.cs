using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTDD
{
    public class CFractionCalculator
    {
        private int Numerator1 { get; set; }
        private int Denominator1 { get; set; }
        private int Numerator2 { get; set; }
        private int Denominator2 { get; set; }

        public void setFraction1(int num, int denom)
        {
            Numerator1 = num;
            Denominator1 = denom;
        }
        public void setFraction2(int num, int denom)
        {

        }

        public string add()
        { 
            return ""; 
        }
    }
}
