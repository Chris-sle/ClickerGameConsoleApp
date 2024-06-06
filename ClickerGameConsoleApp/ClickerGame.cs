namespace ClickerGameConsoleApp
{
    internal class ClickerGame
    {
        public string ClickerSymbol { get; private set; }
        public int Points { get; private set; }
        public int PointsPerClick { get; private set; }
        public int PointsPerClickIncrease { get; private set; }

        public ClickerGame(string clickerSymbol, int points, int pointsPerClick, int pointsPerClickIncrease)
        {
            ClickerSymbol = clickerSymbol;
            Points = points;
            PointsPerClick = pointsPerClick;
            PointsPerClickIncrease = pointsPerClickIncrease;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Points: {Points}");
        }

        public void Click()
        {
            Points += PointsPerClick;
        }

        public void Upgrade()
        {
            if (Points < 10) return;
            Points -= 10;
            PointsPerClick += PointsPerClickIncrease;
        }

        public void SuperUpgrade()
        {
            if (Points < 100) return;
            Points -= 100;
            PointsPerClickIncrease++;
        }
    }
}
