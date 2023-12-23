using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShip
{
    internal class ShipPosition
    {
        public enum Orientation
        {
            Right,
            Down,
            Left,
            Up
        }

        public Orientation orientation;
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (value <= 0)
                    x = 0;
                else if (value >= 9)
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
                if (value <= 0)
                    y = 0;
                else if (value >= 9)
                    y = 9;
                else
                    y = value;
            }
        }

        public ShipPosition()
        {
            this.X = 0;
            this.Y = 0;
            this.orientation = Orientation.Right;
        }

        public ShipPosition(int x, int y, Orientation orientation)
        {
            this.X = x;
            this.Y = y;
            this.orientation = orientation;
        }
    }
}
