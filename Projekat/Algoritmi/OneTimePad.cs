using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Collections;

namespace Projekat.Algoritmi
{
    internal class OneTimePad
    {
        public Bitmap LoadedBitmap { get; private set; }

        public OneTimePad() { }

        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }


        public void Read(string fileName)
        {
            LoadedBitmap = (Bitmap)Image.FromFile(fileName);
        }

        public void Encrypt_bitmap()
        {
            ImageConverter converter = new ImageConverter();
            byte[] byteText = (byte[])converter.ConvertTo(LoadedBitmap, typeof(byte[]));
            var header = byteText.Take(54).ToArray();
            byteText = byteText.Skip(54).ToArray();


            byte[] key = Encoding.ASCII.GetBytes("data");

            byte[] rez = Crypt_b(byteText, key);

            byte[] prom = Combine(header, rez);

            File.WriteAllBytes(@"D:\Fakultet 18040\Zastita\Projekat\novaBMP.bmp", prom);



        }

        public void Decrypt_bitmap()
        {
            ImageConverter converter = new ImageConverter();
            byte[] byteText = (byte[])converter.ConvertTo(LoadedBitmap, typeof(byte[]));
            var header = byteText.Take(54).ToArray();
            byteText = byteText.Skip(54).ToArray();


            byte[] key = Encoding.ASCII.GetBytes("data");

            byte[] rez = Decrypt_b(byteText, key);

            byte[] prom = Combine(header, rez);

            File.WriteAllBytes(@"D:\Fakultet 18040\Zastita\Projekat\dekriptovano.bmp", prom);

        }


        public string Crypt(string data, string pad)
        {

            byte[] sourceData = Encoding.ASCII.GetBytes(data);
            byte[] paad = Encoding.ASCII.GetBytes(pad);
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(sourceData[i] ^ paad[0]);

            }
            string res;
            res = Encoding.ASCII.GetString(result);
            return res;
        }

        public byte[] Crypt_b(byte[] data, byte[] pad)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ pad[0]);

            }
            byte[] res = result.ToArray();
            return res;
        }


        public string Decrypt(string encrypted, string pad)
        {

            byte[] sourceData = Encoding.ASCII.GetBytes(encrypted);
            byte[] paad = Encoding.ASCII.GetBytes(pad);
            byte[] result = new byte[encrypted.Length];
            for (int i = 0; i < encrypted.Length; i++)
            {
                result[i] = (byte)(sourceData[i] ^ paad[0]);
            }

            string res;
            res = Encoding.ASCII.GetString(result);
            return res;
        }

        public byte[] Decrypt_b(byte[] encrypted, byte[] pad)
        {
            byte[] result = new byte[encrypted.Length];
            for (int i = 0; i < encrypted.Length; i++)
            {
                result[i] = (byte)(encrypted[i] ^ pad[0]);

            }
            byte[] res = result.ToArray();
            return res;
        }

        
    }
}

