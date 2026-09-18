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
            lbl_Resultado.Text = txt_Nome.Text + " " + txt_Sobrenome.Text + "\n" + txt_idade.Text + "\n" + 
                txt_Bairro.Text + "\n" + txt_Celular.Text + "\n" + txt_Email.Text;
        }

        private void lbl_Sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void rad_Tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.civic_g10;//Muda a imagem de fundo apertando o botão tema1
        }

        private void rad_Tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.civic_g8;//Muda a imagem de fundo apertando o botão tema2
        }

        private void rad_Tema3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.civic_g11;//Muda a imagem de fundo apertando o botão tema3
        }

        private void btn_Nome_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Nome.Text;//Recebe o nome digitado
        }

        private void btn_Sobrenome_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Sobrenome.Text;//Recebe o Sobrenome digitado
        }

        private void btn_Idade_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_idade.Text;//Recebe a idade digitada
        }

        private void btn_Bairro_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Bairro.Text;//Recebe o Bairro digitado
        }

        private void lbl_Celular_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Celular_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Celular.Text;//Recebe o Celular/Telefone digitado
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Email.Text;//Recebe o Email digitado
        }

        private void btn_Ativar_Click(object sender, EventArgs e)
        {
            btn_Desativar.Enabled = true;
            btn_Limpar.Enabled = true;
        }

        private void btn_Desativar_Click(object sender, EventArgs e)
        {
            btn_Desativar.Enabled = false;
            btn_Limpar.Enabled = false;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Nome.Clear();
            txt_Sobrenome.Clear();
            txt_idade.Clear();
            txt_Bairro.Clear();
            txt_Celular.Clear();
            txt_Email.Clear();
        }
    }
}
