namespace Rapor
{
    partial class Form2
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.ekipman_guc = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.LoadDoc = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveDoc = new System.Windows.Forms.SaveFileDialog();
            this.picture = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Import_Image = new System.Windows.Forms.Button();
            this.graphs = new System.Windows.Forms.FolderBrowserDialog();
            this.openexcel = new System.Windows.Forms.Button();
            this.excelac = new System.Windows.Forms.OpenFileDialog();
            this.export = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ekipman_devir = new System.Windows.Forms.TextBox();
            this.exportpath = new System.Windows.Forms.FolderBrowserDialog();
            this.ekipman_model = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mahal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.firma_dokuman_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.e_posta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uretici_firma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gign_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ekipman_adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siparis_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.MaskedTextBox();
            this.test_tarihi = new System.Windows.Forms.MaskedTextBox();
            this.rapor_tarihi = new System.Windows.Forms.MaskedTextBox();
            this.telefon_no = new System.Windows.Forms.MaskedTextBox();
            this.proje_dokuman_no = new System.Windows.Forms.MaskedTextBox();
            this.olcum_yeri = new System.Windows.Forms.ComboBox();
            this.olcumu_gerceklestiren = new System.Windows.Forms.ComboBox();
            this.gemi_adi = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(746, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(272, 22);
            this.textBox4.TabIndex = 89;
            this.textBox4.Text = "Grafikleri kopyalamak istediğiniz klasörü seçiniz.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1038, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 82;
            this.button2.Text = "Gözat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(440, 379);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 80;
            this.label19.Text = "18-Devir:";
            // 
            // ekipman_guc
            // 
            this.ekipman_guc.Location = new System.Drawing.Point(572, 333);
            this.ekipman_guc.Name = "ekipman_guc";
            this.ekipman_guc.Size = new System.Drawing.Size(64, 20);
            this.ekipman_guc.TabIndex = 79;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(440, 336);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 78;
            this.label20.Text = "17-Güç:";
            // 
            // LoadDoc
            // 
            this.LoadDoc.FileName = "LoadDoc";
            this.LoadDoc.Filter = "Word Files|*.docx*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(746, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(272, 22);
            this.textBox1.TabIndex = 83;
            this.textBox1.Text = "Tüm girdilerin ekleneceği raporu seçiniz.";
            // 
            // SaveDoc
            // 
            this.SaveDoc.Filter = "Word Files|*.docx*";
            // 
            // picture
            // 
            this.picture.FileName = "picture";
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(746, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(272, 22);
            this.textBox2.TabIndex = 85;
            this.textBox2.Text = "Rapora eklenecek grafikleri seçiniz.";
            // 
            // Import_Image
            // 
            this.Import_Image.Location = new System.Drawing.Point(1038, 75);
            this.Import_Image.Name = "Import_Image";
            this.Import_Image.Size = new System.Drawing.Size(93, 23);
            this.Import_Image.TabIndex = 84;
            this.Import_Image.Text = "Gözat";
            this.Import_Image.UseVisualStyleBackColor = true;
            this.Import_Image.Click += new System.EventHandler(this.Import_Image_Click_1);
            // 
            // openexcel
            // 
            this.openexcel.Location = new System.Drawing.Point(1038, 39);
            this.openexcel.Name = "openexcel";
            this.openexcel.Size = new System.Drawing.Size(93, 23);
            this.openexcel.TabIndex = 86;
            this.openexcel.Text = "Gözat";
            this.openexcel.UseVisualStyleBackColor = true;
            this.openexcel.Click += new System.EventHandler(this.Openexcel_Click_1);
            // 
            // excelac
            // 
            this.excelac.FileName = "excelac";
            this.excelac.Filter = "Excel Files|*.xlsx*";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(1038, 10);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(93, 23);
            this.export.TabIndex = 88;
            this.export.Text = "Gözat";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.Export_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(746, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(272, 22);
            this.textBox3.TabIndex = 87;
            this.textBox3.Text = "Grafikleri içeren dökümanı seçiniz.";
            // 
            // ekipman_devir
            // 
            this.ekipman_devir.Location = new System.Drawing.Point(572, 376);
            this.ekipman_devir.Name = "ekipman_devir";
            this.ekipman_devir.Size = new System.Drawing.Size(64, 20);
            this.ekipman_devir.TabIndex = 81;
            // 
            // ekipman_model
            // 
            this.ekipman_model.Location = new System.Drawing.Point(572, 294);
            this.ekipman_model.Name = "ekipman_model";
            this.ekipman_model.Size = new System.Drawing.Size(64, 20);
            this.ekipman_model.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "16-Model:";
            // 
            // mahal
            // 
            this.mahal.Location = new System.Drawing.Point(572, 256);
            this.mahal.Name = "mahal";
            this.mahal.Size = new System.Drawing.Size(64, 20);
            this.mahal.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(438, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "15-Mahal:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(438, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 72;
            this.label15.Text = "14-Ölçüm Yeri:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(438, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "13-Gemi Adı:";
            // 
            // firma_dokuman_no
            // 
            this.firma_dokuman_no.Location = new System.Drawing.Point(572, 127);
            this.firma_dokuman_no.Name = "firma_dokuman_no";
            this.firma_dokuman_no.Size = new System.Drawing.Size(64, 20);
            this.firma_dokuman_no.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "12-Firma Döküman No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "11-Proje Döküman No:";
            // 
            // e_posta
            // 
            this.e_posta.Location = new System.Drawing.Point(572, 46);
            this.e_posta.Name = "e_posta";
            this.e_posta.Size = new System.Drawing.Size(64, 20);
            this.e_posta.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "10-E-posta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "9-Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "8-Ölçümü Gerçekleştiren:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "7-Rapor Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "6-Test Tarihi:";
            // 
            // uretici_firma
            // 
            this.uretici_firma.Location = new System.Drawing.Point(148, 179);
            this.uretici_firma.Name = "uretici_firma";
            this.uretici_firma.Size = new System.Drawing.Size(65, 20);
            this.uretici_firma.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "5-Üretici Firma:";
            // 
            // gign_no
            // 
            this.gign_no.Location = new System.Drawing.Point(148, 136);
            this.gign_no.Name = "gign_no";
            this.gign_no.Size = new System.Drawing.Size(65, 20);
            this.gign_no.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "4-GIGN No:";
            // 
            // ekipman_adi
            // 
            this.ekipman_adi.Location = new System.Drawing.Point(148, 94);
            this.ekipman_adi.Name = "ekipman_adi";
            this.ekipman_adi.Size = new System.Drawing.Size(65, 20);
            this.ekipman_adi.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "3-Ekipman Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "2-Tarih:";
            // 
            // siparis_no
            // 
            this.siparis_no.Location = new System.Drawing.Point(148, 16);
            this.siparis_no.Name = "siparis_no";
            this.siparis_no.Size = new System.Drawing.Size(65, 20);
            this.siparis_no.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "1-Sipariş No:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(746, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 79);
            this.button1.TabIndex = 45;
            this.button1.Text = "RAPORU OLUŞTUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(148, 54);
            this.tarih.Mask = "00-00";
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(65, 20);
            this.tarih.TabIndex = 90;
            // 
            // test_tarihi
            // 
            this.test_tarihi.Location = new System.Drawing.Point(148, 220);
            this.test_tarihi.Mask = "00/00/0000";
            this.test_tarihi.Name = "test_tarihi";
            this.test_tarihi.Size = new System.Drawing.Size(65, 20);
            this.test_tarihi.TabIndex = 91;
            this.test_tarihi.ValidatingType = typeof(System.DateTime);
            // 
            // rapor_tarihi
            // 
            this.rapor_tarihi.Location = new System.Drawing.Point(148, 261);
            this.rapor_tarihi.Mask = "00/00/0000";
            this.rapor_tarihi.Name = "rapor_tarihi";
            this.rapor_tarihi.Size = new System.Drawing.Size(65, 20);
            this.rapor_tarihi.TabIndex = 92;
            this.rapor_tarihi.ValidatingType = typeof(System.DateTime);
            // 
            // telefon_no
            // 
            this.telefon_no.Location = new System.Drawing.Point(572, 10);
            this.telefon_no.Mask = "(0000) 000 00 00";
            this.telefon_no.Name = "telefon_no";
            this.telefon_no.Size = new System.Drawing.Size(94, 20);
            this.telefon_no.TabIndex = 93;
            // 
            // proje_dokuman_no
            // 
            this.proje_dokuman_no.Location = new System.Drawing.Point(572, 85);
            this.proje_dokuman_no.Mask = "000-A000-0000-000-000";
            this.proje_dokuman_no.Name = "proje_dokuman_no";
            this.proje_dokuman_no.Size = new System.Drawing.Size(124, 20);
            this.proje_dokuman_no.TabIndex = 94;
            // 
            // olcum_yeri
            // 
            this.olcum_yeri.FormattingEnabled = true;
            this.olcum_yeri.Items.AddRange(new object[] {
            "İstanbul Tersanesinde",
            "Seyir halinde"});
            this.olcum_yeri.Location = new System.Drawing.Point(572, 212);
            this.olcum_yeri.Name = "olcum_yeri";
            this.olcum_yeri.Size = new System.Drawing.Size(153, 21);
            this.olcum_yeri.TabIndex = 95;
            // 
            // olcumu_gerceklestiren
            // 
            this.olcumu_gerceklestiren.FormattingEnabled = true;
            this.olcumu_gerceklestiren.Items.AddRange(new object[] {
            "Yunus Emre TANIK",
            "Burak BAYRAKLI",
            "Birol MENEKŞE",
            "Yunus Emre TANIK - Burak BAYRAKLI",
            "Yunus Emre TANIK - Birol MENEKŞE",
            "Burak BAYRAKLI - Birol MENEKŞE"});
            this.olcumu_gerceklestiren.Location = new System.Drawing.Point(148, 301);
            this.olcumu_gerceklestiren.Name = "olcumu_gerceklestiren";
            this.olcumu_gerceklestiren.Size = new System.Drawing.Size(202, 21);
            this.olcumu_gerceklestiren.TabIndex = 96;
            // 
            // gemi_adi
            // 
            this.gemi_adi.FormattingEnabled = true;
            this.gemi_adi.Items.AddRange(new object[] {
            "TCG BURGAZADA (F513)",
            "TCG KINALIADA (F513)"});
            this.gemi_adi.Location = new System.Drawing.Point(572, 170);
            this.gemi_adi.Name = "gemi_adi";
            this.gemi_adi.Size = new System.Drawing.Size(153, 21);
            this.gemi_adi.TabIndex = 97;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(16, 455);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1115, 23);
            this.progressBar1.TabIndex = 98;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 490);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gemi_adi);
            this.Controls.Add(this.olcumu_gerceklestiren);
            this.Controls.Add(this.olcum_yeri);
            this.Controls.Add(this.proje_dokuman_no);
            this.Controls.Add(this.telefon_no);
            this.Controls.Add(this.rapor_tarihi);
            this.Controls.Add(this.test_tarihi);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ekipman_guc);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Import_Image);
            this.Controls.Add(this.openexcel);
            this.Controls.Add(this.export);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ekipman_devir);
            this.Controls.Add(this.ekipman_model);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mahal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.firma_dokuman_no);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.e_posta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uretici_firma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gign_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ekipman_adi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siparis_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "RAPOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ekipman_guc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.OpenFileDialog LoadDoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog SaveDoc;
        private System.Windows.Forms.OpenFileDialog picture;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Import_Image;
        private System.Windows.Forms.FolderBrowserDialog graphs;
        private System.Windows.Forms.Button openexcel;
        private System.Windows.Forms.OpenFileDialog excelac;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ekipman_devir;
        private System.Windows.Forms.FolderBrowserDialog exportpath;
        private System.Windows.Forms.TextBox ekipman_model;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mahal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox firma_dokuman_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox e_posta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uretici_firma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gign_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ekipman_adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox siparis_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tarih;
        private System.Windows.Forms.MaskedTextBox test_tarihi;
        private System.Windows.Forms.MaskedTextBox rapor_tarihi;
        private System.Windows.Forms.MaskedTextBox telefon_no;
        private System.Windows.Forms.MaskedTextBox proje_dokuman_no;
        private System.Windows.Forms.ComboBox olcum_yeri;
        private System.Windows.Forms.ComboBox olcumu_gerceklestiren;
        private System.Windows.Forms.ComboBox gemi_adi;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}