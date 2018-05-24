using _08___State.DVDPlayer.Context;
using _08___State.DVDPlayer.State;
using System;

namespace _08___State.DVDPlayer.ConcreteState
{
    public class MenuState : DVDPlayerState
    {
        public MenuState()
        {
            Console.WriteLine("MENU");
        }

        public override void PlayButtonPressed(DVDPlayerContext player)
        {
            Console.WriteLine("  Next Menu Item Selected");
        }

        public override void MenuButtonPressed(DVDPlayerContext player)
        {
            player.State = new StandbyState();
        }
    }
}
