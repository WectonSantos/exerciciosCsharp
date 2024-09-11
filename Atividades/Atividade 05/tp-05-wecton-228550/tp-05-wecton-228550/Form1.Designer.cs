namespace tp_05_wecton_228550
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
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.tmrAnimacao = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.lbxR1 = new System.Windows.Forms.ListBox();
            this.lbxR2 = new System.Windows.Forms.ListBox();
            this.lbxR3 = new System.Windows.Forms.ListBox();
            this.lbxC2 = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tmrData = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagem
            // 
            this.pbxImagem.Location = new System.Drawing.Point(12, 263);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(751, 279);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 0;
            this.pbxImagem.TabStop = false;
            // 
            // tmrAnimacao
            // 
            this.tmrAnimacao.Enabled = true;
            this.tmrAnimacao.Tick += new System.EventHandler(this.tmrAnimacao_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplificação do circuito:";
            // 
            // txtAmp
            // 
            this.txtAmp.Location = new System.Drawing.Point(167, 15);
            this.txtAmp.Name = "txtAmp";
            this.txtAmp.Size = new System.Drawing.Size(60, 22);
            this.txtAmp.TabIndex = 2;
            this.txtAmp.TextChanged += new System.EventHandler(this.txtAmp_TextChanged);
            this.txtAmp.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmp_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacitor:";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(85, 49);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(60, 22);
            this.txtCap.TabIndex = 4;
            this.txtCap.TextChanged += new System.EventHandler(this.txtCap_TextChanged);
            this.txtCap.Validating += new System.ComponentModel.CancelEventHandler(this.txtCap_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frequência: ";
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(85, 85);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(60, 22);
            this.txtFreq.TabIndex = 6;
            this.txtFreq.TextChanged += new System.EventHandler(this.txtFreq_TextChanged);
            this.txtFreq.Validating += new System.ComponentModel.CancelEventHandler(this.txtFreq_Validating);
            // 
            // lbxR1
            // 
            this.lbxR1.FormattingEnabled = true;
            this.lbxR1.ItemHeight = 16;
            this.lbxR1.Location = new System.Drawing.Point(268, 14);
            this.lbxR1.Name = "lbxR1";
            this.lbxR1.Size = new System.Drawing.Size(108, 228);
            this.lbxR1.TabIndex = 9;
            // 
            // lbxR2
            // 
            this.lbxR2.FormattingEnabled = true;
            this.lbxR2.ItemHeight = 16;
            this.lbxR2.Location = new System.Drawing.Point(396, 15);
            this.lbxR2.Name = "lbxR2";
            this.lbxR2.Size = new System.Drawing.Size(108, 228);
            this.lbxR2.TabIndex = 10;
            // 
            // lbxR3
            // 
            this.lbxR3.FormattingEnabled = true;
            this.lbxR3.ItemHeight = 16;
            this.lbxR3.Location = new System.Drawing.Point(524, 15);
            this.lbxR3.Name = "lbxR3";
            this.lbxR3.Size = new System.Drawing.Size(108, 228);
            this.lbxR3.TabIndex = 11;
            // 
            // lbxC2
            // 
            this.lbxC2.FormattingEnabled = true;
            this.lbxC2.ItemHeight = 16;
            this.lbxC2.Location = new System.Drawing.Point(655, 15);
            this.lbxC2.Name = "lbxC2";
            this.lbxC2.Size = new System.Drawing.Size(108, 228);
            this.lbxC2.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(12, 126);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(215, 29);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "&Calcular";
            this.toolTip.SetToolTip(this.btnCalcular, "Calcular os dados");
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(12, 161);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(215, 29);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "&Limpar";
            this.toolTip.SetToolTip(this.btnLimpar, "Limpar os dados");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tmrData
            // 
            this.tmrData.Enabled = true;
            this.tmrData.Tick += new System.EventHandler(this.tmrData_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(8, 218);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(121, 24);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data e Hora";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 554);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbxC2);
            this.Controls.Add(this.lbxR3);
            this.Controls.Add(this.lbxR2);
            this.Controls.Add(this.lbxR1);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxImagem);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Timer tmrAnimacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.ListBox lbxR1;
        private System.Windows.Forms.ListBox lbxR2;
        private System.Windows.Forms.ListBox lbxR3;
        private System.Windows.Forms.ListBox lbxC2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Timer tmrData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

