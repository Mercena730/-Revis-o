namespace trabalhograde
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.lbsgrade = new System.Windows.Forms.ListBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.txtmat = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblcurso = new System.Windows.Forms.Label();
            this.lblmateria = new System.Windows.Forms.Label();
            this.bntIncerir = new System.Windows.Forms.Button();
            this.dbEscolaDataSet = new trabalhograde.DbEscolaDataSet();
            this.tbGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGradeTableAdapter = new trabalhograde.DbEscolaDataSetTableAdapters.tbGradeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbEscolaDataSet1 = new trabalhograde.DbEscolaDataSet1();
            this.tbGradeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbGradeTableAdapter1 = new trabalhograde.DbEscolaDataSet1TableAdapters.tbGradeTableAdapter();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbEscolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEscolaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCursos
            // 
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(12, 74);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(185, 21);
            this.cboCursos.TabIndex = 0;
            this.cboCursos.SelectedIndexChanged += new System.EventHandler(this.CboCursos_SelectedIndexChanged);
            // 
            // lbsgrade
            // 
            this.lbsgrade.FormattingEnabled = true;
            this.lbsgrade.Location = new System.Drawing.Point(12, 101);
            this.lbsgrade.Name = "lbsgrade";
            this.lbsgrade.Size = new System.Drawing.Size(185, 173);
            this.lbsgrade.TabIndex = 2;
            this.lbsgrade.SelectedIndexChanged += new System.EventHandler(this.Lbsgrade_SelectedIndexChanged);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(256, 101);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(136, 20);
            this.txtcod.TabIndex = 3;
            // 
            // txtcurso
            // 
            this.txtcurso.Enabled = false;
            this.txtcurso.Location = new System.Drawing.Point(256, 155);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(136, 20);
            this.txtcurso.TabIndex = 4;
            this.txtcurso.TextChanged += new System.EventHandler(this.Txtcurso_TextChanged);
            // 
            // txtmat
            // 
            this.txtmat.Enabled = false;
            this.txtmat.Location = new System.Drawing.Point(256, 212);
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(136, 20);
            this.txtmat.TabIndex = 5;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(256, 82);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(90, 13);
            this.lblcodigo.TabIndex = 6;
            this.lblcodigo.Text = "Codigo Da Turma";
            this.lblcodigo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Location = new System.Drawing.Point(256, 136);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(34, 13);
            this.lblcurso.TabIndex = 7;
            this.lblcurso.Text = "Curso";
            // 
            // lblmateria
            // 
            this.lblmateria.AutoSize = true;
            this.lblmateria.Location = new System.Drawing.Point(256, 193);
            this.lblmateria.Name = "lblmateria";
            this.lblmateria.Size = new System.Drawing.Size(42, 13);
            this.lblmateria.TabIndex = 8;
            this.lblmateria.Text = "Materia";
            // 
            // bntIncerir
            // 
            this.bntIncerir.Location = new System.Drawing.Point(281, 251);
            this.bntIncerir.Name = "bntIncerir";
            this.bntIncerir.Size = new System.Drawing.Size(75, 23);
            this.bntIncerir.TabIndex = 10;
            this.bntIncerir.Text = "Adicinar";
            this.bntIncerir.UseVisualStyleBackColor = true;
            this.bntIncerir.Click += new System.EventHandler(this.BntIncerir_Click);
            // 
            // dbEscolaDataSet
            // 
            this.dbEscolaDataSet.DataSetName = "DbEscolaDataSet";
            this.dbEscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbGradeBindingSource
            // 
            this.tbGradeBindingSource.DataMember = "tbGrade";
            this.tbGradeBindingSource.DataSource = this.dbEscolaDataSet;
            // 
            // tbGradeTableAdapter
            // 
            this.tbGradeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.disciplinasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbGradeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(442, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 245);
            this.dataGridView1.TabIndex = 11;
            // 
            // dbEscolaDataSet1
            // 
            this.dbEscolaDataSet1.DataSetName = "DbEscolaDataSet1";
            this.dbEscolaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbGradeBindingSource1
            // 
            this.tbGradeBindingSource1.DataMember = "tbGrade";
            this.tbGradeBindingSource1.DataSource = this.dbEscolaDataSet1;
            // 
            // tbGradeTableAdapter1
            // 
            this.tbGradeTableAdapter1.ClearBeforeFill = true;
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // disciplinasDataGridViewTextBoxColumn
            // 
            this.disciplinasDataGridViewTextBoxColumn.DataPropertyName = "Disciplinas";
            this.disciplinasDataGridViewTextBoxColumn.HeaderText = "Disciplinas";
            this.disciplinasDataGridViewTextBoxColumn.Name = "disciplinasDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntIncerir);
            this.Controls.Add(this.lblmateria);
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtmat);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lbsgrade);
            this.Controls.Add(this.cboCursos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEscolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEscolaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.ListBox lbsgrade;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.Label lblmateria;
        private System.Windows.Forms.Button bntIncerir;
        private DbEscolaDataSet dbEscolaDataSet;
        private System.Windows.Forms.BindingSource tbGradeBindingSource;
        private DbEscolaDataSetTableAdapters.tbGradeTableAdapter tbGradeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbEscolaDataSet1 dbEscolaDataSet1;
        private System.Windows.Forms.BindingSource tbGradeBindingSource1;
        private DbEscolaDataSet1TableAdapters.tbGradeTableAdapter tbGradeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinasDataGridViewTextBoxColumn;
    }
}

