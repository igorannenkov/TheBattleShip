namespace TheBattleShip
{
    internal static class PlacementValidator
    {
        public enum Result
        {
            Correct,
            Incorrect,
            OutOfRange
        }

        //взять листочек. написать ф-цию определения возможности установки корабля (поле, х, у, ранг, направление)



        // public static Result FourDeckShipPlacementResult(Cell[,] field, int x, int y, ShipSpawner.Orientation direction)

        public static Result FourDeckShipPlacementResult(Cell[,] field, ShipPosition shipPosition)
        {

            int x = shipPosition.X;
            int y = shipPosition.Y;


            try
            {
                if (field[x, y].cellState == Cell.CellState.Empty)
                {

                    switch (shipPosition.orientation)
                    {
                        case ShipPosition.Orientation.Down: // размещаем вертикально вниз

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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }
                            return Result.Incorrect;

                        case ShipPosition.Orientation.Up: // вертикально вверх


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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }

                            return Result.Incorrect;
                        case ShipPosition.Orientation.Right: //горизонтально вправо
                            //1
                            if (x == 0 && y == 0)
                            {
                                if (field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //1.1
                            if (x == 0 && y == 0)
                            {
                                if (field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Incorrect; }
                            }


                            //2
                            if (x == 0 && y < 9)
                            {
                                if (field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                            }
                            //2.1
                            if (x == 0 && y < 9)
                            {
                                if (field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y + 1].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }

                            }

                            //3
                            if (x == 0 && y == 9)
                            {
                                if (field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                            }
                            //3.1
                            if (x == 0 && y == 9)
                            {
                                if (field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y - 1].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }

                            }

                            //4
                            if (x > 0 && x < 6 && y == 0)
                            {
                                if (field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }

                            //4.1
                            if (x > 0 && x < 6 && y == 0)
                            {
                                if (field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y + 1].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }

                            //5
                            if (x == 6 && y == 0)
                            {
                                if (field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }

                            //5.1
                            if (x == 6 && y == 0)
                            {
                                if (field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y + 1].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }

                            //6
                            if (x == 6 && y > 0 && y < 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //6.1
                            if (x == 6 && y > 0 && y < 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y + 1].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }

                            //7
                            if (x == 6 && y == 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //7.1
                            if (x == 6 && y == 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }

                            //8
                            if (x > 0 && x < 6 && y == 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //8.1
                            if (x > 0 && x < 6 && y == 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }

                            //9
                            if (x > 0 && x < 6 && y > 0 && y < 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }

                            //9.1
                            if (x > 0 && x < 6 && y > 0 && y < 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 3, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 4, y + 1].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }


                            if (x > 6 || y > 9)
                            {
                                return Result.OutOfRange;
                            }
                   
                            break;







                        case ShipPosition.Orientation.Left: //горизонтально влево

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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }
                            return Result.Incorrect;
                    }
                }
                else
                {
                    return Result.Incorrect;
                }
            }
            catch (IndexOutOfRangeException) { return Result.OutOfRange; }
            return Result.Incorrect;

        }

        public static Result ThreeDeckShipPlacementResult(Cell[,] field, ShipPosition shipPosition)
        {
            int x = shipPosition.X;
            int y = shipPosition.Y;
            try
            {
                if (field[x, y].cellState == Cell.CellState.Empty)
                {


                    switch (shipPosition.orientation)
                    {
                        case ShipPosition.Orientation.Down: // размещаем вертикально вниз

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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }
                            return Result.Incorrect;

                        case ShipPosition.Orientation.Up: // вертикально вверх


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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;

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
                                return Result.Correct;
                            }

                            return Result.Incorrect;
                        case ShipPosition.Orientation.Right: //горизонтально вправо

                            //1
                            if (x == 0 && y == 0)
                            {
                                if (field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //2
                            if (x == 0 && y < 9)
                            {
                                if (field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                            }
                            //3
                            if (x == 0 && y == 9)
                            {
                                if (field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                            }
                            //4
                            if (x > 0 && x < 6 && y == 0)
                            {
                                if (field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //5
                            if (x == 6 && y == 0)
                            {
                                if (field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //6
                            if (x == 6 && y > 0 && y < 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //7
                            if (x == 6 && y == 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                     field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //8
                            if (x > 0 && x < 6 && y == 9)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }
                            //9
                            if (x > 9 && x < 6 && y > 0 && y < 6)
                            {
                                if (field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }
                            }

                            break;


                        case ShipPosition.Orientation.Left: //горизонтально влево

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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }
                            return Result.Incorrect;


                    }
                }
                else
                {
                    return Result.Incorrect;
                }

            }
            catch (IndexOutOfRangeException) { return Result.OutOfRange; }
            return Result.Incorrect;

        }

        public static Result TwoDeckShipPlacementIsValid(Cell[,] field, ShipPosition shipPosition)
        {
            int x = shipPosition.X;
            int y = shipPosition.Y;

            try
            {
                if (field[x, y].cellState == Cell.CellState.Empty)
                {

                    switch (shipPosition.orientation)
                    {
                        case ShipPosition.Orientation.Down: // размещаем вертикально вниз

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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }
                            return Result.Incorrect;

                        case ShipPosition.Orientation.Up: // вертикально вверх


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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }

                            return Result.Incorrect;
                        case ShipPosition.Orientation.Right: //горизонтально вправо


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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }
                            return Result.Incorrect;
                        case ShipPosition.Orientation.Left: //горизонтально влево

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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                    return Result.Correct;
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
                                return Result.Correct;
                            }
                            return Result.Incorrect;
                    }
                }
                else
                {
                    return Result.Incorrect;
                }
            }
            catch (IndexOutOfRangeException) { return Result.OutOfRange; }
            return Result.Incorrect;

        }
        public static Result OneDeckShipPlacementIsValid(Cell[,] field, int x, int y)
        {
            try
            {
                if (field[x, y].cellState == Cell.CellState.Empty)
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
                            return Result.Correct;
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
                            return Result.Correct;
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
                            return Result.Correct;
                        }
                    }

                    if (x == 0 && y == 0)
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty &&
                        field[x, y + 1].cellState == Cell.CellState.Empty &&
                        field[x + 1, y].cellState == Cell.CellState.Empty &&
                        field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                        {
                            return Result.Correct;
                        }
                    }

                    if (x == Math.Sqrt(field.Length) - 1 && y == 0)
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty &&
                        field[x, y + 1].cellState == Cell.CellState.Empty &&
                        field[x - 1, y].cellState == Cell.CellState.Empty &&
                        field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                        {
                            return Result.Correct;
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
                        return Result.Correct;
                    }
                    // return Result.Incorrect;
                }
                else
                {
                    return Result.Incorrect;
                }
            }
            catch (IndexOutOfRangeException) { return Result.OutOfRange; }
            return Result.Incorrect;

        }

    }
}
