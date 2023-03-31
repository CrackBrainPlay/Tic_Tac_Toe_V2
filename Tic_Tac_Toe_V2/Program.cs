namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Player1 = new Player('X');
            var Player2 = new Player('O');
            var NewField = new Field(CreatNewPlayingField.SetValuesInPlayingField(), CreatNewPlayingField.GetFieldSize());
            PrintField.Print(NewField.PlayingField);
            do
            {
                Message.PrintMove(Player1.NamePlayer);
                do
                {
                    Player1.InputCoordinate(NewField.FieldSize);
                }
                while (Game.IsCheckCellFree(NewField.PlayingField, Player1.Vertical, Player1.Horizontal) == false);
                NewField.PlayingField = (Game.SetCellValue(Player1.Vertical, Player1.Horizontal, NewField.PlayingField, Player1.NamePlayer));
                PrintField.Print(NewField.PlayingField);
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingField, Player1.NamePlayer))
                {
                    Message.PrintWin(Player1.NamePlayer);
                    break;
                }
                Message.PrintMove(Player2.NamePlayer);
                do
                {
                    Player2.InputCoordinate(NewField.FieldSize);
                }
                while (Game.IsCheckCellFree(NewField.PlayingField, Player2.Vertical, Player2.Horizontal) == false);
                NewField.PlayingField = (Game.SetCellValue(Player2.Vertical, Player2.Horizontal, NewField.PlayingField, Player2.NamePlayer));
                PrintField.Print(NewField.PlayingField);
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingField, Player2.NamePlayer))
                {
                    Message.PrintWin(Player2.NamePlayer);
                    break;
                }
            } while (WinCheck.IsWinCheck(NewField.PlayingField, Player1.NamePlayer) == false || WinCheck.IsWinCheck(NewField.PlayingField, Player2.NamePlayer) == false);
            Console.ReadLine();
        }
    }
}