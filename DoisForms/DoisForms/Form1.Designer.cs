namespace DoisForms
{
    partial class frmOrigem
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
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.btnAbrirDestino = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(63, 121);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(244, 20);
            this.txtOrigem.TabIndex = 0;
            // 
            // btnAbrirDestino
            // 
            this.btnAbrirDestino.Location = new System.Drawing.Point(313, 119);
            this.btnAbrirDestino.Name = "btnAbrirDestino";
            this.btnAbrirDestino.Size = new System.Drawing.Size(100, 23);
            this.btnAbrirDestino.TabIndex = 1;
            this.btnAbrirDestino.Text = "Abrir Destino";
            this.btnAbrirDestino.UseVisualStyleBackColor = true;
            this.btnAbrirDestino.Click += new System.EventHandler(this.BtnAbrirDestino_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(61, 27);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(180, 20);
            this.txtTexto.TabIndex = 2;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(247, 24);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmOrigem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnAbrirDestino);
            this.Controls.Add(this.txtOrigem);
            this.Name = "frmOrigem";
            this.Text = "Origem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAbrirDestino;
        public System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button button1;
    }
}

