using CheckersLogic;

namespace Logic.BoardGameBuilder
{
    public abstract class BoardGameBuilder
    {
        public abstract void BuildBoard();

        public abstract void BuildPlayerOne();

        public abstract void BuildPlayerTwo();

        public abstract Board GetBoard();

        public abstract Player GetPlayerOne();

        public abstract Player GetPlayerTwo();

        public abstract GameEngine.eGameMode GetGameMode();
    }
}
