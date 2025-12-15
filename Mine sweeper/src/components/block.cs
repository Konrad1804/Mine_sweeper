using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_sweeper.src.components
{
    internal class block
    {
        public int x;
        public int y;
        public bool isMine;
        public bool isRevealed;
        public int adjacentMines;
        public block(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.isMine = false;
            this.isRevealed = false;
            this.adjacentMines = 0;
        }

    }
}
