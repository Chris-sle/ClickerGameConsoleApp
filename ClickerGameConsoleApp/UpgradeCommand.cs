﻿namespace ClickerGameConsoleApp
{
    internal class UpgradeCommand : ICommand
    {
        private ClickerGame _game;

        public UpgradeCommand(ClickerGame game)
        {
            _game = game;
        }
        public char Character { get; } = 'K';
        public void Run()
        {
            _game.Upgrade();
        }
    }
}
