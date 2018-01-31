using System;
using System.Security.Cryptography;

namespace DMBattleOverview
{
    class CryptoRandom
    {
        private RNGCryptoServiceProvider rng;

        public CryptoRandom()
        {
            rng = new RNGCryptoServiceProvider();
        }

        public uint Next()
        {
            byte[] buffer = new byte[sizeof(uint)];
            rng.GetBytes(buffer);
            return BitConverter.ToUInt32(buffer, 0);
        }

        public uint Next(uint lowest, uint highest)
        {
            uint num = Next();
            
            if(num > highest)
            {
                num = num % (highest + 1);
            }

            if (num < lowest)
            {
                num += lowest;
            }

            return num;
        }
    }
}
