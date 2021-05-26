using System;
using System.Collections.Generic;
using System.Numerics;

namespace ElGamal
{
    public class KeyGenerator
    {
        public static Random random = new Random();

        public BigInteger GeneratePrimeNumber(int minNumber, BigInteger maxNumber) //генерация простого числа
        {
            BigInteger number;
            do
            {
                number = random.Next() % (maxNumber - minNumber) + minNumber;

            } while (!ArithmeticOperations.MillerRabinTest(number, 20));

            return number;
        }

        public int GenerateNumber(int minNumber, int maxNumber)
        {
            return random.Next(minNumber, maxNumber);
        }

        public List<BigInteger> GenerateRoots(BigInteger p)
        {
            var resList = new List<BigInteger>();
            List<BigInteger> fact = new List<BigInteger>();
            BigInteger phi = p - 1, n = phi;
            for (BigInteger i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    fact.Add(i);
                    while (n % i == 0)
                        n /= i;
                }

            if (n > 1)
                fact.Add(n);

            for (BigInteger res = 2; res < p; ++res)
            {
                bool ok = true;
                for (int i = 0; i < fact.Count && ok; ++i)
                {
                    ok &= ArithmeticOperations.PowMod(res, phi / fact[i], p, 1) != 1;
                }

                if (ok && res > 10000) resList.Add(res);
                if (resList.Count > 10000)
                {
                    return resList;
                }
            }

            return resList;
        }

        public BigInteger GenerateAntiderivativeRootModulo(int p) //генерация первообразного корня по модулю
        {
            List<BigInteger> numbersList = GenerateRoots(p);
            if (numbersList.Count == 0)
            {
                return -1;
            }
            return numbersList[random.Next(numbersList.Count)];
        }

        public int GenerateCoprimeNumber(int p) //генерация взаимно простого числа
        {
            bool isCoprimeNumber;
            int coprimeNumber;
            do
            {
                isCoprimeNumber = true;
                coprimeNumber = random.Next(2, p);
                for (int i = 2; i <= coprimeNumber; i++)
                {
                    if (coprimeNumber % i == 0 && p % i == 0)
                    {
                        isCoprimeNumber = false;
                    }
                }
            } while (!isCoprimeNumber);

            return coprimeNumber;
        }
    }
}