namespace Testeri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnPisteLkm = new System.Windows.Forms.Button();
            this.btnAjaGC = new System.Windows.Forms.Button();
            this.btnUusiPiste = new System.Windows.Forms.Button();
            this.cbVäri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTulostus = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKorkeus = new System.Windows.Forms.TextBox();
            this.txtLeveys = new System.Windows.Forms.TextBox();
            this.txtSäde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNelikulmio = new System.Windows.Forms.Button();
            this.btnYmpyrä = new System.Windows.Forms.Button();
            this.btnPixel = new System.Windows.Forms.Button();
            this.btnPienennä = new System.Windows.Forms.Button();
            this.btnSuurenna = new System.Windows.Forms.Button();
            this.btnPoistaViimeinen = new System.Windows.Forms.Button();
            this.btnTulostaTiedot = new System.Windows.Forms.Button();
            this.pbPiirtoAlusta = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiirtoAlusta)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.btnPisteLkm);
            this.groupBox1.Controls.Add(this.btnAjaGC);
            this.groupBox1.Controls.Add(this.btnUusiPiste);
            this.groupBox1.Controls.Add(this.cbVäri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(362, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Piste-luokan käsittely";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(52, 49);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(72, 23);
            this.txtY.TabIndex = 9;
            this.txtY.Text = "10";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(52, 20);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(72, 23);
            this.txtX.TabIndex = 9;
            this.txtX.Text = "10";
            // 
            // btnPisteLkm
            // 
            this.btnPisteLkm.Location = new System.Drawing.Point(226, 75);
            this.btnPisteLkm.Name = "btnPisteLkm";
            this.btnPisteLkm.Size = new System.Drawing.Size(118, 26);
            this.btnPisteLkm.TabIndex = 8;
            this.btnPisteLkm.Text = "Pisteiden lkm";
            this.btnPisteLkm.UseVisualStyleBackColor = true;
            this.btnPisteLkm.Click += new System.EventHandler(this.btnPisteLkm_Click);
            // 
            // btnAjaGC
            // 
            this.btnAjaGC.Location = new System.Drawing.Point(226, 48);
            this.btnAjaGC.Name = "btnAjaGC";
            this.btnAjaGC.Size = new System.Drawing.Size(118, 25);
            this.btnAjaGC.TabIndex = 8;
            this.btnAjaGC.Text = "GC";
            this.btnAjaGC.UseVisualStyleBackColor = true;
            this.btnAjaGC.Click += new System.EventHandler(this.btnAjaGC_Click);
            // 
            // btnUusiPiste
            // 
            this.btnUusiPiste.Location = new System.Drawing.Point(226, 20);
            this.btnUusiPiste.Name = "btnUusiPiste";
            this.btnUusiPiste.Size = new System.Drawing.Size(118, 25);
            this.btnUusiPiste.TabIndex = 8;
            this.btnUusiPiste.Text = "Uusi Piste";
            this.btnUusiPiste.UseVisualStyleBackColor = true;
            this.btnUusiPiste.Click += new System.EventHandler(this.btnUusiPiste_Click);
            // 
            // cbVäri
            // 
            this.cbVäri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVäri.FormattingEnabled = true;
            this.cbVäri.Location = new System.Drawing.Point(52, 75);
            this.cbVäri.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbVäri.Name = "cbVäri";
            this.cbVäri.Size = new System.Drawing.Size(137, 24);
            this.cbVäri.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Väri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // lbTulostus
            // 
            this.lbTulostus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTulostus.FormattingEnabled = true;
            this.lbTulostus.IntegralHeight = false;
            this.lbTulostus.ItemHeight = 16;
            this.lbTulostus.Location = new System.Drawing.Point(3, 114);
            this.lbTulostus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbTulostus.Name = "lbTulostus";
            this.lbTulostus.Size = new System.Drawing.Size(362, 347);
            this.lbTulostus.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtKorkeus);
            this.groupBox2.Controls.Add(this.txtLeveys);
            this.groupBox2.Controls.Add(this.txtSäde);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnNelikulmio);
            this.groupBox2.Controls.Add(this.btnYmpyrä);
            this.groupBox2.Controls.Add(this.btnPixel);
            this.groupBox2.Controls.Add(this.btnPienennä);
            this.groupBox2.Controls.Add(this.btnSuurenna);
            this.groupBox2.Controls.Add(this.btnPoistaViimeinen);
            this.groupBox2.Controls.Add(this.btnTulostaTiedot);
            this.groupBox2.Location = new System.Drawing.Point(375, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(634, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafiikka";
            // 
            // txtKorkeus
            // 
            this.txtKorkeus.Location = new System.Drawing.Point(306, 77);
            this.txtKorkeus.Name = "txtKorkeus";
            this.txtKorkeus.Size = new System.Drawing.Size(52, 23);
            this.txtKorkeus.TabIndex = 9;
            this.txtKorkeus.Text = "10";
            // 
            // txtLeveys
            // 
            this.txtLeveys.Location = new System.Drawing.Point(182, 77);
            this.txtLeveys.Name = "txtLeveys";
            this.txtLeveys.Size = new System.Drawing.Size(52, 23);
            this.txtLeveys.TabIndex = 9;
            this.txtLeveys.Text = "10";
            // 
            // txtSäde
            // 
            this.txtSäde.Location = new System.Drawing.Point(182, 49);
            this.txtSäde.Name = "txtSäde";
            this.txtSäde.Size = new System.Drawing.Size(52, 23);
            this.txtSäde.TabIndex = 9;
            this.txtSäde.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Korkeus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Leveys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Säde";
            // 
            // btnNelikulmio
            // 
            this.btnNelikulmio.Location = new System.Drawing.Point(8, 75);
            this.btnNelikulmio.Name = "btnNelikulmio";
            this.btnNelikulmio.Size = new System.Drawing.Size(99, 25);
            this.btnNelikulmio.TabIndex = 10;
            this.btnNelikulmio.Text = "Nelikulmio";
            this.btnNelikulmio.UseVisualStyleBackColor = true;
            this.btnNelikulmio.Click += new System.EventHandler(this.btnNelikulmio_Click);
            // 
            // btnYmpyrä
            // 
            this.btnYmpyrä.Location = new System.Drawing.Point(8, 49);
            this.btnYmpyrä.Name = "btnYmpyrä";
            this.btnYmpyrä.Size = new System.Drawing.Size(99, 25);
            this.btnYmpyrä.TabIndex = 10;
            this.btnYmpyrä.Text = "Ympyrä";
            this.btnYmpyrä.UseVisualStyleBackColor = true;
            this.btnYmpyrä.Click += new System.EventHandler(this.btnYmpyrä_Click);
            // 
            // btnPixel
            // 
            this.btnPixel.Location = new System.Drawing.Point(8, 21);
            this.btnPixel.Name = "btnPixel";
            this.btnPixel.Size = new System.Drawing.Size(99, 25);
            this.btnPixel.TabIndex = 10;
            this.btnPixel.Text = "Pixel";
            this.btnPixel.UseVisualStyleBackColor = true;
            this.btnPixel.Click += new System.EventHandler(this.btnPixel_Click);
            // 
            // btnPienennä
            // 
            this.btnPienennä.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPienennä.Location = new System.Drawing.Point(366, 47);
            this.btnPienennä.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPienennä.Name = "btnPienennä";
            this.btnPienennä.Size = new System.Drawing.Size(127, 27);
            this.btnPienennä.TabIndex = 9;
            this.btnPienennä.Text = "Pienennä";
            this.btnPienennä.UseVisualStyleBackColor = true;
            this.btnPienennä.Click += new System.EventHandler(this.bPienennä_Click);
            // 
            // btnSuurenna
            // 
            this.btnSuurenna.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuurenna.Location = new System.Drawing.Point(366, 21);
            this.btnSuurenna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuurenna.Name = "btnSuurenna";
            this.btnSuurenna.Size = new System.Drawing.Size(127, 27);
            this.btnSuurenna.TabIndex = 9;
            this.btnSuurenna.Text = "Suurenna";
            this.btnSuurenna.UseVisualStyleBackColor = true;
            this.btnSuurenna.Click += new System.EventHandler(this.bSuurenna_Click);
            // 
            // btnPoistaViimeinen
            // 
            this.btnPoistaViimeinen.Location = new System.Drawing.Point(499, 47);
            this.btnPoistaViimeinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoistaViimeinen.Name = "btnPoistaViimeinen";
            this.btnPoistaViimeinen.Size = new System.Drawing.Size(127, 27);
            this.btnPoistaViimeinen.TabIndex = 8;
            this.btnPoistaViimeinen.Text = "Poista viimeinen";
            this.btnPoistaViimeinen.UseVisualStyleBackColor = true;
            this.btnPoistaViimeinen.Click += new System.EventHandler(this.bPoistaViimeinen_Click);
            // 
            // btnTulostaTiedot
            // 
            this.btnTulostaTiedot.Location = new System.Drawing.Point(499, 20);
            this.btnTulostaTiedot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTulostaTiedot.Name = "btnTulostaTiedot";
            this.btnTulostaTiedot.Size = new System.Drawing.Size(127, 27);
            this.btnTulostaTiedot.TabIndex = 7;
            this.btnTulostaTiedot.Text = "Tulosta tiedot";
            this.btnTulostaTiedot.UseVisualStyleBackColor = true;
            this.btnTulostaTiedot.Click += new System.EventHandler(this.bTulosta_Click);
            // 
            // pbPiirtoAlusta
            // 
            this.pbPiirtoAlusta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPiirtoAlusta.BackColor = System.Drawing.Color.White;
            this.pbPiirtoAlusta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPiirtoAlusta.Location = new System.Drawing.Point(375, 114);
            this.pbPiirtoAlusta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbPiirtoAlusta.Name = "pbPiirtoAlusta";
            this.pbPiirtoAlusta.Size = new System.Drawing.Size(634, 347);
            this.pbPiirtoAlusta.TabIndex = 3;
            this.pbPiirtoAlusta.TabStop = false;
            this.pbPiirtoAlusta.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPiirtoAlusta_Paint);
            this.pbPiirtoAlusta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPiirtoAlusta_MouseDown);
            this.pbPiirtoAlusta.Resize += new System.EventHandler(this.pbPiirtoAlusta_Resize);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbPiirtoAlusta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTulostus);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Testeri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiirtoAlusta)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbVäri;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lbTulostus;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.PictureBox pbPiirtoAlusta;
		private System.Windows.Forms.Button btnTulostaTiedot;
		private System.Windows.Forms.Button btnPoistaViimeinen;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button btnPienennä;
        private System.Windows.Forms.Button btnSuurenna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPisteLkm;
        private System.Windows.Forms.Button btnAjaGC;
        private System.Windows.Forms.Button btnUusiPiste;
        private System.Windows.Forms.Button btnNelikulmio;
        private System.Windows.Forms.Button btnYmpyrä;
        private System.Windows.Forms.Button btnPixel;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtKorkeus;
        private System.Windows.Forms.TextBox txtLeveys;
        private System.Windows.Forms.TextBox txtSäde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
  }
}

