using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class Anotacoes : Form
    {
        public string Texto { get; set; }
        public Color Cor { get; set; }

        public Anotacoes()
        {
            InitializeComponent();
        }

        private void btnCinza_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(89, 89, 89);
            this.Cor = Color.FromArgb(89, 89, 89);
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RosyBrown;
            this.Cor = Color.RosyBrown;
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
            this.Cor = Color.PaleGoldenrod;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSeaGreen;
            this.Cor = Color.DarkSeaGreen;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Texto = richTextBox1.Text;
            this.Close();
        }
    }
}
