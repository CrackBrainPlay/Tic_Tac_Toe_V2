namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var Player1 = new Player();
            var Player2 = new Player();
            Player1.NamePlayer = 'X';
            Player2.NamePlayer = 'O';
            /*NewField.PlayingField = CreatNewPlayingField.Creat();
            NewField.FieldSize = NewField.PlayingField.GetLength(0);*/
            var NewField = new Field(CreatNewPlayingField.Creat(), CreatNewPlayingField.RerurnFieldSize());
            PrintField.Print(NewField.PlayingFieldReturn());
            do
            {
                
                Message.PrintMove(Player1.NamePlayer);
                do
                {
                    Player1.InputCoordinate(NewField.FildSizeReturn());
                }
                while (Game.IsCheckCellFree(NewField.PlayingFieldReturn(), Player1.Vertical, Player1.Horizontal) == false);
                NewField.PlayingFieldRecord( Game.SetCellValue(Player1.Vertical, Player1.Horizontal, NewField.PlayingFieldReturn(), Player1.NamePlayer));
                Console.Clear();
                PrintField.Print(NewField.PlayingFieldReturn());
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player1.NamePlayer))
                {
                    Message.PrintWin(Player1.NamePlayer);
                    break;
                }
                Message.PrintMove(Player2.NamePlayer);
                do
                {
                    Player2.InputCoordinate(NewField.FildSizeReturn());
                }
                while (Game.IsCheckCellFree(NewField.PlayingFieldReturn(), Player2.Vertical, Player2.Horizontal) == false);
                NewField.PlayingFieldRecord(Game.SetCellValue(Player2.Vertical, Player2.Horizontal, NewField.PlayingFieldReturn(), Player2.NamePlayer));
                Console.Clear();
                PrintField.Print(NewField.PlayingFieldReturn());
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player2.NamePlayer))
                {
                    Message.PrintWin(Player2.NamePlayer);
                    break;
                }
            } while (WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player1.NamePlayer) == false || WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player2.NamePlayer) == false);
            Console.ReadLine();
        }
    }
}