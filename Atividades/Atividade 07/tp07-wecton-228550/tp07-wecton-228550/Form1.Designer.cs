namespace tp07_wecton_228550
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.pbVitamina = new System.Windows.Forms.PictureBox();
            this.pbPersonagem = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVitamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(1126, 81);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(44, 32);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "60";
            // 
            // pbVitamina
            // 
            this.pbVitamina.BackgroundImage = global::tp07_wecton_228550.Properties.Resources.vitamins;
            this.pbVitamina.Location = new System.Drawing.Point(231, 256);
            this.pbVitamina.Name = "pbVitamina";
            this.pbVitamina.Size = new System.Drawing.Size(32, 32);
            this.pbVitamina.TabIndex = 3;
            this.pbVitamina.TabStop = false;
            // 
            // pbPersonagem
            // 
            this.pbPersonagem.BackgroundImage = global::tp07_wecton_228550.Properties.Resources.desce;
            this.pbPersonagem.Location = new System.Drawing.Point(42, 38);
            this.pbPersonagem.Name = "pbPersonagem";
            this.pbPersonagem.Size = new System.Drawing.Size(37, 48);
            this.pbPersonagem.TabIndex = 1;
            this.pbPersonagem.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackgroundImage = global::tp07_wecton_228550.Properties.Resources.Labirinto;
            this.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackground.Location = new System.Drawing.Point(-4, 4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1056, 709);
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1059, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tempo Restante (segundos)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbVitamina);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.pbPersonagem);
            this.Controls.Add(this.pbBackground);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do Labirinto";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPrincipal_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbVitamina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbPersonagem;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.PictureBox pbVitamina;
        private System.Windows.Forms.Label label1;
    }
}

