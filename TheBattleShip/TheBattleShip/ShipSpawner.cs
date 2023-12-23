
namespace TheBattleShip
{
    internal class ShipSpawner
    {

        public static void SpawnFourDeckedShip(ref Cell[,] field, ShipPosition shipPosition)
        //public static void SpawnFourDeckedShip(ref Cell[,] field, int x, int y, Orientation rotation)
        {

            int x = shipPosition.X;
            int y = shipPosition.Y;


            switch (shipPosition.orientation)
            {
                case ShipPosition.Orientation.Down:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    field[x, y + 2].cellState = Cell.CellState.Undamaged;
                    field[x, y + 3].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Up:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y - 1].cellState = Cell.CellState.Undamaged;
                    field[x, y - 2].cellState = Cell.CellState.Undamaged;
                    field[x, y - 3].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Right:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    field[x + 2, y].cellState = Cell.CellState.Undamaged;
                    field[x + 3, y].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Left:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x - 1, y].cellState = Cell.CellState.Undamaged;
                    field[x - 2, y].cellState = Cell.CellState.Undamaged;
                    field[x - 3, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnThreeDeckedShip(ref Cell[,] field, ShipPosition shipPosition)
        {
            int x = shipPosition.X;
            int y = shipPosition.Y;

            switch (shipPosition.orientation)
            {
                case ShipPosition.Orientation.Down:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    field[x, y + 2].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Up:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y - 1].cellState = Cell.CellState.Undamaged;
                    field[x, y - 2].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Right:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    field[x + 2, y].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Left:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x - 1, y].cellState = Cell.CellState.Undamaged;
                    field[x - 2, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnTwoDeckedShip(ref Cell[,] field, ShipPosition shipPosition)
        {
            int x = shipPosition.X;
            int y = shipPosition.Y;

            switch (shipPosition.orientation)
            {
                case ShipPosition.Orientation.Down:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Up:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y - 1].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Right:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipPosition.Orientation.Left:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x - 1, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnOneDeckedShip(ref Cell[,] field, ShipPosition shipPosition)
        {
            int x = shipPosition.X;
            int y = shipPosition.Y;

            field[x, y].cellState = Cell.CellState.Undamaged;
        }
    }
}
