
namespace Apoteka
{
    partial class Apoteka
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviLekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.povećajZaliheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKorpa = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUkupno = new System.Windows.Forms.TextBox();
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnPromeniKolicinu = new System.Windows.Forms.Button();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbStanje = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opadajuceSortiranje = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.izmeniInventarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviLekToolStripMenuItem,
            this.povećajZaliheToolStripMenuItem,
            this.izmeniInventarToolStripMenuItem});
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            // 
            // dodajNoviLekToolStripMenuItem
            // 
            this.dodajNoviLekToolStripMenuItem.Name = "dodajNoviLekToolStripMenuItem";
            this.dodajNoviLekToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.dodajNoviLekToolStripMenuItem.Text = "Dodaj novi lek";
            this.dodajNoviLekToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviLekToolStripMenuItem_Click);
            // 
            // povećajZaliheToolStripMenuItem
            // 
            this.povećajZaliheToolStripMenuItem.Name = "povećajZaliheToolStripMenuItem";
            this.povećajZaliheToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.povećajZaliheToolStripMenuItem.Text = "Povećaj zalihe";
            this.povećajZaliheToolStripMenuItem.Click += new System.EventHandler(this.povećajZaliheToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAČUN";
            // 
            // lbKorpa
            // 
            this.lbKorpa.FormattingEnabled = true;
            this.lbKorpa.ItemHeight = 16;
            this.lbKorpa.Location = new System.Drawing.Point(12, 52);
            this.lbKorpa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbKorpa.Name = "lbKorpa";
            this.lbKorpa.Size = new System.Drawing.Size(335, 244);
            this.lbKorpa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "UKUPNO:";
            // 
            // tbUkupno
            // 
            this.tbUkupno.Location = new System.Drawing.Point(133, 313);
            this.tbUkupno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUkupno.Name = "tbUkupno";
            this.tbUkupno.Size = new System.Drawing.Size(129, 22);
            this.tbUkupno.TabIndex = 4;
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(25, 366);
            this.btnKupi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(85, 27);
            this.btnKupi.TabIndex = 5;
            this.btnKupi.Text = "KUPI";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(133, 366);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(85, 27);
            this.btnIzbrisi.TabIndex = 6;
            this.btnIzbrisi.Text = "IZBRIŠI";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(243, 366);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 27);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(25, 398);
            this.btnPonisti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(85, 27);
            this.btnPonisti.TabIndex = 8;
            this.btnPonisti.Text = "PONIŠTI";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnPromeniKolicinu
            // 
            this.btnPromeniKolicinu.Location = new System.Drawing.Point(123, 398);
            this.btnPromeniKolicinu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPromeniKolicinu.Name = "btnPromeniKolicinu";
            this.btnPromeniKolicinu.Size = new System.Drawing.Size(104, 46);
            this.btnPromeniKolicinu.TabIndex = 9;
            this.btnPromeniKolicinu.Text = "PROMENI KOLIČINU";
            this.btnPromeniKolicinu.UseVisualStyleBackColor = true;
            this.btnPromeniKolicinu.Click += new System.EventHandler(this.btnPromeniKolicinu_Click);
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(243, 409);
            this.tbKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(104, 22);
            this.tbKolicina.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbStanje);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(385, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(403, 497);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STANJE";
            // 
            // lbStanje
            // 
            this.lbStanje.FormattingEnabled = true;
            this.lbStanje.ItemHeight = 16;
            this.lbStanje.Location = new System.Drawing.Point(32, 260);
            this.lbStanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStanje.Name = "lbStanje";
            this.lbStanje.Size = new System.Drawing.Size(336, 212);
            this.lbStanje.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbPretraga);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(32, 121);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(336, 134);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRETRAGA PO:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "PRETRAŽI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ANTIBIOTIK",
            "ANALGETIK",
            "PROBIOTIK",
            "ANTIPIRETIK",
            "ANTIDIJABETIK",
            "ANTIDIJAROIK",
            "ANTIEMETIK",
            "ANTIMIKOTIK",
            "BENZODIAZEPIN",
            "BRONHODILATOR",
            "DIURETIK",
            "KORTIKOSTEROID"});
            this.comboBox1.Location = new System.Drawing.Point(131, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "PRIKAŽI SAMO:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Location = new System.Drawing.Point(17, 56);
            this.tbPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(177, 22);
            this.tbPretraga.TabIndex = 5;
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(173, 27);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 21);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ŠIFRI";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(85, 27);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "IMENU";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opadajuceSortiranje);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(32, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(336, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SORTIRAJ PO:";
            // 
            // opadajuceSortiranje
            // 
            this.opadajuceSortiranje.AutoSize = true;
            this.opadajuceSortiranje.Location = new System.Drawing.Point(196, 34);
            this.opadajuceSortiranje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opadajuceSortiranje.Name = "opadajuceSortiranje";
            this.opadajuceSortiranje.Size = new System.Drawing.Size(99, 21);
            this.opadajuceSortiranje.TabIndex = 2;
            this.opadajuceSortiranje.Text = "Opadajuče";
            this.opadajuceSortiranje.UseVisualStyleBackColor = true;
            this.opadajuceSortiranje.CheckedChanged += new System.EventHandler(this.opadajuceSortiranje_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(117, 34);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CENI";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "IMENU";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // izmeniInventarToolStripMenuItem
            // 
            this.izmeniInventarToolStripMenuItem.Name = "izmeniInventarToolStripMenuItem";
            this.izmeniInventarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniInventarToolStripMenuItem.Text = "Izmeni inventar";
            this.izmeniInventarToolStripMenuItem.Click += new System.EventHandler(this.izmeniInventarToolStripMenuItem_Click_1);
            // 
            // Apoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.btnPromeniKolicinu);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.tbUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKorpa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Apoteka";
            this.Text = "Apoteka";
            this.Load += new System.EventHandler(this.Apoteka_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviLekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem povećajZaliheToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKorpa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUkupno;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnPromeniKolicinu;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbStanje;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox opadajuceSortiranje;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem izmeniInventarToolStripMenuItem;
    }
}

