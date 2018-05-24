using _08___State.DVDPlayer.Context;
using _08___State.DVDPlayer.State;
using System;

namespace _08___State.DVDPlayer.ConcreteState
{
    public class StandbyState : DVDPlayerState
    {
        public StandbyState()
        {
            Console.WriteLine("STANDBY");
        }

        public override void PlayButtonPressed(DVDPlayerContext player)
        {
            player.State = new MoviePlayingState();
        }

        public override void MenuButtonPressed(DVDPlayerContext player)
        {
            player.State = new MenuState();
        }
    }
}
