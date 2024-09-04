using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace tp04_wecton_228550
{
    public partial class frmPrincipal : Form
    {
        #region variaveis globais
        int jogador, opcao = 0, cpu, comecou;
        int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        string opcaoNome = "";
        string cpuNome= "";
        int encerrou = 0;
        string reinicia = "\\branco.jpeg";

        int x;
        #endregion
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            opcao = 1;
            escolhe();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            opcao = 2;
            escolhe();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            if (opcao != 0)
            {
                comecou = 1;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[0] == 0) {
                    array[0] = 1;
                    pb1.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();
                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gbJogo.ForeColor = Color.Red;
            gbJogo.Text = "" + textBox1.Text +" x Computador";
        }

        void escolhe()
        {
            if (opcao == 1)
            {
                jogador = 1;
                cpu = 2;
                opcaoNome = "\\Santos_Logo.png";
                cpuNome = "\\Real_Madrid.png";
                pbJogador.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Santos_Logo.png");
                pbJogador1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Santos_Logo.png");
                pbCPU.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Real_Madrid.png");

            }
            else if(opcao == 2)
            {
                jogador = 2;
                cpu = 1;
                opcaoNome = "\\Real_Madrid.png";
                cpuNome = "\\Santos_Logo.png";
                pbJogador.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Real_Madrid.png");
                pbJogador1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Real_Madrid.png");
                pbCPU.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Santos_Logo.png");
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[1] == 0)
                {
                    array[1] = 1;
                    pb2.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        #region lixo
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #endregion
        private void pb3_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[2] == 0)
                {
                    array[2] = 1;
                    pb3.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[3] == 0)
                {
                    array[3] = 1;
                    pb4.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[4] == 0)
                {
                    array[4] = 1;
                    pb5.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[5] == 0)
                {
                    array[5] = 1;
                    pb6.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[6] == 0)
                {
                    array[6] = 1;
                    pb7.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[7] == 0)
                {
                    array[7] = 1;
                    pb8.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (comecou == 1)
            {
                if (array[8] == 0)
                {
                    array[8] = 1;
                    pb9.Image = Image.FromFile(Directory.GetCurrentDirectory() + opcaoNome);
                    aleatorio();
                    verifica();
                    acabouJogador1();
                    acabouJogador2();

                }
                else
                {
                    MessageBox.Show("JOGADA INVÁLIDA", "Selecione outro...");
                }
            }
        }

        private void gbJogo_Enter(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
        void jogadaCPU(int x)
        {
            if (array[x] == 0)
            {
                array[x] = 2;
            }else if(array[x] == 1)
            {
                aleatorio();
            }
        }
        void aleatorio()
        {
            //   Random sorteio = new Random();
            //    x = sorteio.Next(0, 8);
            //   jogadaCPU(x);
            Random sorteio = new Random();
            int tentativa = 0;
            while (tentativa < 9)
            {
                x = sorteio.Next(0, 9);
                if (array[x] == 0)
                {
                    jogadaCPU(x);
                    break;
                }
                tentativa++;
            }
        }

        void verifica()
        {
            //verifica 2
            if(array[0] == 2)
            {
                pb1.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[1] == 2)
            {
                pb2.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[2] == 2)
            {
                pb3.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[3] == 2)
            {
                pb4.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[4] == 2)
            {
                pb5.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[5] == 2)
            {
                pb6.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[6] == 2)
            {
                pb7.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[7] == 2)
            {
                pb8.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }
            if (array[8] == 2)
            {
                pb9.Image = Image.FromFile(Directory.GetCurrentDirectory() + cpuNome);
            }

            // reinicia
            if (array[0] == 0)
            {
                pb1.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[1] == 0)
            {
                pb2.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[2] == 0)
            {
                pb3.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[3] == 0)
            {
                pb4.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[4] == 0)
            {
                pb5.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[5] == 0)
            {
                pb6.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[6] == 0)
            {
                pb7.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[7] == 0)
            {
                pb8.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
            if (array[8] == 0)
            {
                pb9.Image = Image.FromFile(Directory.GetCurrentDirectory() + reinicia);
            }
        }

        void acabouJogador1()
        {
            if(array[0]== 1 && array[1] == 1 && array[2] == 1)
            {
                encerrou = 1;
            }
            if (array[0] == 1 && array[3] == 1 && array[6] == 1)
            {
                encerrou = 1;
            }
            if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {
                encerrou = 1;
            }
            if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {
                encerrou = 1;
            }
            if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {
                encerrou = 1;
            }
            if (array[1] == 1 && array[4] == 1 && array[8] == 1)
            {
                encerrou = 1;
            }
            if (array[2] == 1 && array[4] == 1 && array[6]==1)
            {
                encerrou = 1;
            }
            if (array[0] == 1 && array[4] == 1 && array[8] == 1)
            {
                encerrou = 1;
            }

            if(encerrou == 1)
            {
                MessageBox.Show("FIM DE JOGO. VOCÊ VENCEU!", "OK");
                Array.Clear(array, 0, array.Length);
                verifica();
            }
        }
        void acabouJogador2()
        {
            if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                encerrou = 2;
            }
            if (array[0] == 2 && array[3] == 2 && array[6] == 2)
            {
                encerrou = 2;
            }
            if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {
                encerrou = 2;
            }
            if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {
                encerrou = 2;
            }
            if (array[3] == 2 && array[4] == 2 && array[5] == 2)
            {
                encerrou = 2;
            }
            if (array[1] == 2 && array[4] == 2 && array[8] == 2)
            {
                encerrou = 2;
            }
            if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {
                encerrou = 2;
            }
            if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {
                encerrou = 2;
            }

            if (encerrou == 2)
            {
                MessageBox.Show("FIM DE JOGO. VOCÊ PERDEU!", "OK");
                Array.Clear(array, 0, array.Length);
                verifica();

            }
        }


    }
}
