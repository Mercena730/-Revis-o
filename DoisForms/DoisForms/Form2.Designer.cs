namespace DoisForms
{
    partial class frmDestino
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
            this.btnAlterarOrigem = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAlterarOrigem
            // 
            this.btnAlterarOrigem.Location = new System.Drawing.Point(46, 94);
            this.btnAlterarOrigem.Name = "btnAlterarOrigem";
            this.btnAlterarOrigem.Size = new System.Drawing.Size(104, 23);
            this.btnAlterarOrigem.TabIndex = 0;
            this.btnAlterarOrigem.Text = "Alterar Origem";
            this.btnAlterarOrigem.UseVisualStyleBackColor = true;
            this.btnAlterarOrigem.Click += new System.EventHandler(this.BtnAlterarOrigem_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(46, 59);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(167, 20);
            this.txtDestino.TabIndex = 1;
            this.txtDestino.TextChanged += new System.EventHandler(this.TxtDestino_TextChanged);
            // 
            // frmDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 223);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnAlterarOrigem);
            this.Name = "frmDestino";
            this.Text = "Destino";
            this.Load += new System.EventHandler(this.FrmDestino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarOrigem;
        public System.Windows.Forms.TextBox txtDestino;
    }
}