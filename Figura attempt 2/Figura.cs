using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_attempt_2
{
    class Figura
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Name { get; set; }

        private static int bf;

        public Figura()
        {
            this.x = 0;
            this.y = 0;
            this.Name = "";
            bf++;
        }

        public Figura(int x, int y, string Name)
        {
            this.x = x;
            this.y = y;
            this.Name = Name;
            bf++;
        }

        public void Translate(int xmove, int ymove)
        {
            this.x = x + xmove;
            this.y = y + xmove;
        }

        public override string ToString()
        {
            string str = Name + "(" + x + "," + y + ")";
            return str;
        }

        public /*static*/ int GetFigureInstanceNumber()
        {
            return bf;
        }
    }
}
