using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projekat.Algoritmi
{
    internal class FourSquareCipher
    {
        public FourSquareCipher() { }
        public FourSquareCipher(string key1, string key2)
        {
            this.key1 = key1;
            this.key2 = key2;
            abc = "abcdefghijklmnoprstuvwxyz";
        }
        public string Key1
        {
            get { return key1; }
            set { key1 = value; }
        }
        public string Key2
        {
            get { return key2; }
            set { key2 = value; }
        }
        private string key1, key2;
        private string topRight = "";
        private string bottomLeft = "";
        private string abc;
        public void MakeMatrix(string key1, string key2)
        {
            foreach (char c in key1)
            {
                if (!topRight.Contains(c))
                {
                    topRight += c;
                }
            }
            foreach (char c in key2)
            {
                if (!bottomLeft.Contains(c))
                {
                    bottomLeft += c;
                }
            }
            foreach (char c in this.abc)
            {
                if (!topRight.Contains(c))
                {
                    topRight += c;
                }
            }
            foreach (char c in this.abc)
            {
                if (!bottomLeft.Contains(c))
                {
                    bottomLeft += c;
                }
            }
            topRight = topRight.ToUpper();
            bottomLeft = bottomLeft.ToUpper();
        }

        public string Crypt(string data)
        {
            string otp = "";
            string inp = "";

            foreach (char c in data)
            {
                if (Char.IsLetter(c))
                    inp += c;
            }

            inp = data.ToLower();

            if (inp.Length % 2 != 0)
            {
                inp += 'x';
            }

            MakeMatrix(this.key1, this.key2);

            for (int i = 0; i < inp.Length; i += 2)
            {
                int first = abc.IndexOf(inp[i]);
                int second = abc.IndexOf(inp[i + 1]);

                int nT = first / 5;
                int nB = second / 5;
                int mT = first % 5;
                int mB = second % 5;

                otp += topRight[nT * 5 + mB];
                otp += bottomLeft[nB * 5 + mT];
            }

            return otp;

        }

        public string Decrypt(string data)
        {
            string otp = "";
            string inp = "";

            foreach (char c in data)
            {
                if (Char.IsLetter(c))
                    inp += c;
            }

            MakeMatrix(this.key1, this.key2);

            for (int i = 0; i < inp.Length; i += 2)
            {
                int first = topRight.IndexOf(inp[i]);
                int second = bottomLeft.IndexOf(inp[i + 1]);

                int nT = first / 5;
                int nB = second / 5;
                int mT = first % 5;
                int mB = second % 5;

                otp += abc[nT * 5 + mB];
                otp += abc[nB * 5 + mT];
            }
            otp = otp.ToUpper();
            return otp;

        }

    }
}
