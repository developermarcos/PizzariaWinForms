namespace PizzariaDoZe.Configuracoes.TelaIdioma
{
    partial class UserControlIdioma
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            selecionarIdioma = new GroupBox();
            espanhol = new RadioButton();
            ingles = new RadioButton();
            portugues = new RadioButton();
            panelAcoes = new Panel();
            btnSalvar = new Button();
            selecionarIdioma.SuspendLayout();
            panelAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // selecionarIdioma
            // 
            selecionarIdioma.Controls.Add(espanhol);
            selecionarIdioma.Controls.Add(ingles);
            selecionarIdioma.Controls.Add(portugues);
            selecionarIdioma.Location = new Point(14, 16);
            selecionarIdioma.Name = "selecionarIdioma";
            selecionarIdioma.Size = new Size(259, 62);
            selecionarIdioma.TabIndex = 0;
            selecionarIdioma.TabStop = false;
            selecionarIdioma.Text = "Selecionar Idioma--";
            // 
            // espanhol
            // 
            espanhol.AutoSize = true;
            espanhol.Location = new Point(173, 26);
            espanhol.Name = "espanhol";
            espanhol.Size = new Size(83, 19);
            espanhol.TabIndex = 3;
            espanhol.TabStop = true;
            espanhol.Text = "Espanhol--";
            espanhol.UseVisualStyleBackColor = true;
            // 
            // ingles
            // 
            ingles.AutoSize = true;
            ingles.Location = new Point(101, 26);
            ingles.Name = "ingles";
            ingles.Size = new Size(66, 19);
            ingles.TabIndex = 2;
            ingles.TabStop = true;
            ingles.Text = "Inglês--";
            ingles.UseVisualStyleBackColor = true;
            // 
            // portugues
            // 
            portugues.AutoSize = true;
            portugues.Location = new Point(6, 26);
            portugues.Name = "portugues";
            portugues.Size = new Size(89, 19);
            portugues.TabIndex = 1;
            portugues.TabStop = true;
            portugues.Text = "Português--";
            portugues.UseVisualStyleBackColor = true;
            // 
            // panelAcoes
            // 
            panelAcoes.Controls.Add(btnSalvar);
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 97);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(288, 74);
            panelAcoes.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Image = Properties.Resources.disk;
            btnSalvar.Location = new Point(20, 19);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 35);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar--";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // UserControlIdioma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAcoes);
            Controls.Add(selecionarIdioma);
            Name = "UserControlIdioma";
            Size = new Size(288, 171);
            selecionarIdioma.ResumeLayout(false);
            selecionarIdioma.PerformLayout();
            panelAcoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox selecionarIdioma;
        private RadioButton espanhol;
        private RadioButton ingles;
        private RadioButton portugues;
        private Panel panelAcoes;
        public Button btnSalvar;
    }
}
