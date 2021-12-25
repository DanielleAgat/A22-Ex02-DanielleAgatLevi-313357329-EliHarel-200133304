using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.BoardGameBuilder
{
    public class BoardGameComposer
    {
        public static void Compose(IBoardGameBuilder io_BoardGameBuilder)
        {
            io_BoardGameBuilder.BuildBoard();
            io_BoardGameBuilder.BuildPlayerOne();
            io_BoardGameBuilder.BuildPlayerTwo();
        }
    }
}
