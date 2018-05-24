using _08___State.DVDPlayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___State.DVDPlayer.State
{
    public abstract class DVDPlayerState
    {
        public abstract void PlayButtonPressed(DVDPlayerContext player);

        public abstract void MenuButtonPressed(DVDPlayerContext player);
    }
}
