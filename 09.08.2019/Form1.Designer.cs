namespace _09._08._2019
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
            this.CURSO = new System.Windows.Forms.ListBox();
            this.DISCIPLINA = new System.Windows.Forms.ListBox();
            this.bntincert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbdbDataSet2 = new _09._08._2019.TbdbDataSet2();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTableAdapter = new _09._08._2019.TbdbDataSet2TableAdapters.GradeTableAdapter();
            this.códigoCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CURSO
            // 
            this.CURSO.FormattingEnabled = true;
            this.CURSO.Location = new System.Drawing.Point(28, 91);
            this.CURSO.Name = "CURSO";
            this.CURSO.Size = new System.Drawing.Size(137, 277);
            this.CURSO.TabIndex = 0;
            // 
            // DISCIPLINA
            // 
            this.DISCIPLINA.FormattingEnabled = true;
            this.DISCIPLINA.Location = new System.Drawing.Point(264, 91);
            this.DISCIPLINA.Name = "DISCIPLINA";
            this.DISCIPLINA.Size = new System.Drawing.Size(127, 277);
            this.DISCIPLINA.TabIndex = 1;
            // 
            // bntincert
            // 
            this.bntincert.Location = new System.Drawing.Point(652, 330);
            this.bntincert.Name = "bntincert";
            this.bntincert.Size = new System.Drawing.Size(102, 38);
            this.bntincert.TabIndex = 2;
            this.bntincert.Text = "Incerir";
            this.bntincert.UseVisualStyleBackColor = true;
            this.bntincert.Click += new System.EventHandler(this.Bntincert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoCursoDataGridViewTextBoxColumn,
            this.códigoDisciplinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(422, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 165);
            this.dataGridView1.TabIndex = 3;
            // 
            // tbdbDataSet2
            // 
            this.tbdbDataSet2.DataSetName = "TbdbDataSet2";
            this.tbdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "Grade";
            this.gradeBindingSource.DataSource = this.tbdbDataSet2;
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // códigoCursoDataGridViewTextBoxColumn
            // 
            this.códigoCursoDataGridViewTextBoxColumn.DataPropertyName = "CódigoCurso";
            this.códigoCursoDataGridViewTextBoxColumn.HeaderText = "CódigoCurso";
            this.códigoCursoDataGridViewTextBoxColumn.Name = "códigoCursoDataGridViewTextBoxColumn";
            // 
            // códigoDisciplinaDataGridViewTextBoxColumn
            // 
            this.códigoDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "CódigoDisciplina";
            this.códigoDisciplinaDataGridViewTextBoxColumn.HeaderText = "CódigoDisciplina";
            this.códigoDisciplinaDataGridViewTextBoxColumn.Name = "códigoDisciplinaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntincert);
            this.Controls.Add(this.DISCIPLINA);
            this.Controls.Add(this.CURSO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CURSO;
        private System.Windows.Forms.ListBox DISCIPLINA;
        private System.Windows.Forms.Button bntincert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TbdbDataSet2 tbdbDataSet2;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private TbdbDataSet2TableAdapters.GradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDisciplinaDataGridViewTextBoxColumn;
    }
}

