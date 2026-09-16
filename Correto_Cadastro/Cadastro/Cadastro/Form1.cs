using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Frm_ITexto_Load(object sender, EventArgs e)
        {

        }

        private void btn_DadosCompleto_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void rad_Tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.civic_g10;
        }

        private void rad_Tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.civic_g8;
        }

        private void rad_Tema3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.civic_g11;
        }
    }
}
