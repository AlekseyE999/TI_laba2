using System.Numerics;

namespace ElGamal
{
    public class Keys
    {
        public Keys(BigInteger p, BigInteger g, BigInteger y, BigInteger securetKey)
        {
            this.P = p;
            this.G = g;
            this.Y = y;
            this.SecretKey = securetKey;
        }
        public BigInteger P { get; set; }
        public BigInteger G { get; set; }
        public BigInteger Y { get; set; }
        public BigInteger SecretKey { get; set; }

    }
}