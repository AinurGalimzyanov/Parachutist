using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseJumping.Parachutist
{
    class Parachutist
    {
        public int posX;
        public int posY;

        public int dirX;
        public int dirY;
        public bool isMoving;

        public int flip;

        public int landingFrames;
        public int flightFrames;

        public int size;

        public Image spriteSheet;
        
        public Parachutist(int posX, int posY, int idleFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {

        }
    }
}
