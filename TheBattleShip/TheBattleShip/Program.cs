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
            int posX = 0;
            int posY = 0;
            Cell[,] field = Game.CeateNewField(10, 10);

            field[9, 4] = new Cell(Cell.CellState.Undamaged);
            field[8, 4] = new Cell(Cell.CellState.Undamaged);
            field[1, 4] = new Cell(Cell.CellState.Undamaged);
            field[7, 0] = new Cell(Cell.CellState.Undamaged);
            field[8, 0] = new Cell(Cell.CellState.Undamaged);
            field[0, 9] = new Cell(Cell.CellState.Undamaged);

            ShipPosition shipPos = new ShipPosition(posX, posY, ShipPosition.Orientation.Right);
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
                    { //тут баг на баге ниже добавить отдельно placement result
                        case ConsoleKey.RightArrow:
                        if(PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X + 1, shipPos.Y, ShipPosition.Orientation.Right)) != PlacementValidator.Result.OutOfRange)
                            shipPos.X += 1;
                            break;
                        case ConsoleKey.LeftArrow:
                        if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X - 1, shipPos.Y, ShipPosition.Orientation.Right)) != PlacementValidator.Result.OutOfRange)
                            shipPos.X -= 1;
                            break;
                        case ConsoleKey.UpArrow:
                        if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X, shipPos.Y - 1, ShipPosition.Orientation.Right)) != PlacementValidator.Result.OutOfRange)
                            shipPos.Y -= 1;
                            break;
                        case ConsoleKey.DownArrow:
                        if (PlacementValidator.FourDeckShipPlacementResult(field, new ShipPosition(shipPos.X, shipPos.Y + 1, ShipPosition.Orientation.Right)) != PlacementValidator.Result.OutOfRange)
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

                Console.Title = "{" + shipPos.X + "} -- {" + shipPos.Y + "} ";
                //Console.Title = "{" + Convert.ToChar(1040 + shipPos.X) + "} -- {" + shipPos.Y + "} ";
                keyInfo = Console.ReadKey();
            }
        }
    }
}
