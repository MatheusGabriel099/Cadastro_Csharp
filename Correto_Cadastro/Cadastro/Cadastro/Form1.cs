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

        private void btn_Nome_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Nome.Text;//Recebendo o nome digitado
        }

        private void btn_Sobrenome_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Sobrenome.Text;
        }

        private void btn_Idade_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_idade.Text;
        }

        private void btn_Bairro_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Bairro.Text;
        }

        private void lbl_Celular_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Celular_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Celular.Text;
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Email.Text;
        }
    }
}
