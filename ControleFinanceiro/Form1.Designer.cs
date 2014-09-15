namespace ControleFinanceiro
{
    partial class frmMain
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
            this.btnOrcamento = new System.Windows.Forms.Button();
            this.btnLancamento = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAnalise = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrcamento
            // 
            this.btnOrcamento.Location = new System.Drawing.Point(12, 12);
            this.btnOrcamento.Name = "btnOrcamento";
            this.btnOrcamento.Size = new System.Drawing.Size(129, 57);
            this.btnOrcamento.TabIndex = 0;
            this.btnOrcamento.Text = "Orçamento";
            this.btnOrcamento.UseVisualStyleBackColor = true;
            this.btnOrcamento.Click += new System.EventHandler(this.btnOrcamento_Click);
            // 
            // btnLancamento
            // 
            this.btnLancamento.Location = new System.Drawing.Point(147, 12);
            this.btnLancamento.Name = "btnLancamento";
            this.btnLancamento.Size = new System.Drawing.Size(129, 57);
            this.btnLancamento.TabIndex = 1;
            this.btnLancamento.Text = "Lançamentos";
            this.btnLancamento.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(12, 75);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(129, 57);
            this.btnRelatorio.TabIndex = 2;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnAnalise
            // 
            this.btnAnalise.Location = new System.Drawing.Point(147, 75);
            this.btnAnalise.Name = "btnAnalise";
            this.btnAnalise.Size = new System.Drawing.Size(129, 57);
            this.btnAnalise.TabIndex = 3;
            this.btnAnalise.Text = "Análises";
            this.btnAnalise.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(187, 141);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(49, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAnalise);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnLancamento);
            this.Controls.Add(this.btnOrcamento);
            this.Name = "frmMain";
            this.Text = "Controle Financeiro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrcamento;
        private System.Windows.Forms.Button btnLancamento;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnAnalise;
        private System.Windows.Forms.Button btnSair;
    }
}

