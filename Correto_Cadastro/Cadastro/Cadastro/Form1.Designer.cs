namespace Cadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Sobrenome = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_ConfDados = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Nome = new System.Windows.Forms.Button();
            this.btn_Sobrenome = new System.Windows.Forms.Button();
            this.btn_Idade = new System.Windows.Forms.Button();
            this.btn_Bairro = new System.Windows.Forms.Button();
            this.btn_Celular = new System.Windows.Forms.Button();
            this.btn_DadosCompleto = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.Grp_Temas = new System.Windows.Forms.GroupBox();
            this.rad_Tema3 = new System.Windows.Forms.RadioButton();
            this.rad_Tema2 = new System.Windows.Forms.RadioButton();
            this.rad_Tema1 = new System.Windows.Forms.RadioButton();
            this.btn_Ativar = new System.Windows.Forms.Button();
            this.btn_Desativar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Grp_Temas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(353, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados Pessoais";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_Nome.Location = new System.Drawing.Point(12, 193);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(68, 25);
            this.Lbl_Nome.TabIndex = 1;
            this.Lbl_Nome.Text = "Nome";
            // 
            // lbl_Sobrenome
            // 
            this.lbl_Sobrenome.AutoSize = true;
            this.lbl_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Sobrenome.Location = new System.Drawing.Point(12, 231);
            this.lbl_Sobrenome.Name = "lbl_Sobrenome";
            this.lbl_Sobrenome.Size = new System.Drawing.Size(123, 25);
            this.lbl_Sobrenome.TabIndex = 2;
            this.lbl_Sobrenome.Text = "Sobrenome";
            this.lbl_Sobrenome.Click += new System.EventHandler(this.lbl_Sobrenome_Click);
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Idade.Location = new System.Drawing.Point(12, 268);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(66, 25);
            this.lbl_Idade.TabIndex = 3;
            this.lbl_Idade.Text = "Idade";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Bairro.Location = new System.Drawing.Point(12, 305);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(69, 25);
            this.lbl_Bairro.TabIndex = 4;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Celular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Celular.Location = new System.Drawing.Point(12, 341);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(81, 25);
            this.lbl_Celular.TabIndex = 5;
            this.lbl_Celular.Text = "Celular";
            this.lbl_Celular.Click += new System.EventHandler(this.lbl_Celular_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Email.Location = new System.Drawing.Point(12, 373);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(65, 25);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_ConfDados
            // 
            this.lbl_ConfDados.AutoSize = true;
            this.lbl_ConfDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfDados.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_ConfDados.Location = new System.Drawing.Point(7, 437);
            this.lbl_ConfDados.Name = "lbl_ConfDados";
            this.lbl_ConfDados.Size = new System.Drawing.Size(239, 25);
            this.lbl_ConfDados.TabIndex = 7;
            this.lbl_ConfDados.Text = "Configuração de Dados";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(87, 198);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(168, 20);
            this.txt_Nome.TabIndex = 9;
            // 
            // txt_Sobrenome
            // 
            this.txt_Sobrenome.Location = new System.Drawing.Point(141, 236);
            this.txt_Sobrenome.Name = "txt_Sobrenome";
            this.txt_Sobrenome.Size = new System.Drawing.Size(228, 20);
            this.txt_Sobrenome.TabIndex = 10;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(89, 274);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(35, 20);
            this.txt_idade.TabIndex = 11;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(89, 310);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(266, 20);
            this.txt_Bairro.TabIndex = 12;
            // 
            // txt_Celular
            // 
            this.txt_Celular.Location = new System.Drawing.Point(96, 347);
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(161, 20);
            this.txt_Celular.TabIndex = 13;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(87, 379);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(330, 20);
            this.txt_Email.TabIndex = 14;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // btn_Nome
            // 
            this.btn_Nome.Enabled = false;
            this.btn_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nome.Location = new System.Drawing.Point(526, 182);
            this.btn_Nome.Name = "btn_Nome";
            this.btn_Nome.Size = new System.Drawing.Size(155, 36);
            this.btn_Nome.TabIndex = 15;
            this.btn_Nome.Text = "Nome";
            this.btn_Nome.UseVisualStyleBackColor = true;
            this.btn_Nome.Click += new System.EventHandler(this.btn_Nome_Click);
            // 
            // btn_Sobrenome
            // 
            this.btn_Sobrenome.Enabled = false;
            this.btn_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sobrenome.Location = new System.Drawing.Point(517, 220);
            this.btn_Sobrenome.Name = "btn_Sobrenome";
            this.btn_Sobrenome.Size = new System.Drawing.Size(164, 36);
            this.btn_Sobrenome.TabIndex = 16;
            this.btn_Sobrenome.Text = "Sobrenome";
            this.btn_Sobrenome.UseVisualStyleBackColor = true;
            this.btn_Sobrenome.Click += new System.EventHandler(this.btn_Sobrenome_Click);
            // 
            // btn_Idade
            // 
            this.btn_Idade.Enabled = false;
            this.btn_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Idade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Idade.Location = new System.Drawing.Point(526, 258);
            this.btn_Idade.Name = "btn_Idade";
            this.btn_Idade.Size = new System.Drawing.Size(155, 36);
            this.btn_Idade.TabIndex = 17;
            this.btn_Idade.Text = "Idade";
            this.btn_Idade.UseVisualStyleBackColor = true;
            this.btn_Idade.Click += new System.EventHandler(this.btn_Idade_Click);
            // 
            // btn_Bairro
            // 
            this.btn_Bairro.Enabled = false;
            this.btn_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Bairro.Location = new System.Drawing.Point(526, 294);
            this.btn_Bairro.Name = "btn_Bairro";
            this.btn_Bairro.Size = new System.Drawing.Size(155, 36);
            this.btn_Bairro.TabIndex = 18;
            this.btn_Bairro.Text = "Bairro";
            this.btn_Bairro.UseVisualStyleBackColor = true;
            this.btn_Bairro.Click += new System.EventHandler(this.btn_Bairro_Click);
            // 
            // btn_Celular
            // 
            this.btn_Celular.Enabled = false;
            this.btn_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Celular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Celular.Location = new System.Drawing.Point(526, 331);
            this.btn_Celular.Name = "btn_Celular";
            this.btn_Celular.Size = new System.Drawing.Size(155, 36);
            this.btn_Celular.TabIndex = 19;
            this.btn_Celular.Text = "Celular";
            this.btn_Celular.UseVisualStyleBackColor = true;
            this.btn_Celular.Click += new System.EventHandler(this.btn_Celular_Click);
            // 
            // btn_DadosCompleto
            // 
            this.btn_DadosCompleto.Enabled = false;
            this.btn_DadosCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DadosCompleto.ForeColor = System.Drawing.Color.Red;
            this.btn_DadosCompleto.Location = new System.Drawing.Point(526, 437);
            this.btn_DadosCompleto.Name = "btn_DadosCompleto";
            this.btn_DadosCompleto.Size = new System.Drawing.Size(155, 65);
            this.btn_DadosCompleto.TabIndex = 20;
            this.btn_DadosCompleto.Text = "Dados\r\nCompleto\r\n";
            this.btn_DadosCompleto.UseVisualStyleBackColor = true;
            this.btn_DadosCompleto.Click += new System.EventHandler(this.btn_DadosCompleto_Click);
            // 
            // btn_Email
            // 
            this.btn_Email.Enabled = false;
            this.btn_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Email.Location = new System.Drawing.Point(526, 369);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(155, 36);
            this.btn_Email.TabIndex = 21;
            this.btn_Email.Text = "Email";
            this.btn_Email.UseVisualStyleBackColor = true;
            this.btn_Email.Click += new System.EventHandler(this.btn_Email_Click);
            // 
            // Grp_Temas
            // 
            this.Grp_Temas.BackColor = System.Drawing.Color.White;
            this.Grp_Temas.Controls.Add(this.rad_Tema3);
            this.Grp_Temas.Controls.Add(this.rad_Tema2);
            this.Grp_Temas.Controls.Add(this.rad_Tema1);
            this.Grp_Temas.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Temas.Location = new System.Drawing.Point(598, 12);
            this.Grp_Temas.Name = "Grp_Temas";
            this.Grp_Temas.Size = new System.Drawing.Size(352, 58);
            this.Grp_Temas.TabIndex = 22;
            this.Grp_Temas.TabStop = false;
            this.Grp_Temas.Text = "Temas:";
            // 
            // rad_Tema3
            // 
            this.rad_Tema3.AutoSize = true;
            this.rad_Tema3.Enabled = false;
            this.rad_Tema3.Location = new System.Drawing.Point(273, 28);
            this.rad_Tema3.Name = "rad_Tema3";
            this.rad_Tema3.Size = new System.Drawing.Size(59, 20);
            this.rad_Tema3.TabIndex = 2;
            this.rad_Tema3.TabStop = true;
            this.rad_Tema3.Text = "Tema3";
            this.rad_Tema3.UseVisualStyleBackColor = true;
            this.rad_Tema3.CheckedChanged += new System.EventHandler(this.rad_Tema3_CheckedChanged);
            // 
            // rad_Tema2
            // 
            this.rad_Tema2.AutoSize = true;
            this.rad_Tema2.Enabled = false;
            this.rad_Tema2.Location = new System.Drawing.Point(139, 29);
            this.rad_Tema2.Name = "rad_Tema2";
            this.rad_Tema2.Size = new System.Drawing.Size(59, 20);
            this.rad_Tema2.TabIndex = 1;
            this.rad_Tema2.TabStop = true;
            this.rad_Tema2.Text = "Tema2";
            this.rad_Tema2.UseVisualStyleBackColor = true;
            this.rad_Tema2.CheckedChanged += new System.EventHandler(this.rad_Tema2_CheckedChanged);
            // 
            // rad_Tema1
            // 
            this.rad_Tema1.AutoSize = true;
            this.rad_Tema1.Enabled = false;
            this.rad_Tema1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Tema1.ForeColor = System.Drawing.Color.Black;
            this.rad_Tema1.Location = new System.Drawing.Point(15, 28);
            this.rad_Tema1.Name = "rad_Tema1";
            this.rad_Tema1.Size = new System.Drawing.Size(56, 20);
            this.rad_Tema1.TabIndex = 0;
            this.rad_Tema1.TabStop = true;
            this.rad_Tema1.Text = "Tema1";
            this.rad_Tema1.UseVisualStyleBackColor = true;
            this.rad_Tema1.CheckedChanged += new System.EventHandler(this.rad_Tema1_CheckedChanged);
            // 
            // btn_Ativar
            // 
            this.btn_Ativar.BackColor = System.Drawing.Color.White;
            this.btn_Ativar.Location = new System.Drawing.Point(12, 26);
            this.btn_Ativar.Name = "btn_Ativar";
            this.btn_Ativar.Size = new System.Drawing.Size(100, 44);
            this.btn_Ativar.TabIndex = 23;
            this.btn_Ativar.Text = "Ativar";
            this.btn_Ativar.UseVisualStyleBackColor = false;
            this.btn_Ativar.Click += new System.EventHandler(this.btn_Ativar_Click);
            // 
            // btn_Desativar
            // 
            this.btn_Desativar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Desativar.Enabled = false;
            this.btn_Desativar.Location = new System.Drawing.Point(120, 26);
            this.btn_Desativar.Name = "btn_Desativar";
            this.btn_Desativar.Size = new System.Drawing.Size(100, 45);
            this.btn_Desativar.TabIndex = 24;
            this.btn_Desativar.Text = "Desativar";
            this.btn_Desativar.UseVisualStyleBackColor = false;
            this.btn_Desativar.Click += new System.EventHandler(this.btn_Desativar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Limpar.Enabled = false;
            this.btn_Limpar.Location = new System.Drawing.Point(226, 27);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(96, 44);
            this.btn_Limpar.TabIndex = 25;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_Resultado.Location = new System.Drawing.Point(760, 294);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(190, 31);
            this.lbl_Resultado.TabIndex = 26;
            this.lbl_Resultado.Text = "RESULTADO";
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Enviar.Enabled = false;
            this.Btn_Enviar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.ForeColor = System.Drawing.Color.Red;
            this.Btn_Enviar.Location = new System.Drawing.Point(834, 575);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(185, 58);
            this.Btn_Enviar.TabIndex = 27;
            this.Btn_Enviar.Text = "ENVIAR";
            this.Btn_Enviar.UseVisualStyleBackColor = false;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cadastro.Properties.Resources.civic_g10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 645);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Desativar);
            this.Controls.Add(this.btn_Ativar);
            this.Controls.Add(this.Grp_Temas);
            this.Controls.Add(this.btn_Email);
            this.Controls.Add(this.btn_DadosCompleto);
            this.Controls.Add(this.btn_Celular);
            this.Controls.Add(this.btn_Bairro);
            this.Controls.Add(this.btn_Idade);
            this.Controls.Add(this.btn_Sobrenome);
            this.Controls.Add(this.btn_Nome);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_Sobrenome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_ConfDados);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Celular);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.lbl_Sobrenome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Frm_ITexto_Load);
            this.Grp_Temas.ResumeLayout(false);
            this.Grp_Temas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label lbl_Sobrenome;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_ConfDados;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Sobrenome;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Celular;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Nome;
        private System.Windows.Forms.Button btn_Sobrenome;
        private System.Windows.Forms.Button btn_Idade;
        private System.Windows.Forms.Button btn_Bairro;
        private System.Windows.Forms.Button btn_Celular;
        private System.Windows.Forms.Button btn_DadosCompleto;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.GroupBox Grp_Temas;
        private System.Windows.Forms.RadioButton rad_Tema3;
        private System.Windows.Forms.RadioButton rad_Tema2;
        private System.Windows.Forms.RadioButton rad_Tema1;
        private System.Windows.Forms.Button btn_Ativar;
        private System.Windows.Forms.Button btn_Desativar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Btn_Enviar;
    }
}

