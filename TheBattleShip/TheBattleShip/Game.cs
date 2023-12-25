using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheBattleShip
{
    internal static class Game
    {
        public static void ShowSplashScreen()
        {

            Console.SetCursorPosition(25, 7);
            Console.WriteLine();
            Console.WriteLine("                                                              ██                ██ ");
            Console.WriteLine("                              █   █ ████ ████ ████ █  █ ████ █  █    ████ ████ █  █");
            Console.WriteLine("                              ██ ██ █  █ █  █ █  █ █ █  █  █ █  █    █    █  █ █  █");
            Console.WriteLine("                              █ █ █ █  █ ████ █    ██   █  █ █ ██    ████ █  █ █ ██");
            Console.WriteLine("                              █   █ █  █ █    █  █ █ █  █  █ ██ █    █  █ █  █ ██ █");
            Console.WriteLine("                              █   █ ████ █    ████ █  █ ████ █  █    ████ ████ █  █");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                          Это заставка игры бой. Для продолжения нажмите любую клавишу.");

            Console.ReadKey();
            Console.Clear();
        }

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

            Console.SetCursorPosition(0, 0);

            for (int p = 0; p < width; p++)
            {
                if (p == 0)
                    Console.Write("  " + Convert.ToChar(1040 + p));
                else
                    Console.Write(" " + Convert.ToChar(1040 + p));
            }
            Console.Write("\t");
            for (int p = 0; p < height; p++)
            {
                if (p == 0)
                    Console.Write("  " + Convert.ToChar(1040 + p));
                else
                    Console.Write(" " + Convert.ToChar(1040 + p));
            }
            Console.WriteLine();

            for (int i = 0; i < width; i++)
            {
                Console.Write(i);
                for (int j = 0; j < height; j++)
                {
                    switch (myField[j, i].cellState)
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
                for (int k = 0; k < height; k++)
                {

                    switch (enemyField[k, i].cellState)
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

            Console.SetCursorPosition(0, 0);

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
   
        public static void SetEnemyShips(ref Cell[,] field)
        {
            Random rnd = new Random();
            ShipInfo randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.FourDeck);
            //4
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnFourDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.FourDeck);
            }
            //3
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.ThreeDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnThreeDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.ThreeDeck);
            }
            //3
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.ThreeDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnThreeDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.ThreeDeck);
            }
            //2
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.TwoDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnTwoDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.TwoDeck);
            }
            //2
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.TwoDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnTwoDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.TwoDeck);
            }
            //2
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.TwoDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnTwoDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.TwoDeck);
            }
            //1
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnOneDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            }
            //1
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnOneDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            }
            //1
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnOneDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            }
            //1
            randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            while (true)
            {
                if (ShipPlacementValidator.Validate(field, randomShip) == ShipPlacementValidator.Result.Correct)
                {
                    ShipSpawner.SpawnOneDeckedShip(ref field, randomShip);
                    break;
                }
                randomShip = new ShipInfo(rnd.Next(10), rnd.Next(10), (ShipInfo.Orientation)rnd.Next(1, 3), ShipInfo.ShipRank.OneDeck);
            }
        }
    
        public static void DrawShip(ShipInfo shipInfo, ShipPlacementValidator.Result placementResult)
        {
            int shipRank = (int)shipInfo.shipRank;
            if (placementResult == ShipPlacementValidator.Result.OutOfRange)
            {
                return;
            }

            int x = (shipInfo.PositionX * 2) + 1;
            int y = shipInfo.PositionY + 1;
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

            switch (shipInfo.orientation)
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

        public static void SetPlayerShip(ref Cell[,] field, ShipInfo shipInfo)
        {
            ShipInfo.Orientation currentOrientation = shipInfo.orientation;
            ShipPlacementValidator.Result placementResult = ShipPlacementValidator.Validate(field, shipInfo);
            DrawShip(shipInfo, placementResult);
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            while (true)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        if (ShipPlacementValidator.Validate(field, shipInfo) == ShipPlacementValidator.Result.Correct)
                        {
                            int x = shipInfo.PositionX;
                            int y = shipInfo.PositionY;

                            if(shipInfo.orientation == ShipInfo.Orientation.Horizontal)
                            {
                                for (int i = 0; i < (int)shipInfo.shipRank; i++)
                                {
                                    field[x + i, y].cellState = Cell.CellState.Undamaged;
                                }
                                DrawField(field);
                                return;
                            }
                            if (shipInfo.orientation == ShipInfo.Orientation.Vertical)
                            {
                                for (int i = 0; i < (int)shipInfo.shipRank; i++)
                                {
                                    field[x, y + i].cellState = Cell.CellState.Undamaged;
                                }
                                DrawField(field);
                                return;
                            }
                        }
                        break;

                    case ConsoleKey.R:
                        if (shipInfo.orientation == ShipInfo.Orientation.Horizontal)
                        {
                            if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY, ShipInfo.Orientation.Vertical, shipInfo.shipRank)) != ShipPlacementValidator.Result.OutOfRange)
                            {
                                shipInfo.orientation = ShipInfo.Orientation.Vertical;
                                currentOrientation = shipInfo.orientation;
                            }
                            break;
                        }
                        if (shipInfo.orientation == ShipInfo.Orientation.Vertical)
                        {
                            if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY, ShipInfo.Orientation.Horizontal, shipInfo.shipRank)) != ShipPlacementValidator.Result.OutOfRange)
                            {
                                shipInfo.orientation = ShipInfo.Orientation.Horizontal;
                                currentOrientation = shipInfo.orientation;
                            }
                            break;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX + 1, shipInfo.PositionY, currentOrientation, shipInfo.shipRank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionX += 1;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX - 1, shipInfo.PositionY, currentOrientation, shipInfo.shipRank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionX -= 1;
                        break;

                    case ConsoleKey.UpArrow:
                        if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY - 1, currentOrientation, shipInfo.shipRank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionY -= 1;
                        break;

                    case ConsoleKey.DownArrow:
                        if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY + 1, currentOrientation, shipInfo.shipRank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionY += 1;
                        break;
                }

                placementResult = ShipPlacementValidator.Validate(field, shipInfo);

                if (placementResult != ShipPlacementValidator.Result.OutOfRange)
                {
                    Game.DrawField(field);
                    Game.DrawShip(shipInfo, placementResult);
                }

                Console.Title = "X: " + shipInfo.PositionX + "  |  Y: " + shipInfo.PositionY + "  |  Orientation: " + currentOrientation + "  |  State: " + placementResult;
                keyInfo = Console.ReadKey();
            }
        }

        public static void StartGame(ref Cell[,] playerField, ref Cell[,] cpuField)
        {
            int playerShipCount = 20;
            int cpuShipCount = 20;

            while (playerShipCount > 0 || cpuShipCount > 0)
            {
                PlayerTurn();
                CpuTurn();
            }

            void PlayerTurn()
            {
                if (playerShipCount == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Вы проиграли!");
                    return;
                }
                throw new NotImplementedException();
            }

            void CpuTurn()
            {
                if (cpuShipCount == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Вы выиграли!");
                    return;
                }
                throw new NotImplementedException();
            }
        }

        
    }
}