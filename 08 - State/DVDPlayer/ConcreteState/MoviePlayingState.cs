using _08___State.DVDPlayer.Context;
using _08___State.DVDPlayer.State;
using System;

namespace _08___State.DVDPlayer.ConcreteState
{
    class MoviePlayingState : DVDPlayerState
    {
        public MoviePlayingState()
        {
            Console.WriteLine("MOVIE PLAYING");
        }

        public override void PlayButtonPressed(DVDPlayerContext player)
        {
            player.State = new MoviePausedState();
        }

        public override void MenuButtonPressed(DVDPlayerContext player)
        {
            player.State = new MenuState();
        }
    }
}
