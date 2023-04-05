namespace PizzariaDoZe.Compartilhado.UserControlComponentes
{
    partial class UserControlSalvarCancelar
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Image = Properties.Resources.disk;
            btnSalvar.Location = new Point(21, 14);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 35);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar--";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Image = Properties.Resources.cancel;
            btnCancelar.Location = new Point(112, 14);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar--";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // UserControlSalvarCancelar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "UserControlSalvarCancelar";
            Size = new Size(222, 63);
            ResumeLayout(false);
        }

        #endregion

        public Button btnSalvar;
        public Button btnCancelar;
    }
}
