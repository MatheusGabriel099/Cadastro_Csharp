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
                txt_Bairro.Text + "\n" + txt_Celular.Text + "\n" + txt_Email.Text; //Mostra todos os valores recebidos na tela
        }

        private void lbl_Sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void rad_Tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.porsche911;//Muda a imagem de fundo apertando o botão tema1
        }

        private void rad_Tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.porscheGT3;//Muda a imagem de fundo apertando o botão tema2
        }

        private void rad_Tema3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.porshe918;//Muda a imagem de fundo apertando o botão tema3
        }

        private void btn_Nome_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Nome.Text;//Recebe o nome digitado e mostra na tela
        }

        private void btn_Sobrenome_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Sobrenome.Text;//Recebe o Sobrenome digitado e mostra na tela
        }

        private void btn_Idade_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_idade.Text;//Recebe a idade digitada e mostra na tela
        }

        private void btn_Bairro_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Bairro.Text;//Recebe o Bairro digitado e mostra na tela
        }

        private void lbl_Celular_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Celular_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Celular.Text;//Recebe o Celular digitado e mostra na tela
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = txt_Email.Text;//Recebe o Email digitado e mostra na tela
        }

        private void btn_Ativar_Click(object sender, EventArgs e)
        {
            btn_Desativar.Enabled = true; //Ativa o botão destivar
            btn_Limpar.Enabled = true; //Ativa o botão Limpar
            btn_Nome.Enabled = true; //Ativa o botão Nome
            btn_Sobrenome.Enabled = true; //Ativa o botão Sobrenome
            btn_Idade.Enabled = true; //Ativa o botão Idade
            btn_Bairro.Enabled = true; //Ativa o botão Bairro
            btn_Celular.Enabled = true; //Ativa o botão Celular
            btn_Email.Enabled = true; //Ativa o botão Email
            btn_DadosCompleto.Enabled = true; //Ativa o botão Dados Completo
            Btn_Enviar.Enabled = true; //Ativa o botão Enviar
            rad_Tema1.Enabled = true; // Ativa o RadioButton Tema1
            rad_Tema2.Enabled = true; // Ativa o RadioButton Tema2
            rad_Tema3.Enabled = true; // Ativa o RadioButton Tema3
        }

        private void btn_Desativar_Click(object sender, EventArgs e)
        {
            btn_Desativar.Enabled = false; //Desativa o botão destivar
            btn_Limpar.Enabled = false; //Desativa o botão Limpar
            btn_Nome.Enabled = false; //Desativa o botão Nome
            btn_Sobrenome.Enabled = false; //Desativa o botão Sobrenome
            btn_Idade.Enabled = false; //Desativa o botão Idade
            btn_Bairro.Enabled = false; //Desativa o botão Bairro
            btn_Celular.Enabled = false; //Desativa o botão Celular
            btn_Email.Enabled = false; //Desativa o botão Email
            btn_DadosCompleto.Enabled = false; //Desativa o botão Dados Completos
            Btn_Enviar.Enabled = false; //Desativa o botão Enviar
            rad_Tema1.Enabled = false; // Desativa o RadioButton Tema1
            rad_Tema2.Enabled = false; // Desativa o RadioButton Tema2
            rad_Tema3.Enabled = false; // Desativa o RadioButton Tema3
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Nome.Clear(); //Apaga o Nome escrito na caixa de texto
            txt_Sobrenome.Clear(); //Apaga o Sobrenome escrito na caixa de texto
            txt_idade.Clear(); //Apaga o Idade escrito na caixa de texto
            txt_Bairro.Clear(); //Apaga o Bairro escrito na caixa de texto
            txt_Celular.Clear(); //Apaga o Celular escrito na caixa de texto
            txt_Email.Clear(); //Apaga o Email escrito na caixa de texto
            lbl_Resultado.Text = ""; //Apaga as informações
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cadastro concluido com sucesso",
                "Concluido!!!",
                MessageBoxButtons.OK
                );
        }
    }
}
