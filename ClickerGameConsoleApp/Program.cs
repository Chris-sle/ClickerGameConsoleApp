namespace ClickerGameConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new ClickerGame(" ", 0, 1, 1);
            var commands = new Commands(game);
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Commands: \r\n - SPACE = Click (and get points)\r\n - K = Buy Upgrade\r\n" + 
                                  "Increases points pr click, costs 10 points\r\n - S = Buy Super Upgrade\r\n" +
                                  "Upgrade the upgrade Costs 100\r\n - X = Exit Program");
                game.ShowInfo();
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;
                commands.Run(command);
            }
        }
    }
}
