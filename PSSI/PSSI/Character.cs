using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSI
{
    public class Character
    {
        public bool usedBefore;

        public int score;

        public Character()
        {
            this.usedBefore = false;
            int score = 0;
        }
    }
}
