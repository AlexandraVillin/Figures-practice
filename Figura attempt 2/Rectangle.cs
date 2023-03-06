using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_attempt_2
{
    class Rectangle : Figura, IFigure, IDisplay
    {
        public int A { get; set; }
        public int B { get; set; }

        private static int br;

        public Rectangle()
        {
            this.A = 0;
            this.B = 0;
            br++;
        }

        public Rectangle(int x, int y, string Naziv, int a, int b)
        {
            this.X = x;
            this.Y = y;
            this.Name = Naziv;
            this.A = a;
            this.B = b;
            br++;
        }

        public int Circumference()
        {
            int O = 2 * this.A + 2 * this.B;
            return O;
        }

        public int Area()
        {
            int P = this.A * this.B;
            return P;
        }

        public override string ToString()
        {
            string str = Name + "\n(" + X + "," + Y + ")" + "\nCircumference = " + Circumference() + "\nArea =" + Area() + "\nside a = " + A + "\nside b =" + B;
            return str;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }


        public /*static*/ int GetInstanceNumber()
        {
            return br;
        }
    }
}
