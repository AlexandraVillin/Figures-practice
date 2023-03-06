using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_attempt_2
{
    class Elipse : Figura, IFigure, IDisplay
    {
        int R1 { get; set; }
        int R2 { get; set; }

        public Elipse()
        {
            this.R1 = 0;
            this.R2 = 0;
        }

        public Elipse(int x, int y, string Naziv, int r1, int r2)
        {
            this.X = x;
            this.Y = y;
            this.Name = Naziv;
            this.R1 = r1;
            this.R2 = r2;
        }

        public int Circumference()
        {
            int O = 2 * this.R1 + 2 * this.R1;
            return O;
        }

        public int Area()
        {
            int P = this.R1 * this.R2;
            return P;
        }

        public override string ToString()
        {
            string str = Name + "\n(" + X + "," + Y + ")" + "\nCircumference = " + Circumference() + "\nArea =" + Area() + "\ndiameter r1 = " + R1 + "\ndiameter r2 = " + R2;
            return str;
        }
        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
