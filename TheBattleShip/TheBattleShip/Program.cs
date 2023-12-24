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

            ShipInfo.Orientation currentOrientation = ShipInfo.Orientation.Vertical;
            ShipInfo.ShipRank rank = ShipInfo.ShipRank.FourDeck;
            ShipInfo shipInfo = new ShipInfo(posX, posY, ShipInfo.Orientation.Vertical, rank);

            ShipPlacementValidator.Result placementResult = ShipPlacementValidator.Validate(field, shipInfo); 

            Game.DrawField(field);
            Game.DrawShip(rank, shipInfo, placementResult);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            while (true)
            {
                    switch (keyInfo.Key)
                    {
                    case ConsoleKey.R:
                        if (shipInfo.orientation == ShipInfo.Orientation.Horizontal)
                        {
                            if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY, ShipInfo.Orientation.Vertical, rank)) != ShipPlacementValidator.Result.OutOfRange)
                            {
                                shipInfo.orientation = ShipInfo.Orientation.Vertical;
                                currentOrientation = shipInfo.orientation;
                            }
                            break;
                        }
                        if (shipInfo.orientation == ShipInfo.Orientation.Vertical)
                        {
                            if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY, ShipInfo.Orientation.Horizontal, rank)) != ShipPlacementValidator.Result.OutOfRange)
                            {
                                shipInfo.orientation = ShipInfo.Orientation.Horizontal;
                                currentOrientation = shipInfo.orientation;
                            }
                            break;
                        }
                        break;     

                    case ConsoleKey.RightArrow:
                        if(ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX + 1, shipInfo.PositionY, currentOrientation, rank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionX += 1;
                            break;

                        case ConsoleKey.LeftArrow:
                        if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX - 1, shipInfo.PositionY, currentOrientation, rank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionX -= 1;
                            break;

                        case ConsoleKey.UpArrow:
                        if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY - 1, currentOrientation, rank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionY -= 1;
                            break;

                        case ConsoleKey.DownArrow:
                        if (ShipPlacementValidator.Validate(field, new ShipInfo(shipInfo.PositionX, shipInfo.PositionY + 1, currentOrientation, rank)) != ShipPlacementValidator.Result.OutOfRange)
                            shipInfo.PositionY += 1;
                            break;
                    }

                placementResult = ShipPlacementValidator.Validate(field, shipInfo);

                if (placementResult != ShipPlacementValidator.Result.OutOfRange)
                {
                    Console.SetCursorPosition(0, 0);
                    Game.DrawField(field);
                    Game.DrawShip(rank, shipInfo, placementResult);
                }

                Console.Title = "X: " + shipInfo.PositionX + "  |  Y: " + shipInfo.PositionY + "  |  Orientation: " + currentOrientation + "  |  State: " + placementResult;
                keyInfo = Console.ReadKey();
            }
        }
    }
}
