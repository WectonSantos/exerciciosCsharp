namespace tp08_wecton_228550
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtNome = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msk1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskSerie = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskMatricula = new System.Windows.Forms.MaskedTextBox();
            this.msk2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msk3 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk4 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PROCURAR = new System.Windows.Forms.Label();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProcura = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtProcura = new System.Windows.Forms.MaskedTextBox();
            this.dsEscola = new System.Data.DataSet();
            this.Escola = new System.Data.DataTable();
            this.nome = new System.Data.DataColumn();
            this.matricula = new System.Data.DataColumn();
            this.serie = new System.Data.DataColumn();
            this.nota1 = new System.Data.DataColumn();
            this.nota2 = new System.Data.DataColumn();
            this.nota3 = new System.Data.DataColumn();
            this.nota4 = new System.Data.DataColumn();
            this.disciplina = new System.Data.DataColumn();
            this.media = new System.Data.DataColumn();
            this.situacao = new System.Data.DataColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgEscola = new System.Windows.Forms.DataGridView();
            this.bsEscola = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsEscola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Escola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEscola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Aluno:";
            // 
            // mtxtNome
            // 
            this.mtxtNome.Location = new System.Drawing.Point(101, 6);
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.Size = new System.Drawing.Size(198, 20);
            this.mtxtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1°B";
            // 
            // msk1
            // 
            this.msk1.Location = new System.Drawing.Point(37, 33);
            this.msk1.Mask = "00.00";
            this.msk1.Name = "msk1";
            this.msk1.Size = new System.Drawing.Size(35, 20);
            this.msk1.TabIndex = 4;
            this.msk1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Série";
            // 
            // mskSerie
            // 
            this.mskSerie.Location = new System.Drawing.Point(342, 6);
            this.mskSerie.Mask = "0ºA";
            this.mskSerie.Name = "mskSerie";
            this.mskSerie.Size = new System.Drawing.Size(24, 20);
            this.mskSerie.TabIndex = 6;
            this.mskSerie.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Matricula";
            // 
            // mskMatricula
            // 
            this.mskMatricula.Location = new System.Drawing.Point(428, 6);
            this.mskMatricula.Mask = "00";
            this.mskMatricula.Name = "mskMatricula";
            this.mskMatricula.Size = new System.Drawing.Size(21, 20);
            this.mskMatricula.TabIndex = 8;
            this.mskMatricula.ValidatingType = typeof(int);
            // 
            // msk2
            // 
            this.msk2.Location = new System.Drawing.Point(101, 33);
            this.msk2.Mask = "00.00";
            this.msk2.Name = "msk2";
            this.msk2.Size = new System.Drawing.Size(35, 20);
            this.msk2.TabIndex = 10;
            this.msk2.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "2°B";
            // 
            // msk3
            // 
            this.msk3.Location = new System.Drawing.Point(167, 33);
            this.msk3.Mask = "00.00";
            this.msk3.Name = "msk3";
            this.msk3.Size = new System.Drawing.Size(35, 20);
            this.msk3.TabIndex = 12;
            this.msk3.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "3°B";
            // 
            // msk4
            // 
            this.msk4.Location = new System.Drawing.Point(234, 33);
            this.msk4.Mask = "00.00";
            this.msk4.Name = "msk4";
            this.msk4.Size = new System.Drawing.Size(35, 20);
            this.msk4.TabIndex = 14;
            this.msk4.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "4°B";
            // 
            // PROCURAR
            // 
            this.PROCURAR.AutoSize = true;
            this.PROCURAR.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROCURAR.Location = new System.Drawing.Point(570, 20);
            this.PROCURAR.Name = "PROCURAR";
            this.PROCURAR.Size = new System.Drawing.Size(172, 32);
            this.PROCURAR.TabIndex = 15;
            this.PROCURAR.Text = "PROCURAR";
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Items.AddRange(new object[] {
            "Português",
            "Matemática",
            "Geografia",
            "História"});
            this.cbDisciplina.Location = new System.Drawing.Point(328, 32);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(121, 21);
            this.cbDisciplina.TabIndex = 16;
            this.cbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbDisciplina_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Disciplina";
            // 
            // cbProcura
            // 
            this.cbProcura.FormattingEnabled = true;
            this.cbProcura.Items.AddRange(new object[] {
            "Disciplina",
            "Serie",
            "Matricula"});
            this.cbProcura.Location = new System.Drawing.Point(749, 27);
            this.cbProcura.Name = "cbProcura";
            this.cbProcura.Size = new System.Drawing.Size(121, 21);
            this.cbProcura.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(785, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Filtro";
            // 
            // mtxtProcura
            // 
            this.mtxtProcura.Location = new System.Drawing.Point(881, 27);
            this.mtxtProcura.Name = "mtxtProcura";
            this.mtxtProcura.Size = new System.Drawing.Size(110, 20);
            this.mtxtProcura.TabIndex = 23;
            this.mtxtProcura.TextChanged += new System.EventHandler(this.mtxtProcura_TextChanged);
            // 
            // dsEscola
            // 
            this.dsEscola.DataSetName = "NewDataSet";
            this.dsEscola.Tables.AddRange(new System.Data.DataTable[] {
            this.Escola});
            // 
            // Escola
            // 
            this.Escola.Columns.AddRange(new System.Data.DataColumn[] {
            this.nome,
            this.matricula,
            this.serie,
            this.nota1,
            this.nota2,
            this.nota3,
            this.nota4,
            this.disciplina,
            this.media,
            this.situacao});
            this.Escola.TableName = "Alunos";
            // 
            // nome
            // 
            this.nome.ColumnName = "Nome";
            // 
            // matricula
            // 
            this.matricula.ColumnName = "Matricula";
            // 
            // serie
            // 
            this.serie.ColumnName = "Serie";
            // 
            // nota1
            // 
            this.nota1.ColumnName = "nota1";
            // 
            // nota2
            // 
            this.nota2.ColumnName = "nota2";
            // 
            // nota3
            // 
            this.nota3.ColumnName = "nota3";
            // 
            // nota4
            // 
            this.nota4.ColumnName = "nota4";
            // 
            // disciplina
            // 
            this.disciplina.ColumnName = "Disciplina";
            // 
            // media
            // 
            this.media.ColumnName = "Media";
            // 
            // situacao
            // 
            this.situacao.ColumnName = "Situacao";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(466, 6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 47);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgEscola
            // 
            this.dgEscola.AutoGenerateColumns = false;
            this.dgEscola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEscola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn,
            this.nota4DataGridViewTextBoxColumn,
            this.disciplinaDataGridViewTextBoxColumn,
            this.mediaDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn});
            this.dgEscola.DataSource = this.alunosBindingSource1;
            this.dgEscola.Location = new System.Drawing.Point(15, 68);
            this.dgEscola.Name = "dgEscola";
            this.dgEscola.ReadOnly = true;
            this.dgEscola.Size = new System.Drawing.Size(1049, 246);
            this.dgEscola.TabIndex = 27;
            this.dgEscola.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEscola_CellContentClick);
            // 
            // bsEscola
            // 
            this.bsEscola.DataSource = this.dsEscola;
            this.bsEscola.Position = 0;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.bsEscola;
            // 
            // alunosBindingSource1
            // 
            this.alunosBindingSource1.DataMember = "Alunos";
            this.alunosBindingSource1.DataSource = this.bsEscola;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "nota1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            this.nota1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "nota2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            this.nota2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "nota3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "nota3";
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            this.nota3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota4DataGridViewTextBoxColumn
            // 
            this.nota4DataGridViewTextBoxColumn.DataPropertyName = "nota4";
            this.nota4DataGridViewTextBoxColumn.HeaderText = "nota4";
            this.nota4DataGridViewTextBoxColumn.Name = "nota4DataGridViewTextBoxColumn";
            this.nota4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disciplinaDataGridViewTextBoxColumn
            // 
            this.disciplinaDataGridViewTextBoxColumn.DataPropertyName = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.Name = "disciplinaDataGridViewTextBoxColumn";
            this.disciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            this.mediaDataGridViewTextBoxColumn.HeaderText = "Media";
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 327);
            this.Controls.Add(this.dgEscola);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mtxtProcura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbProcura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.PROCURAR);
            this.Controls.Add(this.msk4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msk3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msk2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msk1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEscola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Escola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEscola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskMatricula;
        private System.Windows.Forms.MaskedTextBox msk2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PROCURAR;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProcura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtProcura;
        private System.Data.DataSet dsEscola;
        private System.Data.DataTable Escola;
        private System.Data.DataColumn nome;
        private System.Data.DataColumn matricula;
        private System.Data.DataColumn serie;
        private System.Data.DataColumn nota1;
        private System.Data.DataColumn nota2;
        private System.Data.DataColumn nota3;
        private System.Data.DataColumn nota4;
        private System.Data.DataColumn disciplina;
        private System.Data.DataColumn media;
        private System.Data.DataColumn situacao;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgEscola;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private System.Windows.Forms.BindingSource bsEscola;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alunosBindingSource1;
    }
}

