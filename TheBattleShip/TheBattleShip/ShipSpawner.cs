
namespace TheBattleShip
{
    internal class ShipSpawner
    {
        public enum SpawnDirection
        {
            Up,
            Down,
            Left,
            Right
        }

        public static void SpawnFourDeckedShip(ref Cell[,] field, int x, int y, SpawnDirection direction)
        {
            switch (direction)
            {
                case SpawnDirection.Down:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    field[x, y + 2].cellState = Cell.CellState.Undamaged;
                    field[x, y + 3].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Up:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y - 1].cellState = Cell.CellState.Undamaged;
                    field[x, y - 2].cellState = Cell.CellState.Undamaged;
                    field[x, y - 3].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Right:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    field[x + 2, y].cellState = Cell.CellState.Undamaged;
                    field[x + 3, y].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Left:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x - 1, y].cellState = Cell.CellState.Undamaged;
                    field[x - 2, y].cellState = Cell.CellState.Undamaged;
                    field[x - 3, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnThreeDeckedShip(ref Cell[,] field, int x, int y, SpawnDirection direction)
        {
            switch (direction)
            {
                case SpawnDirection.Down:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    field[x, y + 2].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Up:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y - 1].cellState = Cell.CellState.Undamaged;
                    field[x, y - 2].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Right:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    field[x + 2, y].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Left:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x - 1, y].cellState = Cell.CellState.Undamaged;
                    field[x - 2, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnTwoDeckedShip(ref Cell[,] field, int x, int y, SpawnDirection direction)
        {
            switch (direction)
            {
                case SpawnDirection.Down:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Up:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y - 1].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Right:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    break;
                case SpawnDirection.Left:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x - 1, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnOneDeckedShip(ref Cell[,] field, int x, int y)
        {
            field[x, y].cellState = Cell.CellState.Undamaged;
        }
    }
}
