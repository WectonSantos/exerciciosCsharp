namespace tp06_wecton_228550
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tmrLuz = new System.Windows.Forms.Timer(this.components);
            this.strMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxAlturasF = new System.Windows.Forms.GroupBox();
            this.lbxAlturasF = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbxRol = new System.Windows.Forms.GroupBox();
            this.lbxRol = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.strMenu.SuspendLayout();
            this.gbxAlturasF.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbxRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(1, 20);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(590, 32);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Dê 50 alturas de uma determinada amostra:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Location = new System.Drawing.Point(5, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 70);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Location = new System.Drawing.Point(600, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 44);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "(cm)";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(115, 11);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(46, 22);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.Validating += new System.ComponentModel.CancelEventHandler(this.txtAltura_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "* altura";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(14, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // tmrLuz
            // 
            this.tmrLuz.Enabled = true;
            this.tmrLuz.Interval = 1000;
            this.tmrLuz.Tick += new System.EventHandler(this.tmrLuz_Tick);
            // 
            // strMenu
            // 
            this.strMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.strMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sobre});
            this.strMenu.Location = new System.Drawing.Point(0, 0);
            this.strMenu.Name = "strMenu";
            this.strMenu.Size = new System.Drawing.Size(850, 24);
            this.strMenu.TabIndex = 2;
            this.strMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Limpar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sobre
            // 
            this.sobre.Name = "sobre";
            this.sobre.Size = new System.Drawing.Size(49, 20);
            this.sobre.Text = "Sobre";
            this.sobre.Click += new System.EventHandler(this.sobre_Click);
            // 
            // gbxAlturasF
            // 
            this.gbxAlturasF.Controls.Add(this.lbxAlturasF);
            this.gbxAlturasF.Location = new System.Drawing.Point(8, 15);
            this.gbxAlturasF.Name = "gbxAlturasF";
            this.gbxAlturasF.Size = new System.Drawing.Size(512, 241);
            this.gbxAlturasF.TabIndex = 4;
            this.gbxAlturasF.TabStop = false;
            this.gbxAlturasF.Text = "Alturas fornecidas";
            // 
            // lbxAlturasF
            // 
            this.lbxAlturasF.FormattingEnabled = true;
            this.lbxAlturasF.ItemHeight = 16;
            this.lbxAlturasF.Location = new System.Drawing.Point(6, 21);
            this.lbxAlturasF.Name = "lbxAlturasF";
            this.lbxAlturasF.Size = new System.Drawing.Size(492, 196);
            this.lbxAlturasF.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbxRol);
            this.panel3.Controls.Add(this.gbxAlturasF);
            this.panel3.Location = new System.Drawing.Point(5, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 514);
            this.panel3.TabIndex = 5;
            // 
            // gbxRol
            // 
            this.gbxRol.Controls.Add(this.lbxRol);
            this.gbxRol.Location = new System.Drawing.Point(8, 262);
            this.gbxRol.Name = "gbxRol";
            this.gbxRol.Size = new System.Drawing.Size(512, 234);
            this.gbxRol.TabIndex = 5;
            this.gbxRol.TabStop = false;
            this.gbxRol.Text = "Alturas em ROL";
            // 
            // lbxRol
            // 
            this.lbxRol.FormattingEnabled = true;
            this.lbxRol.ItemHeight = 16;
            this.lbxRol.Location = new System.Drawing.Point(6, 22);
            this.lbxRol.Name = "lbxRol";
            this.lbxRol.Size = new System.Drawing.Size(492, 196);
            this.lbxRol.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tp06_wecton_228550.Properties.Resources.depositphotos_60639577_stock_photo_person_measuring_his_height;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(550, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 321);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Location = new System.Drawing.Point(550, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Média das Alturas";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "cm";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(6, 65);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 27);
            this.lblResultado.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.strMenu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.strMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa das Alturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.strMenu.ResumeLayout(false);
            this.strMenu.PerformLayout();
            this.gbxAlturasF.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbxRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrLuz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MenuStrip strMenu;
        private System.Windows.Forms.GroupBox gbxAlturasF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbxRol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbxAlturasF;
        private System.Windows.Forms.ListBox lbxRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobre;
    }
}

