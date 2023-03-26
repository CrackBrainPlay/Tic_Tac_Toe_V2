namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var NewField = new Field();
            var CreateNewPlayeingField = new CreatNewPlayingField();
            var NewPlayingField = new PrintField();
            var Player1 = new Player();
            var Player2 = new Player();
            var NewMovePlayer = new MovePlayer();
            var IsWinCheck = new WinCheck();
            var CheckFree = new CheckIsCellFree();
            Player1.PlayerSymbol = 'X';
            Player2.PlayerSymbol = 'O';
            NewField.FieldSize = CreateNewPlayeingField.NewPlayingField();
            NewField.ValuesInPlayingField = CreateNewPlayeingField.CreatField(NewField.FieldSize);
            NewPlayingField.RenderField(NewField.ValuesInPlayingField);
            do
            {
                do
                {
                    Player1.Vertical = Player1.AssignmentVerticalCoordinate(NewField.FieldSize);
                    Player1.Horizontal = Player1.AssignmentHorizontalСoordinate(NewField.FieldSize);     
                }
                while (CheckFree.IsCheckCellFree(NewField.ValuesInPlayingField, Player1.Vertical, Player1.Horizontal) == false);
                NewField.ValuesInPlayingField = NewMovePlayer.Move(Player1.Vertical, Player1.Horizontal, NewField.ValuesInPlayingField, Player1.PlayerSymbol);
                Console.Clear();
                NewPlayingField.RenderField(NewField.ValuesInPlayingField);
                Console.WriteLine();
                if (IsWinCheck.IsWinCheck(NewField.ValuesInPlayingField, Player1.PlayerSymbol))
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Победил {Player1.PlayerSymbol} игрок!!!!");
                    break;
                }
                do
                {
                    Player2.Vertical = Player2.AssignmentVerticalCoordinate(NewField.FieldSize);
                    Player2.Horizontal = Player2.AssignmentHorizontalСoordinate(NewField.FieldSize);
                }
                while (CheckFree.IsCheckCellFree(NewField.ValuesInPlayingField, Player2.Vertical, Player2.Horizontal) == false);
                NewField.ValuesInPlayingField = NewMovePlayer.Move(Player2.Vertical, Player2.Horizontal, NewField.ValuesInPlayingField, Player2.PlayerSymbol);
                Console.Clear();
                NewPlayingField.RenderField(NewField.ValuesInPlayingField);
                Console.WriteLine();
                if (IsWinCheck.IsWinCheck(NewField.ValuesInPlayingField, Player2.PlayerSymbol))
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Победил {Player2.PlayerSymbol} игрок!!!!");
                    break;
                }

            } while (IsWinCheck.IsWinCheck(NewField.ValuesInPlayingField, Player1.PlayerSymbol) == false || IsWinCheck.IsWinCheck(NewField.ValuesInPlayingField, Player2.PlayerSymbol) == false);
            Console.ReadLine();
        }
    }
}