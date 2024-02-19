namespace Projekat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbFSC = new System.Windows.Forms.GroupBox();
            this.btnKey2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbK2 = new System.Windows.Forms.TextBox();
            this.btnDFSC = new System.Windows.Forms.Button();
            this.btnCFSC = new System.Windows.Forms.Button();
            this.btnKey1FSC = new System.Windows.Forms.Button();
            this.btnInputFSC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbK1 = new System.Windows.Forms.TextBox();
            this.tbInpF = new System.Windows.Forms.TextBox();
            this.btnFSC = new System.Windows.Forms.Button();
            this.grbOTP = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnKeyFile = new System.Windows.Forms.Button();
            this.btnInpFile = new System.Windows.Forms.Button();
            this.btnDekriptuj = new System.Windows.Forms.Button();
            this.btnKriptuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnOTP = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnXxtea = new System.Windows.Forms.Button();
            this.gbXXTea = new System.Windows.Forms.GroupBox();
            this.btnInpuTea = new System.Windows.Forms.Button();
            this.btnDecrTea = new System.Windows.Forms.Button();
            this.btnCrypTea = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbInpTea = new System.Windows.Forms.TextBox();
            this.gbFSC.SuspendLayout();
            this.grbOTP.SuspendLayout();
            this.gbXXTea.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFSC
            // 
            this.gbFSC.Controls.Add(this.btnKey2);
            this.gbFSC.Controls.Add(this.label7);
            this.gbFSC.Controls.Add(this.tbK2);
            this.gbFSC.Controls.Add(this.btnDFSC);
            this.gbFSC.Controls.Add(this.btnCFSC);
            this.gbFSC.Controls.Add(this.btnKey1FSC);
            this.gbFSC.Controls.Add(this.btnInputFSC);
            this.gbFSC.Controls.Add(this.label5);
            this.gbFSC.Controls.Add(this.label6);
            this.gbFSC.Controls.Add(this.tbK1);
            this.gbFSC.Controls.Add(this.tbInpF);
            this.gbFSC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFSC.Location = new System.Drawing.Point(223, 44);
            this.gbFSC.Name = "gbFSC";
            this.gbFSC.Size = new System.Drawing.Size(715, 355);
            this.gbFSC.TabIndex = 16;
            this.gbFSC.TabStop = false;
            this.gbFSC.Text = "Foursquare Chiper";
            // 
            // btnKey2
            // 
            this.btnKey2.BackColor = System.Drawing.Color.Ivory;
            this.btnKey2.Font = new System.Drawing.Font("Arial", 9F);
            this.btnKey2.Location = new System.Drawing.Point(431, 228);
            this.btnKey2.Name = "btnKey2";
            this.btnKey2.Size = new System.Drawing.Size(249, 33);
            this.btnKey2.TabIndex = 13;
            this.btnKey2.Text = "Izaberite fajl sa kljucem 2";
            this.btnKey2.UseVisualStyleBackColor = false;
            this.btnKey2.Click += new System.EventHandler(this.btnKey2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(353, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kljuc 2";
            // 
            // tbK2
            // 
            this.tbK2.Location = new System.Drawing.Point(184, 199);
            this.tbK2.Name = "tbK2";
            this.tbK2.Size = new System.Drawing.Size(496, 25);
            this.tbK2.TabIndex = 11;
            // 
            // btnDFSC
            // 
            this.btnDFSC.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDFSC.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDFSC.Location = new System.Drawing.Point(25, 132);
            this.btnDFSC.Name = "btnDFSC";
            this.btnDFSC.Size = new System.Drawing.Size(109, 47);
            this.btnDFSC.TabIndex = 7;
            this.btnDFSC.Text = "Dekriptuj";
            this.btnDFSC.UseVisualStyleBackColor = false;
            this.btnDFSC.Click += new System.EventHandler(this.btnDFSC_Click);
            // 
            // btnCFSC
            // 
            this.btnCFSC.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCFSC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFSC.Location = new System.Drawing.Point(24, 68);
            this.btnCFSC.Name = "btnCFSC";
            this.btnCFSC.Size = new System.Drawing.Size(110, 46);
            this.btnCFSC.TabIndex = 6;
            this.btnCFSC.Text = "Kriptuj";
            this.btnCFSC.UseVisualStyleBackColor = false;
            this.btnCFSC.Click += new System.EventHandler(this.btnCFSC_Click);
            // 
            // btnKey1FSC
            // 
            this.btnKey1FSC.BackColor = System.Drawing.Color.Ivory;
            this.btnKey1FSC.Font = new System.Drawing.Font("Arial", 9F);
            this.btnKey1FSC.Location = new System.Drawing.Point(431, 151);
            this.btnKey1FSC.Name = "btnKey1FSC";
            this.btnKey1FSC.Size = new System.Drawing.Size(249, 31);
            this.btnKey1FSC.TabIndex = 9;
            this.btnKey1FSC.Text = "Izaberite fajl sa kljucem 1";
            this.btnKey1FSC.UseVisualStyleBackColor = false;
            this.btnKey1FSC.Click += new System.EventHandler(this.btnKey1FSC_Click);
            // 
            // btnInputFSC
            // 
            this.btnInputFSC.BackColor = System.Drawing.Color.Ivory;
            this.btnInputFSC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputFSC.Location = new System.Drawing.Point(431, 77);
            this.btnInputFSC.Name = "btnInputFSC";
            this.btnInputFSC.Size = new System.Drawing.Size(249, 25);
            this.btnInputFSC.TabIndex = 8;
            this.btnInputFSC.Text = "Izaberite ulazni fajl";
            this.btnInputFSC.UseVisualStyleBackColor = false;
            this.btnInputFSC.Click += new System.EventHandler(this.btnInputFSC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(353, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kljuc 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(353, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ulaz";
            // 
            // tbK1
            // 
            this.tbK1.Location = new System.Drawing.Point(184, 120);
            this.tbK1.Name = "tbK1";
            this.tbK1.Size = new System.Drawing.Size(496, 25);
            this.tbK1.TabIndex = 1;
            // 
            // tbInpF
            // 
            this.tbInpF.Location = new System.Drawing.Point(184, 49);
            this.tbInpF.Name = "tbInpF";
            this.tbInpF.Size = new System.Drawing.Size(496, 25);
            this.tbInpF.TabIndex = 0;
            // 
            // btnFSC
            // 
            this.btnFSC.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFSC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFSC.Location = new System.Drawing.Point(62, 105);
            this.btnFSC.Name = "btnFSC";
            this.btnFSC.Size = new System.Drawing.Size(119, 53);
            this.btnFSC.TabIndex = 17;
            this.btnFSC.Text = "Foursquare cipher ";
            this.btnFSC.UseVisualStyleBackColor = false;
            this.btnFSC.Click += new System.EventHandler(this.btnFSC_Click);
            // 
            // grbOTP
            // 
            this.grbOTP.Controls.Add(this.button6);
            this.grbOTP.Controls.Add(this.button5);
            this.grbOTP.Controls.Add(this.btnKeyFile);
            this.grbOTP.Controls.Add(this.btnInpFile);
            this.grbOTP.Controls.Add(this.btnDekriptuj);
            this.grbOTP.Controls.Add(this.btnKriptuj);
            this.grbOTP.Controls.Add(this.label2);
            this.grbOTP.Controls.Add(this.label1);
            this.grbOTP.Controls.Add(this.tbKey);
            this.grbOTP.Controls.Add(this.tbInput);
            this.grbOTP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOTP.Location = new System.Drawing.Point(223, 54);
            this.grbOTP.Name = "grbOTP";
            this.grbOTP.Size = new System.Drawing.Size(715, 307);
            this.grbOTP.TabIndex = 15;
            this.grbOTP.TabStop = false;
            this.grbOTP.Text = "One-Time Pad";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GreenYellow;
            this.button6.Font = new System.Drawing.Font("Arial", 9F);
            this.button6.Location = new System.Drawing.Point(248, 238);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(183, 49);
            this.button6.TabIndex = 21;
            this.button6.Text = "Dekriptuj sliku";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.GreenYellow;
            this.button5.Font = new System.Drawing.Font("Arial", 9F);
            this.button5.Location = new System.Drawing.Point(24, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 49);
            this.button5.TabIndex = 20;
            this.button5.Text = "Kriptuj sliku ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnKeyFile
            // 
            this.btnKeyFile.BackColor = System.Drawing.Color.Ivory;
            this.btnKeyFile.Font = new System.Drawing.Font("Arial", 9F);
            this.btnKeyFile.Location = new System.Drawing.Point(440, 154);
            this.btnKeyFile.Name = "btnKeyFile";
            this.btnKeyFile.Size = new System.Drawing.Size(240, 27);
            this.btnKeyFile.TabIndex = 9;
            this.btnKeyFile.Text = "Izaberite fajl sa kljucem";
            this.btnKeyFile.UseVisualStyleBackColor = false;
            this.btnKeyFile.Click += new System.EventHandler(this.btnKeyFile_Click);
            // 
            // btnInpFile
            // 
            this.btnInpFile.BackColor = System.Drawing.Color.Ivory;
            this.btnInpFile.Font = new System.Drawing.Font("Arial", 9F);
            this.btnInpFile.Location = new System.Drawing.Point(440, 82);
            this.btnInpFile.Name = "btnInpFile";
            this.btnInpFile.Size = new System.Drawing.Size(240, 26);
            this.btnInpFile.TabIndex = 8;
            this.btnInpFile.Text = "Izaberite ulazni fajl";
            this.btnInpFile.UseVisualStyleBackColor = false;
            this.btnInpFile.Click += new System.EventHandler(this.btnInpFile_Click);
            // 
            // btnDekriptuj
            // 
            this.btnDekriptuj.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDekriptuj.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDekriptuj.Location = new System.Drawing.Point(25, 132);
            this.btnDekriptuj.Name = "btnDekriptuj";
            this.btnDekriptuj.Size = new System.Drawing.Size(109, 49);
            this.btnDekriptuj.TabIndex = 7;
            this.btnDekriptuj.Text = "Dekriptuj";
            this.btnDekriptuj.UseVisualStyleBackColor = false;
            this.btnDekriptuj.Click += new System.EventHandler(this.btnDekriptuj_Click);
            // 
            // btnKriptuj
            // 
            this.btnKriptuj.BackColor = System.Drawing.Color.GreenYellow;
            this.btnKriptuj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKriptuj.Location = new System.Drawing.Point(24, 60);
            this.btnKriptuj.Name = "btnKriptuj";
            this.btnKriptuj.Size = new System.Drawing.Size(109, 48);
            this.btnKriptuj.TabIndex = 6;
            this.btnKriptuj.Text = "Kriptuj";
            this.btnKriptuj.UseVisualStyleBackColor = false;
            this.btnKriptuj.Click += new System.EventHandler(this.btnKriptuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kljuc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulaz";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(184, 126);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(496, 25);
            this.tbKey.TabIndex = 1;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(184, 55);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(496, 25);
            this.tbInput.TabIndex = 0;
            // 
            // btnOTP
            // 
            this.btnOTP.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOTP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOTP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOTP.Location = new System.Drawing.Point(62, 31);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(119, 50);
            this.btnOTP.TabIndex = 14;
            this.btnOTP.Text = "One-Time Pad";
            this.btnOTP.UseVisualStyleBackColor = false;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnXxtea
            // 
            this.btnXxtea.BackColor = System.Drawing.Color.YellowGreen;
            this.btnXxtea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXxtea.Location = new System.Drawing.Point(62, 195);
            this.btnXxtea.Name = "btnXxtea";
            this.btnXxtea.Size = new System.Drawing.Size(119, 53);
            this.btnXxtea.TabIndex = 18;
            this.btnXxtea.Text = "XXTEA";
            this.btnXxtea.UseVisualStyleBackColor = false;
            this.btnXxtea.Click += new System.EventHandler(this.btnXxtea_Click);
            // 
            // gbXXTea
            // 
            this.gbXXTea.Controls.Add(this.btnInpuTea);
            this.gbXXTea.Controls.Add(this.btnDecrTea);
            this.gbXXTea.Controls.Add(this.btnCrypTea);
            this.gbXXTea.Controls.Add(this.label10);
            this.gbXXTea.Controls.Add(this.tbInpTea);
            this.gbXXTea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbXXTea.Location = new System.Drawing.Point(223, 31);
            this.gbXXTea.Name = "gbXXTea";
            this.gbXXTea.Size = new System.Drawing.Size(715, 246);
            this.gbXXTea.TabIndex = 16;
            this.gbXXTea.TabStop = false;
            this.gbXXTea.Text = "XXTEA";
            // 
            // btnInpuTea
            // 
            this.btnInpuTea.BackColor = System.Drawing.Color.Ivory;
            this.btnInpuTea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpuTea.Location = new System.Drawing.Point(496, 103);
            this.btnInpuTea.Name = "btnInpuTea";
            this.btnInpuTea.Size = new System.Drawing.Size(184, 32);
            this.btnInpuTea.TabIndex = 8;
            this.btnInpuTea.Text = "Izaberite ulazni fajl";
            this.btnInpuTea.UseVisualStyleBackColor = false;
            this.btnInpuTea.Click += new System.EventHandler(this.btnInpuTea_Click);
            // 
            // btnDecrTea
            // 
            this.btnDecrTea.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDecrTea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrTea.Location = new System.Drawing.Point(31, 133);
            this.btnDecrTea.Name = "btnDecrTea";
            this.btnDecrTea.Size = new System.Drawing.Size(109, 47);
            this.btnDecrTea.TabIndex = 7;
            this.btnDecrTea.Text = "Dekriptuj";
            this.btnDecrTea.UseVisualStyleBackColor = false;
            this.btnDecrTea.Click += new System.EventHandler(this.btnDecrTea_Click);
            // 
            // btnCrypTea
            // 
            this.btnCrypTea.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCrypTea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypTea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrypTea.Location = new System.Drawing.Point(30, 57);
            this.btnCrypTea.Name = "btnCrypTea";
            this.btnCrypTea.Size = new System.Drawing.Size(109, 46);
            this.btnCrypTea.TabIndex = 6;
            this.btnCrypTea.Text = "Kriptuj";
            this.btnCrypTea.UseVisualStyleBackColor = false;
            this.btnCrypTea.Click += new System.EventHandler(this.btnCrypTea_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ulaz";
            // 
            // tbInpTea
            // 
            this.tbInpTea.Location = new System.Drawing.Point(184, 56);
            this.tbInpTea.Name = "tbInpTea";
            this.tbInpTea.Size = new System.Drawing.Size(496, 25);
            this.tbInpTea.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(989, 420);
            this.Controls.Add(this.gbXXTea);
            this.Controls.Add(this.gbFSC);
            this.Controls.Add(this.btnXxtea);
            this.Controls.Add(this.btnFSC);
            this.Controls.Add(this.grbOTP);
            this.Controls.Add(this.btnOTP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Krptiii";
            this.gbFSC.ResumeLayout(false);
            this.gbFSC.PerformLayout();
            this.grbOTP.ResumeLayout(false);
            this.grbOTP.PerformLayout();
            this.gbXXTea.ResumeLayout(false);
            this.gbXXTea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFSC;
        private System.Windows.Forms.Button btnKey2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbK2;
        private System.Windows.Forms.Button btnDFSC;
        private System.Windows.Forms.Button btnCFSC;
        private System.Windows.Forms.Button btnKey1FSC;
        private System.Windows.Forms.Button btnInputFSC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbK1;
        private System.Windows.Forms.TextBox tbInpF;
        private System.Windows.Forms.Button btnFSC;
        private System.Windows.Forms.GroupBox grbOTP;
        private System.Windows.Forms.Button btnKeyFile;
        private System.Windows.Forms.Button btnInpFile;
        private System.Windows.Forms.Button btnDekriptuj;
        private System.Windows.Forms.Button btnKriptuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnOTP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnXxtea;
        private System.Windows.Forms.GroupBox gbXXTea;
        private System.Windows.Forms.Button btnInpuTea;
        private System.Windows.Forms.Button btnDecrTea;
        private System.Windows.Forms.Button btnCrypTea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbInpTea;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

