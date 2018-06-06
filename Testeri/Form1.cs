using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Piirtoavut;

namespace Testeri {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        #region Pistekäsittelyä
        private void btnUusiPiste_Click(object sender, EventArgs e)
        {
            Piirtoavut.Piste p = new Piirtoavut.Piste(int.Parse(txtX.Text), int.Parse(txtY.Text));
            lbTulostus.Items.Add(p.ToString());

            Piste p2 = new Piste();
            lbTulostus.Items.Add(p2.ToString());
        }

        private void btnAjaGC_Click(object sender, EventArgs e) {
        }

        private void btnPisteLkm_Click(object sender, EventArgs e) {
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e) {
        }

        #region Hiiri
        private void pbPiirtoAlusta_MouseDown(object sender, MouseEventArgs e) {
            // e-parametrissä X ja Y ominaisuudet
        }
        #endregion

        private void btnPixel_Click(object sender, EventArgs e) {
        }

        private void btnYmpyrä_Click(object sender, EventArgs e) {
        }

        private void btnNelikulmio_Click(object sender, EventArgs e) {
        }

        #region Kokoelmien käsittelyä
        private void bTulosta_Click(object sender, EventArgs e) {
        }

        private void bPoistaViimeinen_Click(object sender, EventArgs e) {
        }

        private void bSuurenna_Click(object sender, EventArgs e) {
        }

        private void bPienennä_Click(object sender, EventArgs e) {
        }

        #endregion

        #region Piirto
        private void pbPiirtoAlusta_Paint(object sender, PaintEventArgs e) {
        }

        private void pbPiirtoAlusta_Resize(object sender, EventArgs e) {
        }

        #endregion



    }
}