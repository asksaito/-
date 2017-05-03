using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsPrime(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    // 素数ではない
                    return false;
                }
            }

            // 素数である
            return true;
        }

        public static bool IsPrime2(int num)
        {
            if (num < 2) return false;
            else if (num == 2) return true;
            else if (num % 2 == 0) return false; // 偶数はあらかじめ除く

            for (int i = 3; i < num; i += 2)
            {
                if (num % i == 0)
                {
                    // 素数ではない
                    return false;
                }
            }

            // 素数である
            return true;
        }

        public static bool IsPrime3(int num)
        {
            if (num < 2) return false;
            else if (num == 2) return true;
            else if (num % 2 == 0) return false; // 偶数はあらかじめ除く

            double sqrtNum = Math.Sqrt(num);
            for (int i = 3; i <= sqrtNum; i += 2)
            {
                if (num % i == 0)
                {
                    // 素数ではない
                    return false;
                }
            }

            // 素数である
            return true;
        }
    }
}
