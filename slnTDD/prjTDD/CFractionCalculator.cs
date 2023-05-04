using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Numerator2 = num;
            Denominator2 = denom;
        }

        public string add()
        {
            int num = Numerator1 * Denominator2 + Numerator2 * Denominator1;
            int denom = Denominator1 * Denominator2;
            if (denom == 0) { return "Invalid"; }
            if (num == 0) { return "0"; }
            reduction(ref num, ref denom);
            return $"{num}/{denom}";
        }
        private void reduction(ref int num, ref int denom)
        {
            if (denom < 0)
            {
                num *= -1;
                denom *= -1;
            }
            int gcd = getGcd(num, denom);
            num /=gcd; denom /=gcd;
        }
        private int getGcd(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
    }
}
