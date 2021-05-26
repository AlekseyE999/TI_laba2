using System;
using System.Numerics;
using System.Security.Cryptography;

namespace ElGamal
{
    static public class ArithmeticOperations
    {

        static public BigInteger PowMod(BigInteger a, BigInteger b, BigInteger p, BigInteger m) //алгоритм бинарного возведения в степень по модулю
        {
            BigInteger res = m;
            BigInteger num = a;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    res = res * num % p;
                    b--;
                }
                else
                {
                    num = num * num % p;
                    b >>= 1;
                }
            }
            return res;
        }

        static public bool MillerRabinTest(BigInteger n, int k) //тест Миллера-Рабина
        {
            if (n == 2 || n == 3)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            BigInteger t = n - 1;
            int s = 0;
            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }

            for (int i = 0; i < k; i++)
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] bytesArr = new byte[n.ToByteArray().LongLength];
                BigInteger a;
                do
                {
                    rng.GetBytes(bytesArr);
                    a = new BigInteger(bytesArr);
                }
                while (a < 2 || a >= n - 2);
                BigInteger x = PowMod(a, t, n, 1);
                if (x == 1 || x == n - 1) continue;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1) return false;
                    if (x == n - 1) break;
                }
                if (x != n - 1) return false;
            }
            return true;
        }
    }

}
