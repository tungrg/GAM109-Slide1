using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide1
{
    internal class Player
    {
        public int health;
        public static int score;
        public Player()
        {
            this.health = 5;
        }
        static Player()
        {
            score = 0;
        }
        public void GiamMau()
        {
            health--;
        }
        public static void TangDiem()
        {
            score++;
        }
    }
}
