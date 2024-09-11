namespace aula05
{
    partial class frmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPeriodo = new System.Windows.Forms.RadioButton();
            this.rbDeslocamento = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.tmrAnimacao = new System.Windows.Forms.Timer(this.components);
            this.tmrData = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pbPendulo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPendulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeslocamento);
            this.groupBox1.Controls.Add(this.rbPeriodo);
            this.groupBox1.Location = new System.Drawing.Point(266, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o estudo";
            // 
            // rbPeriodo
            // 
            this.rbPeriodo.AutoSize = true;
            this.rbPeriodo.Location = new System.Drawing.Point(6, 28);
            this.rbPeriodo.Name = "rbPeriodo";
            this.rbPeriodo.Size = new System.Drawing.Size(69, 20);
            this.rbPeriodo.TabIndex = 0;
            this.rbPeriodo.Text = "Período";
            this.rbPeriodo.UseVisualStyleBackColor = true;
            this.rbPeriodo.CheckedChanged += new System.EventHandler(this.rbPeriodo_CheckedChanged);
            // 
            // rbDeslocamento
            // 
            this.rbDeslocamento.AutoSize = true;
            this.rbDeslocamento.Location = new System.Drawing.Point(81, 28);
            this.rbDeslocamento.Name = "rbDeslocamento";
            this.rbDeslocamento.Size = new System.Drawing.Size(108, 20);
            this.rbDeslocamento.TabIndex = 1;
            this.rbDeslocamento.Text = "Deslocamento";
            this.rbDeslocamento.UseVisualStyleBackColor = true;
            this.rbDeslocamento.CheckedChanged += new System.EventHandler(this.rbDeslocamento_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTempo);
            this.groupBox2.Controls.Add(this.txtAngulo);
            this.groupBox2.Controls.Add(this.txtComprimento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(265, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 157);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Pêndulo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Location = new System.Drawing.Point(12, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 250);
            this.panel1.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(13, 494);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(145, 29);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data e Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ângulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo";
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(94, 34);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(62, 22);
            this.txtComprimento.TabIndex = 3;
            this.txtComprimento.Visible = false;
            this.txtComprimento.TextChanged += new System.EventHandler(this.txtComprimento_TextChanged);
            this.txtComprimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtComprimento_Validating);
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(94, 74);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(62, 22);
            this.txtAngulo.TabIndex = 4;
            this.txtAngulo.Visible = false;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(94, 111);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(62, 22);
            this.txtTempo.TabIndex = 5;
            this.txtTempo.Visible = false;
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.lbxResultado);
            this.grbResultado.Location = new System.Drawing.Point(265, 241);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(201, 296);
            this.grbResultado.TabIndex = 5;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Ensaio";
            // 
            // lbxResultado
            // 
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 16;
            this.lbxResultado.Location = new System.Drawing.Point(5, 22);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(191, 260);
            this.lbxResultado.TabIndex = 0;
            // 
            // tmrAnimacao
            // 
            this.tmrAnimacao.Enabled = true;
            this.tmrAnimacao.Tick += new System.EventHandler(this.tmrAnimacao_Tick);
            // 
            // tmrData
            // 
            this.tmrData.Enabled = true;
            this.tmrData.Tick += new System.EventHandler(this.tmrData_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "º";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "s";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::aula05.Properties.Resources.calcular;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(11, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(218, 100);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "&Calcular";
            this.toolTip1.SetToolTip(this.btnCalcular, "Calcular dados");
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::aula05.Properties.Resources.Limpar1;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(11, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(218, 90);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "&Limpar";
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpar Dados");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pbPendulo
            // 
            this.pbPendulo.Location = new System.Drawing.Point(12, 12);
            this.pbPendulo.Name = "pbPendulo";
            this.pbPendulo.Size = new System.Drawing.Size(248, 223);
            this.pbPendulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPendulo.TabIndex = 0;
            this.pbPendulo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 554);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbPendulo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pêndulo Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPendulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPendulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDeslocamento;
        private System.Windows.Forms.RadioButton rbPeriodo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.ListBox lbxResultado;
        private System.Windows.Forms.Timer tmrAnimacao;
        private System.Windows.Forms.Timer tmrData;
    }
}

