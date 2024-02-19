using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Projekat.Algoritmi;

namespace Projekat
{
    public partial class Form1 : Form
    {
        string pathtc = @"D:\Fakultet 18040\Zastita\Projekat\kriptovano.txt";
        string pathtd = @"D:\Fakultet 18040\Zastita\Projekat\dekriptovano.txt";
        string pathbc = @"D:\Fakultet 18040\Zastita\Projekat\kriptovano.bin";
        string pathbd = @"D:\Fakultet 18040\Zastita\Projekat\dekriptovano.bin";
        public Form1()
        {
            InitializeComponent();
            grbOTP.Hide();
            gbFSC.Hide();
            gbXXTea.Hide();

        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            grbOTP.Show();
            gbFSC.Hide();
            gbXXTea.Hide();
     
        }

        private void btnInpFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                tbInput.Text = path;
            }
        }

        private void btnKeyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                tbKey.Text = path;
            }
        }

        private void btnOutpFile_Click(object sender, EventArgs e)
        {
        }

        private void btnInputFSC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                tbInpF.Text = path;
            }
        }

        private void btnKey1FSC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                tbK1.Text = path;
            }
        }

        private void btnKey2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                tbK2.Text = path;
            }

        }

        private void btnOutputFSC_Click(object sender, EventArgs e)
        {
         
        }

        private void btnFSC_Click(object sender, EventArgs e)
        {
            grbOTP.Hide();
            gbFSC.Show();
            gbXXTea.Hide();
  
        }

        private void btnXxtea_Click(object sender, EventArgs e)
        {
            grbOTP.Hide();
            gbFSC.Hide();
            gbXXTea.Show();
       
        }

        private void btnKriptuj_Click(object sender, EventArgs e)
        {
            OneTimePad otp = new OneTimePad();
            if (tbInput.Text.EndsWith(".txt") && tbKey.Text.EndsWith(".txt"))
            {
                
                string input = File.ReadAllText(tbInput.Text);
                string key = File.ReadAllText(tbKey.Text);
                string result = otp.Crypt(input,key);

                
                FileStream fs = new FileStream(pathtc, FileMode.Create,FileAccess.ReadWrite);
                byte[] info = new UTF8Encoding(true).GetBytes(result);
                fs.Write(info, 0, info.Length);
                fs.Flush();
            }
            else if (tbInput.Text.EndsWith(".bin") && tbKey.Text.EndsWith(".bin"))
            {
                FileStream fs = new FileStream(tbInput.Text, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                FileStream fsk = new FileStream(tbKey.Text, FileMode.Open);
                BinaryReader brk = new BinaryReader(fsk);

                byte[] bin = br.ReadBytes(Convert.ToInt32(fs.Length));

                byte[] binkey = brk.ReadBytes(Convert.ToInt32(fsk.Length));

                byte[] res = otp.Crypt_b(bin, binkey);

                FileStream fs2 = new FileStream(pathbc, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs2);
                bw.Write(res);
                bw.Flush();
            }
        }

        private void btnDekriptuj_Click(object sender, EventArgs e)
        {
            OneTimePad otp = new OneTimePad();
            if (tbInput.Text.EndsWith(".txt")  && tbKey.Text.EndsWith(".txt"))
            {

                string input = File.ReadAllText(tbInput.Text);
                string key = File.ReadAllText(tbKey.Text);
                string result = otp.Decrypt(input, key);

                FileStream fs = new FileStream(pathtd, FileMode.Create, FileAccess.ReadWrite);
                byte[] info = new UTF8Encoding(true).GetBytes(result);
                fs.Write(info, 0, info.Length);
                fs.Flush();
            }
            else if (tbInput.Text.EndsWith(".bin") && tbKey.Text.EndsWith(".bin"))
            {

                FileStream fs = new FileStream(tbInput.Text, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                FileStream fsk = new FileStream(tbKey.Text, FileMode.Open);
                BinaryReader brk = new BinaryReader(fsk);

                byte[] bin = br.ReadBytes(Convert.ToInt32(fs.Length));

                byte[] binkey = brk.ReadBytes(Convert.ToInt32(fsk.Length));

                byte[] res = otp.Decrypt_b(bin, binkey);

                FileStream fs2 = new FileStream(pathbd, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs2);
                bw.Write(res);

                bw.Flush();
            }
        }

        private void btnCFSC_Click(object sender, EventArgs e)
        {
            
            if (tbInpF.Text.EndsWith(".txt") && tbK1.Text.EndsWith(".txt") && tbK2.Text.EndsWith(".txt"))
            {

                string input = File.ReadAllText(tbInpF.Text);
                string key1 = File.ReadAllText(tbK1.Text);
                string key2 = File.ReadAllText(tbK2.Text);
                FourSquareCipher fsc = new FourSquareCipher(key1,key2);
                string result = fsc.Crypt(input);

                FileStream fs = new FileStream(pathtc, FileMode.Create, FileAccess.ReadWrite);
                byte[] info = new UTF8Encoding(true).GetBytes(result);
                fs.Write(info, 0, info.Length);
                fs.Flush();
            }
        }

        private void btnDFSC_Click(object sender, EventArgs e)
        {

            if (tbInpF.Text.EndsWith(".txt")  && tbK1.Text.EndsWith(".txt") && tbK2.Text.EndsWith(".txt"))
            {

                string input = File.ReadAllText(tbInpF.Text);
                string key1 = File.ReadAllText(tbK1.Text);
                string key2 = File.ReadAllText(tbK2.Text);
                FourSquareCipher fsc = new FourSquareCipher(key1, key2);
                string result = fsc.Decrypt(input);
 
                FileStream fs = new FileStream(pathtd, FileMode.Create, FileAccess.ReadWrite);
                byte[] info = new UTF8Encoding(true).GetBytes(result);
                fs.Write(info, 0, info.Length);
                fs.Flush();
            }
        }

        private void btnCrypTea_Click(object sender, EventArgs e)
        {
            XXTEA xxtea = new XXTEA();
            if (tbInpTea.Text.EndsWith(".txt"))
            {

                string input = File.ReadAllText(tbInpTea.Text);
                string result = xxtea.Crypt(input);

                FileStream fs = new FileStream(pathtc, FileMode.Create);
                byte[] info = new UTF8Encoding(true).GetBytes(result);


                fs.Write(info, 0, info.Length);
                fs.Flush();
   
            }
            if (tbInpTea.Text.EndsWith(".bin"))
            {

                FileStream fs = new FileStream(tbInpTea.Text, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                byte[] bin = br.ReadBytes(Convert.ToInt32(fs.Length));

                byte[] res = xxtea.Crypt_b(bin);

                FileStream fs2 = new FileStream(pathbc, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs2);
                bw.Write(res);

                bw.Flush();

            }

        }

        private void btnDecrTea_Click(object sender, EventArgs e)
        {
            XXTEA xxtea = new XXTEA();
            if (tbInpTea.Text.EndsWith(".txt") )
            {

                string input = File.ReadAllText(tbInpTea.Text); 
                string result = xxtea.Decrypt(input);

                FileStream fs = new FileStream(pathtd, FileMode.Create);
                byte[] info = new UTF8Encoding(true).GetBytes(result);


                fs.Write(info, 0, info.Length);
                fs.Flush();

            }
           

        }

        private void btnInpuTea_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                tbInpTea.Text = path;
            }
        }

      

        private void btnOutpTea_Click(object sender, EventArgs e)
        {
          
        }


        private void button5_Click(object sender, EventArgs e)
        {
            OneTimePad otp = new OneTimePad();

            otp.Read(@"D:\Fakultet 18040\Zastita\Projekat\parrots.bmp");

            otp.Encrypt_bitmap();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OneTimePad otp = new OneTimePad();

            otp.Read(@"D:\Fakultet 18040\Zastita\Projekat\novaBMP.bmp");

            otp.Decrypt_bitmap();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
