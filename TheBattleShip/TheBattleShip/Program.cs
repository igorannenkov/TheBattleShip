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
            do
            {
                Cell[,] myField = Game.CeateNewField(10, 10);
                Cell[,] enemyField = Game.CeateNewField(10, 10);
                Game.GenerateShips(ref myField, ref enemyField);
                Game.ShowFields(myField, enemyField);
                Console.ReadKey();
                Console.Clear();
            }
            while (true);
        }
    }
}
