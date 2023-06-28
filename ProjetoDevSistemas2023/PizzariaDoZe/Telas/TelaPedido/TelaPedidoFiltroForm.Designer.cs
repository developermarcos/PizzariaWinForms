namespace PizzariaDoZe.Telas.TelaPedido
{
    partial class TelaPedidoFiltroForm
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
            label1 = new Label();
            filtro = new ComboBox();
            panelAcoes = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "TipoFiltro";
            // 
            // filtro
            // 
            filtro.DropDownStyle = ComboBoxStyle.DropDownList;
            filtro.FormattingEnabled = true;
            filtro.Location = new Point(12, 27);
            filtro.Name = "filtro";
            filtro.Size = new Size(179, 23);
            filtro.TabIndex = 1;
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 79);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(208, 67);
            panelAcoes.TabIndex = 2;
            // 
            // TelaPedidoFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 146);
            Controls.Add(panelAcoes);
            Controls.Add(filtro);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPedidoFiltroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPedidoFiltroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox filtro;
        private Panel panelAcoes;
    }
}