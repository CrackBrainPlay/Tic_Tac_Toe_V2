namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Field = new Field();
            var CreateField = new CreatNewPlayingField();
            var Player1 = new Player();
            var Player2 = new Player();
            //var IsWinCheck = new WinCheck();
            Player1.PlayerSymbol = 'X';
            Player2.PlayerSymbol = 'O';
            Field.FieldSize = CreateField.InputSize();
            Field.PlayingField = CreateField.CreatField(Field.FieldSize);
            PrintField.Print(Field.PlayingField);
            do
            {
                do
                {
                    Player1.InputCoordinate(Field.FieldSize);
                }
                while (CheckIsCellFree.IsCheckCellFree(Field.PlayingField, Player1.Vertical, Player1.Horizontal) == false);
                Field.PlayingField = MovePlayer.Move(Player1.Vertical, Player1.Horizontal, Field.PlayingField, Player1.PlayerSymbol);
                Console.Clear();
                PrintField.Print(Field.PlayingField);
                Console.WriteLine();
                //if (IsWinCheck.IsWinCheck(Field.PlayingField, Player1.PlayerSymbol))
                if (WinCheck.IsWinCheck(Field.PlayingField, Player1.PlayerSymbol))
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Победил {Player1.PlayerSymbol} игрок!!!!");
                    break;
                }
                do
                {
                    Player2.InputCoordinate(Field.FieldSize);
                }
                while (CheckIsCellFree.IsCheckCellFree(Field.PlayingField, Player2.Vertical, Player2.Horizontal) == false);
                Field.PlayingField = MovePlayer.Move(Player2.Vertical, Player2.Horizontal, Field.PlayingField, Player2.PlayerSymbol);
                Console.Clear();
                PrintField.Print(Field.PlayingField);
                Console.WriteLine();
                //if (IsWinCheck.IsWinCheck(Field.PlayingField, Player2.PlayerSymbol))
                if (WinCheck.IsWinCheck(Field.PlayingField, Player2.PlayerSymbol))
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Победил {Player2.PlayerSymbol} игрок!!!!");
                    break;
                }

                //} while (IsWinCheck.IsWinCheck(Field.PlayingField, Player1.PlayerSymbol) == false || IsWinCheck.IsWinCheck(Field.PlayingField, Player2.PlayerSymbol) == false);
            } while (WinCheck.IsWinCheck(Field.PlayingField, Player1.PlayerSymbol) == false || WinCheck.IsWinCheck(Field.PlayingField, Player2.PlayerSymbol) == false);
            Console.ReadLine();
        }
    }
}