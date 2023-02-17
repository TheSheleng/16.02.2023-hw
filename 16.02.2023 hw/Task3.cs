using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02._2023_hw
{
    struct RGB
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public RGB(int r, int g, int b) { R = r; G = g; B = b; }
        public string GetRGB()
        {
            return $"R: {R}, G: {G}, B: {B}";
        }
        public string GetHEX()
        {
            string rhex = Convert.ToString(R, 16);
            string ghex = Convert.ToString(G, 16);
            string bhex = Convert.ToString(B, 16);

            return $"#" +
                $"{new string('0', 2 - rhex.Length) + rhex}" +
                $"{new string('0', 2 - ghex.Length) + ghex}" +
                $"{new string('0', 2 - bhex.Length) + bhex}";
        }
    }
}
