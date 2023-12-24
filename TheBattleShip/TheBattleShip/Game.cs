using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheBattleShip
{
    internal static class Game
    {
        public static Cell[,] CeateNewField(int height, int width)
        {
            Cell[,] field = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = new Cell();
                }
            }
            return field;
        }

        public static void ShowFields(Cell[,] myField, Cell[,] enemyField)
        {
            int height = (int)Math.Sqrt(myField.Length);
            int width = (int)Math.Sqrt(myField.Length);

            for (int p = 0; p < height; p++)
            {
                if (p == 0)
                    Console.Write("  " + Convert.ToChar(1040 + p));
                else
                    Console.Write(" " + Convert.ToChar(1040 + p));
            }
            Console.Write("\t");
            for (int p = 0; p < width; p++)
            {
                if (p == 0)
                    Console.Write("  " + Convert.ToChar(1040 + p));
                else
                    Console.Write(" " + Convert.ToChar(1040 + p));
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.Write(i);
                for (int j = 0; j < width; j++)
                {
                    switch (myField[i, j].cellState)
                    {
                        case Cell.CellState.Dead:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Empty:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Missed:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Undamaged:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                    }

                }
                Console.Write("\t" + i);
                for (int k = 0; k < width; k++)
                {

                    switch (enemyField[i, k].cellState)
                    {
                        case Cell.CellState.Dead:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Empty:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Missed:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Undamaged:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                    }
                }
                Console.WriteLine();
            }
        }


        public static void DrawField(Cell[,] field)
        {
            int width = (int)Math.Sqrt(field.Length);
            int height = (int)Math.Sqrt(field.Length);
            

            for (int p = 0; p < height; p++)
            {
                Console.Write(" " + Convert.ToChar(1040 + p));
            }         

            Console.WriteLine();

            for (int i = 0; i < width; i++)
            {
                Console.Write(i);
                for (int j = 0; j < height; j++)
                {
                    switch (field[j, i].cellState)
                    {
                        case Cell.CellState.Dead:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Empty:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Missed:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                        case Cell.CellState.Undamaged:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("░░");
                            Console.ResetColor();
                            break;
                    }

                }
                Console.WriteLine();
            }
               
        }
    /*
        static void GenerateFourDeckedShips(ref Cell[,] field)
        {
            int ships = 1;
            Random random = new Random();
            do
            {
                int x = random.Next(10);
                int y = random.Next(10);
                ShipSpawner.Orientation direction = (ShipSpawner.Orientation)random.Next(1, 5);
                if (PlacementValidator.FourDeckShipPlacementResult(field, x, y, direction) == PlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnFourDeckedShip(ref field, x, y, direction);
                    ships--;
                }

            } while (ships > 0);
        }

        static void GenerateThreeDeckedShips(ref Cell[,] field)
        {
            int ships = 2;
            Random random = new Random();
            do
            {
                int x = random.Next(10);
                int y = random.Next(10);
                ShipSpawner.Orientation direction = (ShipSpawner.Orientation)random.Next(1, 5);
                if (PlacementValidator.ThreeDeckShipPlacementResult(field, x, y, direction) == PlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnThreeDeckedShip(ref field, x, y, direction);
                    ships--;
                }

            } while (ships > 0);
        }

        static void GenerateTwoDeckedShips(ref Cell[,] field)
        {
            int ships = 3;
            Random random = new Random();
            do
            {
                int x = random.Next(10);
                int y = random.Next(10);
                ShipSpawner.Orientation direction = (ShipSpawner.Orientation)random.Next(1, 5);
                if (PlacementValidator.TwoDeckShipPlacementIsValid(field, x, y, direction) == PlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnTwoDeckedShip(ref field, x, y, direction);
                    ships--;
                }

            } while (ships > 0);
        }

        static void GenerateOneDeckedShips(ref Cell[,] field)
        {
            int ships = 4;
            Random random = new Random();
            do
            {
                int x = random.Next(10);
                int y = random.Next(10);
                ShipSpawner.Orientation direction = (ShipSpawner.Orientation)random.Next(1, 5);
                if (PlacementValidator.OneDeckShipPlacementIsValid(field, x, y) == PlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnOneDeckedShip(ref field, x, y);
                    ships--;
                }

            } while (ships > 0);
        }
        */
    /*
        public static void GenerateShips(ref Cell[,] myField, ref Cell[,] enemyField)
        {
            GenerateFourDeckedShips(ref myField);
            Thread.Sleep(2);
            GenerateThreeDeckedShips(ref myField); Thread.Sleep(2);
            GenerateTwoDeckedShips(ref myField); Thread.Sleep(2);
            GenerateOneDeckedShips(ref myField); Thread.Sleep(2);
            GenerateFourDeckedShips(ref enemyField); Thread.Sleep(2);
            GenerateThreeDeckedShips(ref enemyField); Thread.Sleep(2);
            GenerateTwoDeckedShips(ref enemyField); Thread.Sleep(2);
            GenerateOneDeckedShips(ref enemyField);
        }
    */

        public static void DrawShip(ShipInfo.ShipRank rank, ShipInfo shipPosition, ShipPlacementValidator.Result placementResult)
        {
            int shipRank = (int)rank;
            if (placementResult == ShipPlacementValidator.Result.OutOfRange)
            {
                return;
            }

            int x = (shipPosition.PositionX * 2) + 1;
            int y = shipPosition.PositionY + 1;
            Console.SetCursorPosition(x, y);

            switch (placementResult)
            {
                case ShipPlacementValidator.Result.Correct:
                    Console.ForegroundColor = ConsoleColor.Green; 
                    break;

                case ShipPlacementValidator.Result.Incorrect:
                    Console.ForegroundColor = ConsoleColor.Red; 
                    break;

                case ShipPlacementValidator.Result.OutOfRange:
                    break;
            }


            // Console.SetCursorPosition(x * 2, y * 2);
            switch (shipPosition.orientation)
            {

                case ShipInfo.Orientation.Vertical:
                    for (int i = 0; i < shipRank; i++)
                    {  
                        Console.SetCursorPosition(x , y + i);
                        Console.Write("░░");
                    }
                    break;

                case ShipInfo.Orientation.Horizontal:
                    for (int i = 0; i < shipRank; i++)
                    {         
                        Console.Write("░░");
                    }
                    break;
            }
            Console.ResetColor();
            Console.Write("\b");
        }
        

        public static void GenerateShipsManual(ref Cell[,] field)
        {
            // 3-pal
            int shipcount = 2;
            do
            {

            }
            while (shipcount > 0);
        }
    }
}