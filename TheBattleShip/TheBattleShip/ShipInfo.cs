using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShip
{
    internal class ShipInfo
    {
        public enum Orientation
        {
            Horizontal,
            Vertical
        }

        public enum ShipRank
        {
            OneDeck = 1,
            TwoDeck,
            ThreeDeck,
            FourDeck
        }

        public Orientation orientation;
        public ShipRank shipRank;
        private int x;
        private int y;

        public int PositionX
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

        public int PositionY
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

        public ShipInfo()
        {
            this.PositionX = 0;
            this.PositionY = 0;
            this.orientation = Orientation.Horizontal;
            this.shipRank = ShipRank.OneDeck;
        }

        public ShipInfo(int x, int y, Orientation orientation, ShipRank shipRank)
        {
            this.PositionX = x;
            this.PositionY = y;
            this.orientation = orientation;
            this.shipRank = shipRank;
        }
    }
}
