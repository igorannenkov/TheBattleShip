namespace TheBattleShip
{
    internal static class ShipPlacementValidator
    {
        public enum Result
        {
            Correct,
            Incorrect,
            OutOfRange
        }


        public static Result Validate(Cell[,] field, ShipInfo ship)
        {
            int x = ship.PositionX;
            int y = ship.PositionY;

            switch (ship.shipRank)
            {
                case ShipInfo.ShipRank.FourDeck:
                    try
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty ||
                            field[x, y].cellState == Cell.CellState.Undamaged ||
                            field[x, y].cellState == Cell.CellState.Missed ||
                            field[x, y].cellState == Cell.CellState.Dead)
                        {
                            switch (ship.orientation)
                            {
                                case ShipInfo.Orientation.Horizontal: 
                                    //1
                                    if (x == 0 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
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

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
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
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
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

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty &&
                                            field[x + 4, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 4, y - 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
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
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
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

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
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
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
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
                                    //6
                                    if (x == 6 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
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

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
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
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 4, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
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

                                case ShipInfo.Orientation.Vertical:
                                    //1
                                    if (x == 0 & y == 0)
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
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //2
                                    if (x == 0 && y == 6)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //3
                                    if (x == 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y + 4].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 4].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 4].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }

                                    }
                                    //4
                                    if (x == 9 && y == 6)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //5
                                    if (x == 0 && y > 0 && y < 6)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y + 4].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //6
                                    if (x == 9 && y > 0 && y < 6)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y + 4].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 4].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 4].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //7
                                    if (x > 0 && x < 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y + 4].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 4].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //8
                                    if (x > 0 && x < 9 && y == 6)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //9
                                    if (x > 0 && x < 9 && y > 0 && y < 6)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y + 4].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 4].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    if (x > 9 || y > 6)
                                    {
                                        return Result.OutOfRange;
                                    }
                                    break;
                            }
                        }


                        else
                        {
                            return Result.Incorrect;
                        }
                    }
                    catch (IndexOutOfRangeException) { return Result.OutOfRange; }
                    return Result.Incorrect;

                case ShipInfo.ShipRank.ThreeDeck:
                    try
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty ||
                            field[x, y].cellState == Cell.CellState.Undamaged ||
                            field[x, y].cellState == Cell.CellState.Missed ||
                            field[x, y].cellState == Cell.CellState.Dead)
                        {
                            switch (ship.orientation)
                            {
                                case ShipInfo.Orientation.Horizontal: //горизонтально вправо
                                                                  //1
                                    if (x == 0 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 3, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //2
                                    if (x == 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 3, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 3, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //3
                                    if (x == 0 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y - 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 3, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 3, y - 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //4
                                    if (x > 0 && x < 7 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
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

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
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
                                    //5
                                    if (x == 7 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //6
                                    if (x == 7 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //7
                                    if (x == 7 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //8
                                    if (x > 0 && x < 7 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x + 3, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                    if (x > 0 && x < 7 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
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

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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

                                    if (x > 7 || y > 9)
                                    {
                                        return Result.OutOfRange;
                                    }
                                    break;

                                case ShipInfo.Orientation.Vertical:
                                    //1
                                    if (x == 0 & y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //2
                                    if (x == 0 && y == 7)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //3
                                    if (x == 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }

                                    }
                                    //4
                                    if (x == 9 && y == 7)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //5
                                    if (x == 0 && y > 0 && y < 7)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //6
                                    if (x == 9 && y > 0 && y < 7)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //7
                                    if (x > 0 && x < 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //8
                                    if (x > 0 && x < 9 && y == 7)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //9
                                    if (x > 0 && x < 9 && y > 0 && y < 7)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 3].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    if (x > 9 || y > 7)
                                    {
                                        return Result.OutOfRange;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            return Result.Incorrect;
                        }
                    }
                    catch (IndexOutOfRangeException) { return Result.OutOfRange; }
                    return Result.Incorrect;

                case ShipInfo.ShipRank.TwoDeck:
                    try
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty ||
                            field[x, y].cellState == Cell.CellState.Undamaged ||
                            field[x, y].cellState == Cell.CellState.Missed ||
                            field[x, y].cellState == Cell.CellState.Dead)
                        {
                            switch (ship.orientation)
                            {
                                case ShipInfo.Orientation.Horizontal: //горизонтально вправо
                                                                  //1
                                    if (x == 0 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //2
                                    if (x == 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //3
                                    if (x == 0 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y - 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }

                                    //4
                                    if (x > 0 && x < 8 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //5
                                    if (x == 8 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //6
                                    if (x == 8 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //7
                                    if (x == 8 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //8
                                    if (x > 0 && x < 8 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                             field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                             field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                             field[x + 2, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //9
                                    if (x > 0 && x < 8 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 2, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 2, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }

                                    if (x > 8 || y > 9)
                                    {
                                        return Result.OutOfRange;
                                    }
                                    break;

                                case ShipInfo.Orientation.Vertical:
                                    //1
                                    if (x == 0 & y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //2
                                    if (x == 0 && y == 8)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //3
                                    if (x == 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }

                                    }
                                    //4
                                    if (x == 9 && y == 8)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //5
                                    if (x == 0 && y > 0 && y < 8)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //6
                                    if (x == 9 && y > 0 && y < 8)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //7
                                    if (x > 0 && x < 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //8
                                    if (x > 0 && x < 9 && y == 8)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //9
                                    if (x > 0 && x < 9 && y > 0 && y < 8)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 2].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 2].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 2].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    if (x > 9 || y > 8)
                                    {
                                        return Result.OutOfRange;
                                    }
                                    break;
                            }
                        }


                        else
                        {
                            return Result.Incorrect;
                        }
                    }
                    catch (IndexOutOfRangeException) { return Result.OutOfRange; }
                    return Result.Incorrect;

                case ShipInfo.ShipRank.OneDeck:
                    try
                    {
                        if (field[x, y].cellState == Cell.CellState.Empty ||
                            field[x, y].cellState == Cell.CellState.Undamaged ||
                            field[x, y].cellState == Cell.CellState.Missed ||
                            field[x, y].cellState == Cell.CellState.Dead)
                        {
                            switch (ship.orientation)
                            {
                                case ShipInfo.Orientation.Horizontal: //горизонтально вправо
                                                                  //1
                                    if (x == 0 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //2
                                    if (x == 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //3
                                    if (x == 0 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }

                                    //4
                                    if (x > 0 && x < 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //5
                                    if (x == 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //6
                                    if (x == 9 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //7
                                    if (x == 9 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //8
                                    if (x > 0 && x < 9 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //9
                                    if (x > 0 && x < 9 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }

                                    if (x > 9 || y > 9)
                                    {
                                        return Result.OutOfRange;
                                    }
                                    break;

                                case ShipInfo.Orientation.Vertical:
                                    //1
                                    if (x == 0 & y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //2
                                    if (x == 0 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //3
                                    if (x == 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }

                                    }
                                    //4
                                    if (x == 9 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //5
                                    if (x == 0 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //6
                                    if (x == 9 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //7
                                    if (x > 0 && x < 9 && y == 0)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //8
                                    if (x > 0 && x < 9 && y == 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                            field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                            field[x + 1, y].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    //9
                                    if (x > 0 && x < 9 && y > 0 && y < 9)
                                    {
                                        if (field[x, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y].cellState == Cell.CellState.Empty &&
                                            field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x, y + 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y].cellState == Cell.CellState.Empty &&
                                            field[x + 1, y + 1].cellState == Cell.CellState.Empty)
                                        { return Result.Correct; }

                                        if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                           field[x + 1, y + 1].cellState == Cell.CellState.Undamaged)
                                        { return Result.Incorrect; }
                                    }
                                    if (x > 9 || y > 9)
                                    {
                                        return Result.OutOfRange;
                                    }
                                    break;
                            }
                        }


                        else
                        {
                            return Result.Incorrect;
                        }
                    }
                    catch (IndexOutOfRangeException) { return Result.OutOfRange; }
                    return Result.Incorrect;

                default: return Result.Incorrect;
            }
        }





        public static Result FourDeckShipPlacementResult(Cell[,] field, ShipInfo shipPosition)
        {
            int x = shipPosition.PositionX;
            int y = shipPosition.PositionY;

            try
            {
                if (field[x, y].cellState == Cell.CellState.Empty ||
                    field[x, y].cellState == Cell.CellState.Undamaged ||
                    field[x, y].cellState == Cell.CellState.Missed ||
                    field[x, y].cellState == Cell.CellState.Dead)
                {
                    switch (shipPosition.orientation)
                    {
                        case ShipInfo.Orientation.Horizontal: //горизонтально вправо
                            //1
                            if (x == 0 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
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

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
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
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
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

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 4, y - 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
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
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
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

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
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
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y + 1].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
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
                            //6
                            if (x == 6 && y > 0 && y < 9)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
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

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 2, y].cellState == Cell.CellState.Empty &&
                                    field[x + 3, y].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
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

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
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

                        case ShipInfo.Orientation.Vertical:
                            //1
                            if (x == 0 & y == 0)
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
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            //2
                            if (x == 0 && y == 6)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            //3
                            if (x == 9 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y + 4].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 4].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 4].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }

                            }
                            //4
                            if (x == 9 && y == 6)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 3].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 3].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            //5
                            if (x == 0 && y > 0 && y < 6)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                   field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            //6
                            if (x == 9 && y > 0 && y < 6)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 4].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                   field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 4].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            //7
                            if (x > 0 && x < 9 && y == 0)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 4].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            //8
                            if (x > 0 && x < 9 && y == 6)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 3].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                    field[x + 1, y + 3].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            //9
                            if (x > 0 && x < 9 && y > 0 && y < 6)
                            {
                                if (field[x, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x - 1, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x, y + 4].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y - 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 1].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 2].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 3].cellState == Cell.CellState.Empty &&
                                    field[x + 1, y + 4].cellState == Cell.CellState.Empty)
                                { return Result.Correct; }

                                if (field[x, y].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x - 1, y + 4].cellState == Cell.CellState.Undamaged ||
                                   field[x, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x, y + 4].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y - 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 1].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 2].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 3].cellState == Cell.CellState.Undamaged ||
                                   field[x + 1, y + 4].cellState == Cell.CellState.Undamaged)
                                { return Result.Incorrect; }
                            }
                            if (x > 9 || y > 6)
                            {
                                return Result.OutOfRange;
                            }

                            break;
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

        public static Result ThreeDeckShipPlacementResult(Cell[,] field, ShipInfo shipPosition)
        {
            int x = shipPosition.PositionX;
            int y = shipPosition.PositionY;
            try
            {
                if (field[x, y].cellState == Cell.CellState.Empty)
                {


                    switch (shipPosition.orientation)
                    {
                        case ShipInfo.Orientation.Vertical: // размещаем вертикально вниз

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


                        case ShipInfo.Orientation.Horizontal: //горизонтально вправо

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

        public static Result TwoDeckShipPlacementIsValid(Cell[,] field, ShipInfo shipPosition)
        {
            int x = shipPosition.PositionX;
            int y = shipPosition.PositionY;

            try
            {
                if (field[x, y].cellState == Cell.CellState.Empty)
                {

                    switch (shipPosition.orientation)
                    {
                        case ShipInfo.Orientation.Vertical: // размещаем вертикально вниз

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


                        case ShipInfo.Orientation.Horizontal: //горизонтально вправо


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
