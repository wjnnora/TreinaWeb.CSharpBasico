namespace EstudandoIfElse
{
    partial class frmIfElse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.btnVerificarIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a idade desejada:";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(133, 19);
            this.txbIdade.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(192, 20);
            this.txbIdade.TabIndex = 1;
            // 
            // btnVerificarIdade
            // 
            this.btnVerificarIdade.Location = new System.Drawing.Point(347, 15);
            this.btnVerificarIdade.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnVerificarIdade.Name = "btnVerificarIdade";
            this.btnVerificarIdade.Size = new System.Drawing.Size(61, 26);
            this.btnVerificarIdade.TabIndex = 2;
            this.btnVerificarIdade.Text = "Verificar";
            this.btnVerificarIdade.UseVisualStyleBackColor = true;
            this.btnVerificarIdade.Click += new System.EventHandler(this.BtnVerificarIdade_Click);
            // 
            // frmIfElse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 56);
            this.Controls.Add(this.btnVerificarIdade);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmIfElse";
            this.Text = "Estudo - IF/Else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Button btnVerificarIdade;
    }
}

