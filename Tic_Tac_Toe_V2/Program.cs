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
            Player1.PlayerSymbol = 'X';
            Player2.PlayerSymbol = 'O';
            Field.FieldSize = CreateField.InputSize();
            Field.PlayingField = CreateField.CreatField(Field.FieldSize);
            PrintField.Print(Field.PlayingField);
            do
            {
                Console.WriteLine($"\nХодит {Player1}");
                do
                {
                    Player1.InputCoordinate(Field.FieldSize);
                }
                while (CheckIsCellFree.IsCheckCellFree(Field.PlayingField, Player1.Vertical, Player1.Horizontal) == false);
                Field.PlayingField = MovePlayer.Move(Player1.Vertical, Player1.Horizontal, Field.PlayingField, Player1.PlayerSymbol);
                Console.Clear();
                PrintField.Print(Field.PlayingField);
                Console.WriteLine();
                if (WinCheck.IsWinCheck(Field.PlayingField, Player1.PlayerSymbol))
                {
                    Message.Print(Player1.PlayerSymbol);
                    break;
                }
                Console.WriteLine($"\nХодит {Player2.PlayerSymbol}");
                do
                {
                    Player2.InputCoordinate(Field.FieldSize);
                }
                while (CheckIsCellFree.IsCheckCellFree(Field.PlayingField, Player2.Vertical, Player2.Horizontal) == false);
                Field.PlayingField = MovePlayer.Move(Player2.Vertical, Player2.Horizontal, Field.PlayingField, Player2.PlayerSymbol);
                Console.Clear();
                PrintField.Print(Field.PlayingField);
                Console.WriteLine();
                if (WinCheck.IsWinCheck(Field.PlayingField, Player2.PlayerSymbol))
                {
                    Message.Print(Player2.PlayerSymbol);
                    break;
                }
            } while (WinCheck.IsWinCheck(Field.PlayingField, Player1.PlayerSymbol) == false || WinCheck.IsWinCheck(Field.PlayingField, Player2.PlayerSymbol) == false);
            Console.ReadLine();
        }
    }
}