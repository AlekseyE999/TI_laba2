using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ElGamal
{
    public class ElGamalOperation
    {
        public string Cipher(string plainText, Keys keys) //шифрация
        {
            KeyGenerator keyGen = new KeyGenerator();
            StringBuilder cipherMessage = new StringBuilder();
            for (int i = 0; i < plainText.Length; i++)
            {
                BigInteger seanceKey = keyGen.GenerateCoprimeNumber((int)keys.P - 1);
                BigInteger plainCode = plainText[i];
                BigInteger cipherCodeChar1 = ArithmeticOperations.PowMod(keys.G, seanceKey, keys.P, 1);
                BigInteger cipherCodeChar2 = ArithmeticOperations.PowMod(keys.Y, seanceKey, keys.P, plainCode);
                cipherMessage.Append(string.Concat(cipherCodeChar1.ToString(), " ", cipherCodeChar2.ToString(), " "));
            }

            return cipherMessage.ToString();
        }

        public string Decipher(string cipherText, Keys keys) //дешифрация
        {
            StringBuilder plainMessage = new StringBuilder();
            char[] sep = new [] {' '};
            string[] cipherWords = cipherText.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cipherWords.Length; i += 2)
            {
                BigInteger cipherCodeChar1 = Convert.ToInt32(cipherWords[i]) ;
                BigInteger cipherCodeChar2 = Convert.ToInt32(cipherWords[i + 1]);
                int plainCodeChar = (int)ArithmeticOperations.PowMod(cipherCodeChar1, keys.P - 1 - keys.SecretKey, keys.P, cipherCodeChar2);
                plainMessage.Append(Convert.ToChar(plainCodeChar));
            }
            return plainMessage.ToString();
        }
    }
    
}