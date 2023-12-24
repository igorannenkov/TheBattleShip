
namespace TheBattleShip
{
    internal class ShipSpawner
    {

        public static void SpawnFourDeckedShip(ref Cell[,] field, ShipInfo shipPosition)
        //public static void SpawnFourDeckedShip(ref Cell[,] field, int x, int y, Orientation rotation)
        {

            int x = shipPosition.PositionX;
            int y = shipPosition.PositionY;


            switch (shipPosition.orientation)
            {
                case ShipInfo.Orientation.Vertical:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    field[x, y + 2].cellState = Cell.CellState.Undamaged;
                    field[x, y + 3].cellState = Cell.CellState.Undamaged;
                    break;
                case ShipInfo.Orientation.Horizontal:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    field[x + 2, y].cellState = Cell.CellState.Undamaged;
                    field[x + 3, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnThreeDeckedShip(ref Cell[,] field, ShipInfo shipPosition)
        {
            int x = shipPosition.PositionX;
            int y = shipPosition.PositionY;

            switch (shipPosition.orientation)
            {
                case ShipInfo.Orientation.Vertical:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    field[x, y + 2].cellState = Cell.CellState.Undamaged;
                    break;

                case ShipInfo.Orientation.Horizontal:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    field[x + 2, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnTwoDeckedShip(ref Cell[,] field, ShipInfo shipPosition)
        {
            int x = shipPosition.PositionX;
            int y = shipPosition.PositionY;

            switch (shipPosition.orientation)
            {
                case ShipInfo.Orientation.Vertical:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x, y + 1].cellState = Cell.CellState.Undamaged;
                    break;

                case ShipInfo.Orientation.Horizontal:
                    field[x, y].cellState = Cell.CellState.Undamaged;
                    field[x + 1, y].cellState = Cell.CellState.Undamaged;
                    break;
            }
        }

        public static void SpawnOneDeckedShip(ref Cell[,] field, ShipInfo shipPosition)
        {
            int x = shipPosition.PositionX;
            int y = shipPosition.PositionY;

            field[x, y].cellState = Cell.CellState.Undamaged;
        }
    }
}
