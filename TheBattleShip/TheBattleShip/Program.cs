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
            Cell[,] playerField = Game.CeateNewField(10, 10);
            Cell[,] cpuField = Game.CeateNewField(10, 10);

            Game.ShowSplashScreen();

            Game.DrawField(playerField);

            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.FourDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.ThreeDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.ThreeDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.TwoDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.TwoDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.TwoDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));
            Game.SetPlayerShip(ref playerField, new ShipInfo(5, 5, ShipInfo.Orientation.Horizontal, ShipInfo.ShipRank.OneDeck));

            Game.SetEnemyShips(ref cpuField);

            Game.ShowFields(playerField, cpuField);

            Game.StartGame(ref playerField, ref cpuField);
        }
    }
}
