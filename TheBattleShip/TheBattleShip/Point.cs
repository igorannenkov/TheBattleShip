using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TheBattleShip
{
    internal class Point
    {
        private int x;
        private int y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        
        public Point(int x, int y)
        {
            if (x < 0) 
            { 
                this.x = 0; 
            }
            else if (x > 9) 
            { 
                this.x = 9; 
            }
            else 
            { 
                this.x = x; 
            }

            if (y < 0) 
            { 
                this.y = 0; 
            }
            else if (y > 9) 
            { 
                this.y = 9;
            }
            else 
            { 
                this.y = y; 
            }
         
        }

        public int X
        {
            get { return x; }
            set
            {
                if (x < 0)
                    x = 0;
                if (x > 9)
                    x = 9;
                else
                    x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (y < 0)
                    y = 0;
                if (y > 9)
                    y = 9;
                else
                    y = value;
            }
        }
    }
}
