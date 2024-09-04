namespace aula04
{
    partial class frmJogo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbJogador = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVenceu = new System.Windows.Forms.Label();
            this.lblEmpatou = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPerdeu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbC6 = new System.Windows.Forms.PictureBox();
            this.pbC5 = new System.Windows.Forms.PictureBox();
            this.pbC4 = new System.Windows.Forms.PictureBox();
            this.pbC3 = new System.Windows.Forms.PictureBox();
            this.pbC2 = new System.Windows.Forms.PictureBox();
            this.pbC1 = new System.Windows.Forms.PictureBox();
            this.pbJogador = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbJogador.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbC6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.pbJogador);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificação do Jogador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbC3);
            this.groupBox2.Controls.Add(this.pbC2);
            this.groupBox2.Controls.Add(this.pbC1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMPUTADOR";
            // 
            // gbJogador
            // 
            this.gbJogador.Controls.Add(this.pbC6);
            this.gbJogador.Controls.Add(this.pbC5);
            this.gbJogador.Controls.Add(this.pbC4);
            this.gbJogador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJogador.Location = new System.Drawing.Point(18, 351);
            this.gbJogador.Name = "gbJogador";
            this.gbJogador.Size = new System.Drawing.Size(569, 178);
            this.gbJogador.TabIndex = 2;
            this.gbJogador.TabStop = false;
            this.gbJogador.Text = "Jogador(a) - ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPerdeu);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblEmpatou);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblVenceu);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(18, 546);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(569, 116);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Placar do Jogo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venceu";
            // 
            // lblVenceu
            // 
            this.lblVenceu.AutoSize = true;
            this.lblVenceu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenceu.Location = new System.Drawing.Point(96, 54);
            this.lblVenceu.Name = "lblVenceu";
            this.lblVenceu.Size = new System.Drawing.Size(21, 22);
            this.lblVenceu.TabIndex = 1;
            this.lblVenceu.Text = "0";
            // 
            // lblEmpatou
            // 
            this.lblEmpatou.AutoSize = true;
            this.lblEmpatou.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpatou.Location = new System.Drawing.Point(296, 54);
            this.lblEmpatou.Name = "lblEmpatou";
            this.lblEmpatou.Size = new System.Drawing.Size(21, 22);
            this.lblEmpatou.TabIndex = 3;
            this.lblEmpatou.Text = "0";
            this.lblEmpatou.Click += new System.EventHandler(this.lblEmpatou_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empatou";
            // 
            // lblPerdeu
            // 
            this.lblPerdeu.AutoSize = true;
            this.lblPerdeu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdeu.Location = new System.Drawing.Point(467, 54);
            this.lblPerdeu.Name = "lblPerdeu";
            this.lblPerdeu.Size = new System.Drawing.Size(21, 22);
            this.lblPerdeu.TabIndex = 5;
            this.lblPerdeu.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Perdeu";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(267, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 39);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o seu nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbC6
            // 
            this.pbC6.Image = global::aula04.Properties.Resources.papel;
            this.pbC6.Location = new System.Drawing.Point(393, 32);
            this.pbC6.Name = "pbC6";
            this.pbC6.Size = new System.Drawing.Size(155, 135);
            this.pbC6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC6.TabIndex = 5;
            this.pbC6.TabStop = false;
            this.pbC6.Click += new System.EventHandler(this.pbC6_Click);
            // 
            // pbC5
            // 
            this.pbC5.Image = global::aula04.Properties.Resources.tesoura;
            this.pbC5.Location = new System.Drawing.Point(208, 32);
            this.pbC5.Name = "pbC5";
            this.pbC5.Size = new System.Drawing.Size(155, 135);
            this.pbC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC5.TabIndex = 4;
            this.pbC5.TabStop = false;
            this.pbC5.Click += new System.EventHandler(this.pbC5_Click);
            // 
            // pbC4
            // 
            this.pbC4.Image = global::aula04.Properties.Resources.pedra1;
            this.pbC4.Location = new System.Drawing.Point(20, 32);
            this.pbC4.Name = "pbC4";
            this.pbC4.Size = new System.Drawing.Size(155, 135);
            this.pbC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC4.TabIndex = 3;
            this.pbC4.TabStop = false;
            this.pbC4.Click += new System.EventHandler(this.pbC4_Click);
            // 
            // pbC3
            // 
            this.pbC3.Image = global::aula04.Properties.Resources.pergunta;
            this.pbC3.Location = new System.Drawing.Point(393, 20);
            this.pbC3.Name = "pbC3";
            this.pbC3.Size = new System.Drawing.Size(155, 135);
            this.pbC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC3.TabIndex = 2;
            this.pbC3.TabStop = false;
            // 
            // pbC2
            // 
            this.pbC2.Image = global::aula04.Properties.Resources.pergunta;
            this.pbC2.Location = new System.Drawing.Point(208, 20);
            this.pbC2.Name = "pbC2";
            this.pbC2.Size = new System.Drawing.Size(155, 135);
            this.pbC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC2.TabIndex = 1;
            this.pbC2.TabStop = false;
            // 
            // pbC1
            // 
            this.pbC1.Image = global::aula04.Properties.Resources.pergunta;
            this.pbC1.Location = new System.Drawing.Point(20, 20);
            this.pbC1.Name = "pbC1";
            this.pbC1.Size = new System.Drawing.Size(155, 135);
            this.pbC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC1.TabIndex = 0;
            this.pbC1.TabStop = false;
            // 
            // pbJogador
            // 
            this.pbJogador.BackgroundImage = global::aula04.Properties.Resources.inicio;
            this.pbJogador.Image = global::aula04.Properties.Resources.inicio;
            this.pbJogador.Location = new System.Drawing.Point(53, 25);
            this.pbJogador.Name = "pbJogador";
            this.pbJogador.Size = new System.Drawing.Size(170, 118);
            this.pbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJogador.TabIndex = 3;
            this.pbJogador.TabStop = false;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 690);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbJogador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, papel e tesoura";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbJogador.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbC6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbC3;
        private System.Windows.Forms.PictureBox pbC2;
        private System.Windows.Forms.PictureBox pbC1;
        private System.Windows.Forms.GroupBox gbJogador;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblEmpatou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVenceu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pbJogador;
        private System.Windows.Forms.PictureBox pbC6;
        private System.Windows.Forms.PictureBox pbC5;
        private System.Windows.Forms.PictureBox pbC4;
        private System.Windows.Forms.Label lblPerdeu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

