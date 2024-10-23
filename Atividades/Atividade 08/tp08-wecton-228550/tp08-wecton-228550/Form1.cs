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

namespace tp08_wecton_228550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region cadastro
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Double nota1 = Convert.ToDouble(msk1.Text),
                   nota2 = Convert.ToDouble(msk2.Text), 
                   nota3 = Convert.ToDouble(msk3.Text), 
                   nota4 = Convert.ToDouble(msk4.Text);
            string situacao = "n/a";

            if (nota1 < 0)
            {
                nota1 = 0;
            }else if (nota1 > 10)
            {
                nota1 = 10;
            }

            if (nota2 < 0)
            {
                nota2 = 0;
            }
            else if (nota2 > 10)
            {
                nota2 = 10;
            }

            if (nota3 < 0)
            {
                nota3 = 0;
            }
            else if (nota3 > 10)
            {
                nota3 = 10;
            }

            if (nota4 < 0)
            {
                nota4 = 0;
            }
            else if (nota4 > 10)
            {
                nota4 = 10;
            }
            Double media = (nota1 + nota2 + nota3 + nota4) / 4;


            if (mtxtNome.Text.Length > 0 && msk1.Text.Length > 0 && msk2.Text.Length>0 && msk3.Text.Length > 0 && msk4.Text.Length > 0 
                && mskSerie.Text.Length > 0 && mskMatricula.Text.Length > 0)
            {

               dgEscola.Enabled = true;
               DataRow novalinha = dsEscola.Tables["Alunos"].NewRow();
               novalinha["Nome"] = mtxtNome.Text.ToString();
               novalinha["Matricula"] = mskMatricula.Text.ToString();
               novalinha["Serie"] = mskSerie.Text.ToString();
               novalinha["nota1"] = nota1.ToString();
               novalinha["nota2"] = nota2.ToString();
               novalinha["nota3"] = nota3.ToString();
               novalinha["nota4"] = nota4.ToString();
               novalinha["media"] = media.ToString("F2");
               novalinha["disciplina"] = cbDisciplina.SelectedItem.ToString();

                if (media >= 6)
                {
                    situacao = "Aprovado";
                }
                else
                {
                    situacao = "Reprovado";
                }
               novalinha["situacao"] = situacao.ToString();

               mtxtNome.Clear();
               mskMatricula.Clear();
               mskSerie.Clear();
               msk1.Clear();
               msk2.Clear();
               msk3.Clear();
               msk4.Clear();
               dsEscola.Tables[0].Rows.Add(novalinha);
               dgEscola.Enabled = false;


            }
            else
            {
                MessageBox.Show("Todos os campos tem de estar completos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            cbDisciplina.SelectedIndex = 0;
        }

        private void mtxtProcura_TextChanged(object sender, EventArgs e)
        {
            switch (cbProcura.Text)
            {
                case "Disciplina":
                    alunosBindingSource1.Filter = "disciplina like '%" + mtxtProcura.Text.Trim() + "%'";
                    break;
                case "Serie":
                    alunosBindingSource1.Filter = "serie like '%" + mtxtProcura.Text.Trim() + "%'";
                    break;
                case "Matricula":
                    alunosBindingSource1.Filter = "matricula like '%" + mtxtProcura.Text.Trim() + "%'";
                    break;
                default:
                    mtxtProcura.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }
        }
        #region lixo
        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgEscola_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void porLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dsEscola.Tables["Alunos"].Rows.Count; i++)
                {
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Nome"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Matricula"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Serie"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["nota1"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["nota2"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["nota3"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["nota4"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Disciplina"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Media"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Situacao"]);
                    SW.WriteLine(string.Empty); //pula linha entre um registro e outro
                }
                SW.Dispose(); //Libera todos os recursos usados pelo Componente
            }
        }

        private void porColunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dsEscola.Tables["Alunos"].Rows.Count; i++)
                {
                    string nome = dgEscola.Rows[i].Cells[0].Value.ToString();
                    string matricula = dgEscola.Rows[i].Cells[1].Value.ToString();
                    string serie = dgEscola.Rows[i].Cells[2].Value.ToString();
                    string nota1 = dgEscola.Rows[i].Cells[3].Value.ToString();
                    string nota2 = dgEscola.Rows[i].Cells[4].Value.ToString();
                    string nota3 = dgEscola.Rows[i].Cells[5].Value.ToString();
                    string nota4 = dgEscola.Rows[i].Cells[6].Value.ToString();
                    string disciplina = dgEscola.Rows[i].Cells[7].Value.ToString();
                    string media = dgEscola.Rows[i].Cells[8].Value.ToString();
                    string situacao = dgEscola.Rows[i].Cells[9].Value.ToString();

                    SW.WriteLine(nome + " | " + matricula + " | " + serie + " | 1°Bimestre - " + nota1 + " | 2ºBimestre - " + nota2+
                        " | 3º Bimestre - "+nota3+ " | 4º Bimestre - "+nota4+" | Disciplina - " + disciplina+ " | "+media+" | "+situacao);
                }
                SW.Dispose();
            }
        }
    }
}
