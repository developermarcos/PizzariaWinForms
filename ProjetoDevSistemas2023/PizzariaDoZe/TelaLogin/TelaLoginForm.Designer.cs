namespace PizzariaDoZe.TelaLogin
{
    partial class TelaLoginForm
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
            lbUsuario = new Label();
            lbSenha = new Label();
            usuario = new TextBox();
            senha = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lbPizzariaNome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(21, 43);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(29, 87);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha";
            // 
            // usuario
            // 
            usuario.Location = new Point(74, 40);
            usuario.Name = "usuario";
            usuario.Size = new Size(193, 23);
            usuario.TabIndex = 2;
            // 
            // senha
            // 
            senha.Location = new Point(74, 84);
            senha.Name = "senha";
            senha.Size = new Size(193, 23);
            senha.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.DialogResult = DialogResult.OK;
            btnLogin.Image = Properties.Resources.login_;
            btnLogin.Location = new Point(176, 128);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(91, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbUsuario);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(usuario);
            panel1.Controls.Add(senha);
            panel1.Controls.Add(lbSenha);
            panel1.Location = new Point(255, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 200);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 110);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 5;
            label1.Text = "usuario e senha = marcos";
            // 
            // lbPizzariaNome
            // 
            lbPizzariaNome.AutoSize = true;
            lbPizzariaNome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbPizzariaNome.Location = new Point(147, 77);
            lbPizzariaNome.Name = "lbPizzariaNome";
            lbPizzariaNome.Size = new Size(528, 40);
            lbPizzariaNome.TabIndex = 6;
            lbPizzariaNome.Text = "Pizzaria Desenvolvimento de Sistema";
            // 
            // TelaLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPizzariaNome);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private Label lbSenha;
        private TextBox usuario;
        private TextBox senha;
        private Button btnLogin;
        private Panel panel1;
        private Label lbPizzariaNome;
        private Label label1;
    }
}