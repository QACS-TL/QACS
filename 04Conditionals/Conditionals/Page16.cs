using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class TernaryOperator
    {
        enum Coin
        {
            Heads,
            Tails,
            OnSide
        }

        public static void CoinToss()
        {
            //Less readable:
            int coinx = 0;
            string status;
            if (coinx == 0)
            {
                status = "won";
            }
            else
            {
                status = "lost";
            }
            Console.WriteLine($"You {status} the toss");


            var coin = Coin.OnSide;
            // IF statement syntax
            if (coin == Coin.Heads)
            {
                status = "won";
            }
            else
            {
                status = "lost";
            }
            Console.WriteLine($"You {status} the toss");
            // Ternary operator ? :
            //string status2 = (coin == Coin.Heads) ? "won" : (coin == Coin.Tails) ? "lost" : "Landed on side";
            string status2 = (coin == Coin.Heads) ? "won" : "lose";
            Console.WriteLine($"You {status2} the toss");
        }
    }
}
