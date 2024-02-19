using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Algoritmi
{
    internal class XXTEA
    {



        public XXTEA() { }

        string key;

        private UInt32[] K = new UInt32[4];

        public string Key
        {
            get
            {
                return this.key;
            }
            set
            {
                this.key = value;
                string asciiKey = CharArrayToString(this.GetAsciiChars(this.key));

                int point = 0;
                for (int i = 0; i < K.Length; i++)
                {
                    uint output;
                    output = ((uint)asciiKey[point]);
                    output += ((uint)asciiKey[point + 1] << 8);
                    output += ((uint)asciiKey[point + 2] << 16);
                    output += ((uint)asciiKey[point + 3] << 24);
                    point += 4;
                    K[i] = output;
                }


            }
        }

        uint delta = 0x9e3779b9;

        public string Crypt(string input)
        {
            string cipherText = "";
            byte[] dataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(input);

            for (int j = 0; j < dataBytes.Length; j += 2)
            {
                uint L = dataBytes[j];

                uint R = dataBytes[j]; 

                UInt32 sum = 0;

                for (int i = 0; i < 32; i++)
                {
                    sum += delta;
                    L += (((R << 4) + K[0]) ^ (R + sum) ^ ((R >> 5) + K[1]));
                    R += (((L << 4) + K[2]) ^ (L + sum) ^ ((L >> 5) + K[3]));
                }

                cipherText += this.ConvertUIntToString(L) + this.ConvertUIntToString(R);
            }

            return cipherText;
        }


        public string Decrypt(string input)
        {
            byte[] dataBytes = new byte[input.Length / 8 * 2];
            int x = 0;
            for (int i = 0; i < input.Length; i += 8)
            {
                uint L = ConvertStringToUInt(input.Substring(i, 4));
                uint R = ConvertStringToUInt(input.Substring(i + 4, 4));

                UInt32 sum = delta << 5;

                for (int j = 0; j < 32; j++)
                {
                    R -= (((L << 4) + K[2]) ^ (L + sum) ^ ((L >> 5) + K[3]));
                    L -= (((R << 4) + K[0]) ^ (R + sum) ^ ((R >> 5) + K[1]));

                    sum -= delta;
                }

                dataBytes[x++] = (byte)L;
                dataBytes[x++] = (byte)R;
            }
            string decipheredString = System.Text.ASCIIEncoding.ASCII.GetString(dataBytes, 0, dataBytes.Length);
            if (decipheredString[decipheredString.Length - 1] == '\0')
                decipheredString = decipheredString.Substring(0, decipheredString.Length - 1);
            return decipheredString;

        }
        public byte[] Crypt_b(byte[] source)
        {
            byte[] cipherText = new byte[source.Length];
            byte[] dataBytes = source;

            for (int j = 0; j < dataBytes.Length; j += 2)
            {
                uint L = dataBytes[j];

                uint R = dataBytes[j]; ;

                UInt32 sum = 0;

                for (int i = 0; i < 32; i++)
                {
                    sum += delta;
                    L += (((R << 4) + K[0]) ^ (R + sum) ^ ((R >> 5) + K[1]));
                    R += (((L << 4) + K[2]) ^ (L + sum) ^ ((L >> 5) + K[3]));
                }


            }

            return cipherText;
        }

        public byte[] Decrypt_b(byte[][] input)
        {
            byte[] dataBytes = new byte[input.Length / 8 * 2];
            int x = 0;
            for (int i = 0; i < input.Length; i += 8)
            {
                uint L = input[i][4];
                uint R = input[i + 4][4];

                UInt32 sum = delta << 5;

                for (int j = 0; j < 32; j++)
                {
                    R -= (((L << 4) + K[2]) ^ (L + sum) ^ ((L >> 5) + K[3]));
                    L -= (((R << 4) + K[0]) ^ (R + sum) ^ ((R >> 5) + K[1]));

                    sum -= delta;
                }

                dataBytes[x++] = (byte)L;
                dataBytes[x++] = (byte)R;
            }
            byte[] decipheredString = dataBytes;
            //if (decipheredString[decipheredString.Length - 1] == '\0')
            //    decipheredString = decipheredString.Substring(0, decipheredString.Length - 1);
            return decipheredString;

        }

        public uint ConvertStringToUInt(string Input)
        {
            uint output;
            output = ((uint)Input[0]);
            output += ((uint)Input[1] << 8);
            output += ((uint)Input[2] << 16);
            output += ((uint)Input[3] << 24);
            return output;
        }

        public string ConvertUIntToString(uint Input)
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            output.Append((char)((Input & 0xFF)));
            output.Append((char)((Input >> 8) & 0xFF));
            output.Append((char)((Input >> 16) & 0xFF));
            output.Append((char)((Input >> 24) & 0xFF));
            return output.ToString();
        }


        char[] GetAsciiChars(string source)
        {
            Encoding ascii = Encoding.ASCII;
            Encoding enc_default = Encoding.Default;

            byte[] asciiBytes = Encoding.Convert(enc_default, ascii, enc_default.GetBytes(this.key));
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];

            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);

            return asciiChars;
        }

        string CharArrayToString(char[] start)
        {
            string ret = "";
            for (int i = 0; i < start.Length; i++)
            {
                ret += start[i];
            }

            return ret;
        }
    }
}
