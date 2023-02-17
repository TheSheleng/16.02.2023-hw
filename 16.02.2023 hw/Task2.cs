using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02._2023_hw
{
    struct DecNum
    {
        public int Whole { get; private set; }
        public int Fraction { get; private set; }
        public DecNum(int whole, int fraction) { Whole = whole; Fraction = fraction; }
        public string GetBin() 
        {
            return Convert.ToString(Whole, 2) + Convert.ToString(Fraction, 2);
        }
        public string GetOct() 
        {
            return Convert.ToString(Whole, 8) + Convert.ToString(Fraction, 8);
        }
        public string GetHex() 
        {
            return Convert.ToString(Whole, 16) + Convert.ToString(Fraction, 16);
        }
    }
}
