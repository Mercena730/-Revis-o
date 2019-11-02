namespace ListBoxes
{
    partial class frmPrincipal
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
            this.lstOrigem = new System.Windows.Forms.ListBox();
            this.lstDestino = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtAuxiliar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstOrigem
            // 
            this.lstOrigem.FormattingEnabled = true;
            this.lstOrigem.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "Canadá",
            "Dinamarca",
            "Equador",
            "Finlândia",
            "Geórgia",
            "Haiti",
            "Itália",
            "Jamaica",
            "Kwait",
            "Lituãnia",
            "México",
            "Nicarágua",
            "Omã",
            "Peru",
            "Quênia",
            "Romênia",
            "Suécia",
            "Tanzânia",
            "Uruguai",
            "Vaticano",
            "Zimbabue"});
            this.lstOrigem.Location = new System.Drawing.Point(45, 12);
            this.lstOrigem.Name = "lstOrigem";
            this.lstOrigem.Size = new System.Drawing.Size(120, 303);
            this.lstOrigem.TabIndex = 0;
            this.lstOrigem.Click += new System.EventHandler(this.LstOrigem_Click);
            // 
            // lstDestino
            // 
            this.lstDestino.FormattingEnabled = true;
            this.lstDestino.Location = new System.Drawing.Point(353, 10);
            this.lstDestino.Name = "lstDestino";
            this.lstDestino.Size = new System.Drawing.Size(120, 303);
            this.lstDestino.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(218, 124);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = ">>";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(218, 153);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "<<";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // txtAuxiliar
            // 
            this.txtAuxiliar.Location = new System.Drawing.Point(218, 225);
            this.txtAuxiliar.Name = "txtAuxiliar";
            this.txtAuxiliar.Size = new System.Drawing.Size(100, 20);
            this.txtAuxiliar.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 322);
            this.Controls.Add(this.txtAuxiliar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lstDestino);
            this.Controls.Add(this.lstOrigem);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrigem;
        private System.Windows.Forms.ListBox lstDestino;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtAuxiliar;
    }
}

