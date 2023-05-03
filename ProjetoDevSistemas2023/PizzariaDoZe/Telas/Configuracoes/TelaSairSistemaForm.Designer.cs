namespace PizzariaDoZe.Telas.Configuracoes
{
    partial class TelaSairSistemaForm
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
            btnSair = new Button();
            btnCancelar = new Button();
            btnBandeja = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(16, 22);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(91, 35);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair--";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(113, 22);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar--";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBandeja
            // 
            btnBandeja.Location = new Point(210, 22);
            btnBandeja.Name = "btnBandeja";
            btnBandeja.Size = new Size(91, 35);
            btnBandeja.TabIndex = 2;
            btnBandeja.Text = "Bandeja--";
            btnBandeja.UseVisualStyleBackColor = true;
            btnBandeja.Click += btnBandeja_Click;
            // 
            // TelaSairSistemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 76);
            Controls.Add(btnBandeja);
            Controls.Add(btnCancelar);
            Controls.Add(btnSair);
            Name = "TelaSairSistemaForm";
            Text = "TelaSairSistemaForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private Button btnCancelar;
        private Button btnBandeja;
    }
}