using System;
using System.Numerics;
using System.Text;

namespace ElGamal
{
    class Program
    {
        static void Main()
        {
            //////////////////////////////////////////// Генерация ключа
            /*var keyGen = new KeyGenerator();
            BigInteger p = keyGen.GeneratePrimeNumber(200, 100000);
            int g = keyGen.GenerateAntiderivativeRootModulo(p);
            int secretKey = keyGen.GenerateNumber(2, p - 1);
            var operation = new ArithmeticOperations();
            int y = operation.PowMod( g, secretKey, p, 1);
            var keys = new Keys(p, g, y, secretKey);
            ////////////////////////////////////////////
            Console.Write("input message to cipher: ");
            string message = Console.ReadLine();
            message = message.Replace(" ", "");
            ElGamalOperation elGamal = new ElGamalOperation();
            string cipherMessage = elGamal.Cipher(message, keys);
            Console.WriteLine("Cipher message: {0}", cipherMessage);
            /////////////////////////////////////////////
            string decipherMessage = elGamal.Decipher(cipherMessage, keys);
            Console.WriteLine("Decipher message: {0}", decipherMessage);*/
            /////////////////////////////////////////////
        }
    }
}