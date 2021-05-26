using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElGamal;
using Keys = ElGamal.Keys;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool CheckKeys() //проверка на правильность ввода
        {
            BigInteger p = Convert.ToInt32(numericP.Text);
            KeyGenerator keyGen = new KeyGenerator();
            bool isPrime = false;
            if (ArithmeticOperations.MillerRabinTest(p, 20))
            {
                isPrime = true;
            }

            if (!isPrime)
            {
                MessageBox.Show("Wrong p entered");
                return false;
            }
            List<BigInteger> allPosibleRoots = keyGen.GenerateRoots((int)p);
            allPosibleRoots.Sort();
            int g = Convert.ToInt32(numericG.Text);
            if (allPosibleRoots.BinarySearch(g) < 0 )
            {
                MessageBox.Show("Wrong g entered");
                return false;
            }

            int secretKey = Convert.ToInt32(numericSecureKey.Text);
            if (secretKey <= 1 || secretKey >= p - 1)
            {
                MessageBox.Show("Wrong secret key entered");
                return false;
            }
            
            if (Convert.ToInt32(numericY.Text) != ArithmeticOperations.PowMod(g, secretKey, p, 1))
            {
                MessageBox.Show("Wrong y entered");
                return false;
            }
            return true;
        }

        private void buttonCipher_Click(object sender, EventArgs e)
        {
            if (CheckKeys()) //если проверка прошла успешно, то происходит шифрация
            {
                string message = textInput.Text.Trim();
                Keys key = new Keys(Convert.ToInt32(numericP.Text), Convert.ToInt32(numericG.Text),
                    Convert.ToInt32(numericY.Text), Convert.ToInt32(numericSecureKey.Text));
                ElGamalOperation elGamal = new ElGamalOperation();
                string cipherMessage = elGamal.Cipher(message, key);
                textResult.Text = cipherMessage;
            }
        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
           int n;
           string[] arrCode = textInput.Text.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries); 
            foreach (var num in arrCode)
           {
               if (!int.TryParse(num, out n) || arrCode.Length % 2 == 1) //проверка на введённых данных
                {
                   MessageBox.Show("Wrong input data");
                   return;
               }
               if (n >= Convert.ToInt32(numericP.Text)) 
               { 
                   MessageBox.Show("Wrong input data");
                   return;
               }
           }
           if (CheckKeys()) //если проверка прошла успешно, то происходит дешифрация
            {
                string message = textInput.Text.Trim();
                Keys key = new Keys(Convert.ToInt32(numericP.Text), Convert.ToInt32(numericG.Text),
                    Convert.ToInt32(numericY.Text), Convert.ToInt32(numericSecureKey.Text));
                ElGamalOperation elGamal = new ElGamalOperation();
                string decipherMessage = elGamal.Decipher(message, key);
                textResult.Text = decipherMessage;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var keyGen = new KeyGenerator();
            BigInteger p = keyGen.GeneratePrimeNumber(1000, 100000);
            numericP.Text = p.ToString();
            BigInteger g = keyGen.GenerateAntiderivativeRootModulo((int)p);
            numericG.Text = g.ToString();
            int secretKey = keyGen.GenerateNumber(2, (int)p - 1);
            numericSecureKey.Text = secretKey.ToString();
            BigInteger y = ArithmeticOperations.PowMod( g, secretKey, p, 1);
            numericY.Text = y.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void numericG_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}