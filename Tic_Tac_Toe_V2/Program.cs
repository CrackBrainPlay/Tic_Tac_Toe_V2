namespace Tic_Tac_Toe_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Player1 = new Player(PlayerSymbol.X);
            var Player2 = new Player(PlayerSymbol.O);
            var Board = BoardCreator.Create();
            Renderer.RenderBoard(Board);
            while (Game.MakeStep(Board, Player1) == false || Game.MakeStep(Board, Player2) == false)
            {
                if (Game.MakeStep(Board, Player1))
                    break;
                if (Game.MakeStep(Board, Player2))
                    break;
            }
            Console.ReadLine();
        }
    }
}