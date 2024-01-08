using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGUIApp
{
    public class Flares
    {
        public void randomNumber()
        {
            int randomNum;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                randomNum = random.Next(1, 7);
            }
        }

        

    }
}
