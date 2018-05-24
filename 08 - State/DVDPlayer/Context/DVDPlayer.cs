using _08___State.DVDPlayer.ConcreteState;
using _08___State.DVDPlayer.State;

namespace _08___State.DVDPlayer.Context
{
    public class DVDPlayerContext
    {
        private DVDPlayerState _state;

        public DVDPlayerContext()
        {
            _state = new StandbyState();
        }

        public DVDPlayerContext(DVDPlayerState state)
        {
            _state = state;
        }

        public void PressPlayButton()
        {
            _state.PlayButtonPressed(this);
        }

        public void PressMenuButton()
        {
            _state.MenuButtonPressed(this);
        }

        public DVDPlayerState State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
