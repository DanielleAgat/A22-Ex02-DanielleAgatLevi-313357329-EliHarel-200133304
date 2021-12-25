using CheckersLogic;

namespace Logic.BoardGameBuilder
{
    public interface IBoardGameBuilder
    {
        void BuildBoard();

        void BuildPlayerOne();

        void BuildPlayerTwo();

        Board GetBoard();

        Player GetPlayerOne();

        Player GetPlayerTwo();

        GameEngine.eGameMode GetGameMode();
    }
}
