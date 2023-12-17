using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheBattleShip.PlacementValidator;

namespace TheBattleShip
{
    internal static class PlacementValidator
    {
        public enum PlacementResult
        {
            Correct,
            Incorrect,
            OutOfRange
        }

        public static PlacementResult FourDeckShipPlacementResult(Cell[,] field, int x, int y, ShipSpawner.SpawnDirection direction)
        {
            if (field[x, y].cellState == Cell.CellState.Empty)
            {
                try
                {
                    switch (direction)
                    {
                        case ShipSpawner.SpawnDirection.Down: // размещаем вертикально вниз

                            if (x == 0 && y > 4)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 4 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y + 3].cellState == Cell.CellState.Empty &&
                                field[x, y + 4].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct; 
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 4)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y + 3].cellState == Cell.CellState.Empty &&
                                field[x, y + 4].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 4].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x, y + 2].cellState == Cell.CellState.Empty &&
                               field[x, y + 3].cellState == Cell.CellState.Empty &&
                               field[x, y + 4].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x, y + 2].cellState == Cell.CellState.Empty &&
                               field[x, y + 3].cellState == Cell.CellState.Empty &&
                               field[x, y + 4].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 4].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y + 3].cellState == Cell.CellState.Empty &&
                                field[x, y + 4].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;

                        case ShipSpawner.SpawnDirection.Up: // вертикально вверх


                            if (x == 0 && y > 4)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 2].cellState == Cell.CellState.Empty &&
                                    field[x, y - 3].cellState == Cell.CellState.Empty &&
                                    field[x, y - 4].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 4].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 4 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 2].cellState == Cell.CellState.Empty &&
                                field[x, y - 3].cellState == Cell.CellState.Empty &&
                                field[x, y - 4].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 3].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 4].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 4].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 4)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 2].cellState == Cell.CellState.Empty &&
                                field[x, y - 3].cellState == Cell.CellState.Empty &&
                                field[x, y - 4].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 4].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }


                            if (x == Math.Sqrt(field.Length) - 1 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x, y - 2].cellState == Cell.CellState.Empty &&
                               field[x, y - 3].cellState == Cell.CellState.Empty &&
                               field[x, y - 4].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 3].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 4].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x, y - 2].cellState == Cell.CellState.Empty &&
                               field[x, y - 3].cellState == Cell.CellState.Empty &&
                               field[x, y - 4].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 3].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 4].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 2].cellState == Cell.CellState.Empty &&
                            field[x, y - 3].cellState == Cell.CellState.Empty &&
                            field[x, y - 4].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 3].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 4].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 3].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 4].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }

                            return PlacementResult.Incorrect;
                        case ShipSpawner.SpawnDirection.Right: //горизонтально вправо


                            if (x == 0 && y > 4)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 4 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 2, y].cellState == Cell.CellState.Empty &&
                                field[x + 3, y].cellState == Cell.CellState.Empty &&
                                field[x + 4, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 4, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 4 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 2, y].cellState == Cell.CellState.Empty &&
                               field[x + 3, y].cellState == Cell.CellState.Empty &&
                               field[x + 4, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 2, y].cellState == Cell.CellState.Empty &&
                               field[x + 3, y].cellState == Cell.CellState.Empty &&
                               field[x + 4, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 2, y].cellState == Cell.CellState.Empty &&
                                field[x + 3, y].cellState == Cell.CellState.Empty &&
                                field[x + 4, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 4, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                            field[x + 3, y].cellState == Cell.CellState.Empty &&
                            field[x + 4, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                            field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                            field[x + 4, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;
                        case ShipSpawner.SpawnDirection.Left: //горизонтально влево

                            if (x > 4 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 3, y].cellState == Cell.CellState.Empty &&
                                field[x - 4, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 4, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 4 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 3, y].cellState == Cell.CellState.Empty &&
                                field[x - 4, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 4, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 4)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 3, y].cellState == Cell.CellState.Empty &&
                                field[x - 4, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 4, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 4, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 2, y].cellState == Cell.CellState.Empty &&
                               field[x - 3, y].cellState == Cell.CellState.Empty &&
                               field[x - 4, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 3, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 4, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 2, y].cellState == Cell.CellState.Empty &&
                               field[x - 3, y].cellState == Cell.CellState.Empty &&
                               field[x - 4, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 3, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 4, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 2, y].cellState == Cell.CellState.Empty &&
                            field[x - 3, y].cellState == Cell.CellState.Empty &&
                            field[x - 4, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 3, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 4, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 3, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 4, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;
                    }
                }
                catch (IndexOutOfRangeException) { return PlacementResult.OutOfRange; }
                return PlacementResult.Incorrect;
            }
            else
            {
                return PlacementResult.Incorrect;
            }
        }

        public static PlacementResult ThreeDeckShipPlacementResult(Cell[,] field, int x, int y, ShipSpawner.SpawnDirection direction)
        {
            if (field[x, y].cellState == Cell.CellState.Empty)
            {
                try
                {
                    switch (direction)
                    {
                        case ShipSpawner.SpawnDirection.Down: // размещаем вертикально вниз

                            if (x == 0 && y > 3)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 3 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y + 3].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 3)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y + 3].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 3].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x, y + 2].cellState == Cell.CellState.Empty &&
                               field[x, y + 3].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x, y + 2].cellState == Cell.CellState.Empty &&
                               field[x, y + 3].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 3].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y + 3].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;

                        case ShipSpawner.SpawnDirection.Up: // вертикально вверх


                            if (x == 0 && y > 3)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 2].cellState == Cell.CellState.Empty &&
                                    field[x, y - 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 3].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 3 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 2].cellState == Cell.CellState.Empty &&
                                field[x, y - 3].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 3].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 3)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 2].cellState == Cell.CellState.Empty &&
                                field[x, y - 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 3].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }


                            if (x == Math.Sqrt(field.Length) - 1 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x, y - 2].cellState == Cell.CellState.Empty &&
                               field[x, y - 3].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 3].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x, y - 2].cellState == Cell.CellState.Empty &&
                               field[x, y - 3].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 3].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                    
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 2].cellState == Cell.CellState.Empty &&
                            field[x, y - 3].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 3].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 3].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }

                            return PlacementResult.Incorrect;
                        case ShipSpawner.SpawnDirection.Right: //горизонтально вправо


                            if (x == 0 && y > 3)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 3 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 2, y].cellState == Cell.CellState.Empty &&
                                field[x + 3, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 3 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 2, y].cellState == Cell.CellState.Empty &&
                               field[x + 3, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 2, y].cellState == Cell.CellState.Empty &&
                               field[x + 3, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 2, y].cellState == Cell.CellState.Empty &&
                                field[x + 3, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 3, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                            field[x + 3, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                            field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;
                        case ShipSpawner.SpawnDirection.Left: //горизонтально влево

                            if (x > 3 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 3, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 3 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 3, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 3)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 3, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 3, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 2, y].cellState == Cell.CellState.Empty &&
                               field[x - 3, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 3, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 2, y].cellState == Cell.CellState.Empty &&
                               field[x - 3, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 3, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 2, y].cellState == Cell.CellState.Empty &&
                            field[x - 3, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 3, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 3, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;
                    }
                }
                catch (IndexOutOfRangeException) { return PlacementResult.OutOfRange; }
                return PlacementResult.Incorrect;
            }
            else
            {
                return PlacementResult.Incorrect;
            }
        }

        public static PlacementResult TwoDeckShipPlacementIsValid(Cell[,] field, int x, int y, ShipSpawner.SpawnDirection direction)
        {
            if (field[x, y].cellState == Cell.CellState.Empty)
            {
                try
                {
                    switch (direction)
                    {
                        case ShipSpawner.SpawnDirection.Down: // размещаем вертикально вниз

                            if (x == 0 && y > 2)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 2 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 2)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x, y + 2].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x, y + 2].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 2].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y + 2].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;

                        case ShipSpawner.SpawnDirection.Up: // вертикально вверх


                            if (x == 0 && y > 2)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 2 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 2].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 2].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 2)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }


                            if (x == Math.Sqrt(field.Length) - 1 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x, y - 2].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 2].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x, y - 2].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 2].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 2].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 2].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 2].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }

                            return PlacementResult.Incorrect;
                        case ShipSpawner.SpawnDirection.Right: //горизонтально вправо


                            if (x == 0 && y > 2)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 2 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 2, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 2 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 2, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 1, y].cellState == Cell.CellState.Empty &&
                               field[x + 2, y].cellState == Cell.CellState.Empty &&
                               field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == 0 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 2, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 2, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;
                        case ShipSpawner.SpawnDirection.Left: //горизонтально влево

                            if (x > 2 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x > 2 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x + 1, y].cellState == Cell.CellState.Empty &&
                                field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y > 2)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                field[x, y + 1].cellState == Cell.CellState.Empty &&
                                field[x, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y].cellState == Cell.CellState.Empty &&
                                field[x - 2, y].cellState == Cell.CellState.Empty &&
                                field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                                field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                field[x - 2, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 2, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 2, y + 1].cellState == Cell.CellState.Empty &&
                               field[x - 2, y + 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }

                            if (x == Math.Sqrt(field.Length) - 1 && y == Math.Sqrt(field.Length) - 1)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                               field[x, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 1, y].cellState == Cell.CellState.Empty &&
                               field[x - 2, y].cellState == Cell.CellState.Empty &&
                               field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                               field[x - 2, y - 1].cellState == Cell.CellState.Empty)
                                {
                                    return PlacementResult.Correct;
                                }
                            }
                            if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                            field[x - 2, y].cellState == Cell.CellState.Empty &&
                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 2, y - 1].cellState == Cell.CellState.Empty &&
                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x - 2, y + 1].cellState == Cell.CellState.Empty)
                            {
                                return PlacementResult.Correct;
                            }
                            return PlacementResult.Incorrect;
                    }
                }
                catch (IndexOutOfRangeException) { return PlacementResult.OutOfRange; }
                return PlacementResult.Incorrect;
            }
            else
            {
                return PlacementResult.Incorrect;
            }
        }
        public static PlacementResult OneDeckShipPlacementIsValid(Cell[,] field, int x, int y)
        {
            if (field[x, y].cellState == Cell.CellState.Empty)
            {
                try
                {
                    if (x == 0 && y > 1)
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty &&
                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                            field[x + 1, y - 1].cellState == Cell.CellState.Empty)
                        {
                            return PlacementResult.Correct;
                        }
                    }

                    if (x > 1 && y == 0)
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty &&
                        field[x, y + 1].cellState == Cell.CellState.Empty &&
                        field[x + 1, y].cellState == Cell.CellState.Empty &&
                        field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                        field[x - 1, y].cellState == Cell.CellState.Empty &&
                        field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                        {
                            return PlacementResult.Correct;
                        }
                    }

                    if (x == Math.Sqrt(field.Length) - 1 && y > 1)
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty &&
                        field[x, y + 1].cellState == Cell.CellState.Empty &&
                        field[x, y - 1].cellState == Cell.CellState.Empty &&
                        field[x - 1, y].cellState == Cell.CellState.Empty &&
                        field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                        field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                        {
                            return PlacementResult.Correct;
                        }
                    }

                    if (x == 0 && y == 0)
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty &&
                        field[x, y + 1].cellState == Cell.CellState.Empty &&
                        field[x + 1, y].cellState == Cell.CellState.Empty &&
                        field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                        {
                            return PlacementResult.Correct;
                        }
                    }

                    if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty &&
                        field[x, y + 1].cellState == Cell.CellState.Empty &&
                        field[x - 1, y].cellState == Cell.CellState.Empty &&
                        field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                        {
                            return PlacementResult.Correct;
                        }
                    }

                    if (field[x, y].cellState == Cell.CellState.Empty &&
                        field[x, y + 1].cellState == Cell.CellState.Empty &&
                        field[x, y - 1].cellState == Cell.CellState.Empty &&
                        field[x + 1, y].cellState == Cell.CellState.Empty &&
                        field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                        field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                        field[x - 1, y].cellState == Cell.CellState.Empty &&
                        field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                        field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                    {
                        return PlacementResult.Correct;
                    }
                    return PlacementResult.Incorrect;
                }
                catch (IndexOutOfRangeException) { return PlacementResult.OutOfRange; }
                return PlacementResult.Incorrect;
            }
            else
            {
                return PlacementResult.Incorrect;
            }
        }

    }
}
