namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Player1 = new Player(PlayerSymbol.X);
            var Player2 = new Player(PlayerSymbol.O);
            var NewField = new Field(CreatField.SetValuesInPlayingField(), CreatField.GetFieldSize());
            PrintField.Print(NewField.PlayingField);
            do
            {
                //NewField.PlayingField = Player1.Move(NewField, NewField.FieldSize);
                Player1.Move(NewField);
                PrintField.Print(NewField.PlayingField);
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingField, Player1.Symbol))
                {
                    Message.PrintWin(Player1.Symbol);
                    break;
                }
                //NewField.PlayingField = Player2.Move(NewField.PlayingField, NewField.FieldSize);
                Player2.Move(NewField);
                PrintField.Print(NewField.PlayingField);
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingField, Player2.Symbol))
                {
                    Message.PrintWin(Player2.Symbol);
                    break;
                }
            } while (WinCheck.IsWinCheck(NewField.PlayingField, Player1.Symbol) == false || WinCheck.IsWinCheck(NewField.PlayingField, Player2.Symbol) == false);
            Console.ReadLine();
        }
    }
}