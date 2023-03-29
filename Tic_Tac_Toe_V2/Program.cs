namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var Player1 = new Player('X');
            var Player2 = new Player('O');
            var NewField = new Field(CreatNewPlayingField.Creat(), CreatNewPlayingField.RerurnFieldSize());
            PrintField.Print(NewField.PlayingFieldReturn());
            do
            {
                
                Message.PrintMove(Player1.NamePlayerReturn());
                do
                {
                    Player1.InputCoordinate(NewField.FildSizeReturn());
                }
                while (Game.IsCheckCellFree(NewField.PlayingFieldReturn(), Player1.VerticalReturn(), Player1.HorizontalReturn()) == false);
                NewField.PlayingFieldRecord(Game.SetCellValue(Player1.VerticalReturn(), Player1.HorizontalReturn(), NewField.PlayingFieldReturn(), Player1.NamePlayerReturn()));
                //Console.Clear();
                PrintField.Print(NewField.PlayingFieldReturn());
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player1.NamePlayerReturn()))
                {
                    Message.PrintWin(Player1.NamePlayerReturn());
                    break;
                }
                Message.PrintMove(Player2.NamePlayerReturn());
                do
                {
                    Player2.InputCoordinate(NewField.FildSizeReturn());
                }
                while (Game.IsCheckCellFree(NewField.PlayingFieldReturn(), Player2.VerticalReturn(), Player2.HorizontalReturn()) == false);
                NewField.PlayingFieldRecord(Game.SetCellValue(Player2.VerticalReturn(), Player2.HorizontalReturn(), NewField.PlayingFieldReturn(), Player2.NamePlayerReturn()));
                //Console.Clear();
                PrintField.Print(NewField.PlayingFieldReturn());
                Console.WriteLine();
                if (WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player2.NamePlayerReturn()))
                {
                    Message.PrintWin(Player2.NamePlayerReturn());
                    break;
                }
            } while (WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player1.NamePlayerReturn()) == false || WinCheck.IsWinCheck(NewField.PlayingFieldReturn(), Player2.NamePlayerReturn()) == false);
            Console.ReadLine();
        }
    }
}