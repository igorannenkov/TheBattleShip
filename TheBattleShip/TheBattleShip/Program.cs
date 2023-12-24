using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheBattleShip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cell[,] field = Game.CeateNewField(10, 10);
            Cell[,] enemyField = Game.CeateNewField(10, 10);

            Game.DrawField(field);

            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.FourDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.ThreeDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.ThreeDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.TwoDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.TwoDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.TwoDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));
            Game.SetPlayerShip(ref field, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));

            Game.SetEnemyShips(ref enemyField);

            Game.DrawField(enemyField);

        }
    }
}
