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
            int posX = 9;
            int posY = 5;
            Cell[,] field = Game.CeateNewField(10, 10);

            field[9, 4] = new Cell(Cell.CellState.Undamaged);
            field[8, 4] = new Cell(Cell.CellState.Undamaged);
            field[1, 4] = new Cell(Cell.CellState.Undamaged);
            field[7, 0] = new Cell(Cell.CellState.Undamaged);
            field[8, 0] = new Cell(Cell.CellState.Undamaged);
            field[0, 9] = new Cell(Cell.CellState.Undamaged);

            ShipPosition.Orientation currentOrientation = ShipPosition.Orientation.Vertical;

           

            ShipPosition shipPos = new ShipPosition(posX, posY, ShipPosition.Orientation.Vertical);
            PlacementValidator.Result placementResult = PlacementValidator.FourDeckShipPlacementResult(field, shipPos);

            Game.DrawField(field);
            Game.DrawShip(shipRank:4, shipPos, placementResult);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            /*
            
             Нажали на кнопку: 
             - изменили координаты стрелками и смотрим:
             - если позиция ОК или Некорректно:
                - перерисовать поле
                - перерисовать кораблик в зависимости от позиции
            - иначе перейти к след итерации.
             */

            while (true)
            {
                    switch (keyInfo.Key)
                    {
                    case ConsoleKey.R:
                        if (shipPos.orientation == ShipPosition.Orientation.Horizontal)
                        {
                            if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X, shipPos.Y, ShipPosition.Orientation.Vertical)) != PlacementValidator.Result.OutOfRange)
                            {
                                shipPos.orientation = ShipPosition.Orientation.Vertical;
                                currentOrientation = shipPos.orientation;
                            }
                            break;
                        }
                        if (shipPos.orientation == ShipPosition.Orientation.Vertical)
                        {
                            if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X, shipPos.Y, ShipPosition.Orientation.Horizontal)) != PlacementValidator.Result.OutOfRange)
                            {
                                shipPos.orientation = ShipPosition.Orientation.Horizontal;
                                currentOrientation = shipPos.orientation;
                            }
                            break;
                        }
                        break;     

                    case ConsoleKey.RightArrow:
                        if(PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X + 1, shipPos.Y, currentOrientation)) != PlacementValidator.Result.OutOfRange)
                            shipPos.X += 1;
                            break;

                        case ConsoleKey.LeftArrow:
                        if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X - 1, shipPos.Y, currentOrientation)) != PlacementValidator.Result.OutOfRange)
                            shipPos.X -= 1;
                            break;

                        case ConsoleKey.UpArrow:
                        if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X, shipPos.Y - 1, currentOrientation)) != PlacementValidator.Result.OutOfRange)
                            shipPos.Y -= 1;
                            break;

                        case ConsoleKey.DownArrow:
                        if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X, shipPos.Y + 1, currentOrientation)) != PlacementValidator.Result.OutOfRange)
                            shipPos.Y += 1;
                            break;
                    }
                // после каждого изменения координат проверяем положение.
                placementResult = PlacementValidator.FourDeckShipPlacementResult(field, shipPos);

                if (placementResult != PlacementValidator.Result.OutOfRange)
                {
                    Console.SetCursorPosition(0, 0);
                    Game.DrawField(field);
                    Game.DrawShip(shipRank: 4, shipPos, placementResult);
                }

                Console.Title = "X: " + shipPos.X + "  Y: " + shipPos.Y + "  Orientation " + currentOrientation;
                //Console.Title = "{" + Convert.ToChar(1040 + shipPos.X) + "} -- {" + shipPos.Y + "} ";
                keyInfo = Console.ReadKey();
            }
        }
    }
}
