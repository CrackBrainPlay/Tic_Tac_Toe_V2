namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Player1 = new Player(PlayerSymbol.X);
            var Player2 = new Player(PlayerSymbol.O);
            var NewField = new Field(CreatField.SetValuesInPlayingField(), CreatField.GetFieldSize());
            PrintField.Print(NewField);
            do
            {
                Player1.Move(NewField);
                PrintField.Print(NewField);
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingField, Player1.Symbol))
                {
                    Message.PrintWin(Player1.Symbol);
                    break;
                }
                Player2.Move(NewField);
                PrintField.Print(NewField);
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