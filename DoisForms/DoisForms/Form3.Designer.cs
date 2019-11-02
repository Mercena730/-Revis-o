namespace DoisForms
{
    partial class frmCopia
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
            this.txtCopia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCopia
            // 
            this.txtCopia.Location = new System.Drawing.Point(44, 48);
            this.txtCopia.Name = "txtCopia";
            this.txtCopia.Size = new System.Drawing.Size(147, 20);
            this.txtCopia.TabIndex = 0;
            // 
            // frmCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 148);
            this.Controls.Add(this.txtCopia);
            this.Name = "frmCopia";
            this.Text = "Cópia";
            this.Load += new System.EventHandler(this.FrmCopia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopia;
    }
}