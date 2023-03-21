using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5___081220002
{
    public partial class Form1 : Form
    {
        List<Aluno> alunos = new List<Aluno>(10);
        Aluno aluno;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Aluno alunorepetido = alunos.Find(a => a.Nome == txtNome.Text);
            if (alunos.Count == 10)
            {
                MessageBox.Show("Número máximo de alunos cadastrados");
            }
            else if(alunorepetido != null)
            {
                MessageBox.Show("Aluno já registrado");
            }
            else
            {
                try
                {

                    aluno = new Aluno();
                    aluno.Nome = txtNome.Text;
                    aluno.Nota1 = double.Parse(txtNota1.Text);
                    aluno.Nota2 = double.Parse(txtNota2.Text);
                    alunos.Add(aluno);

                    MessageBox.Show("Registrado!");

                }
                catch (FormatException)
                {
                    MessageBox.Show("Use apenas letras");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btncadastrados_Click(object sender, EventArgs e)
        {

            dgv.DataSource = null;
            dgv.DataSource = alunos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeprocurado = txtNomPro.Text;
            List<Aluno> alunoprocurado = alunos.FindAll(ap => ap.Nome.Contains(nomeprocurado) );
            if(alunoprocurado != null)
            {
                dgv.DataSource = alunoprocurado;
                txtNomPro.Clear();
            }
            else
            {
                MessageBox.Show("Aluno não Registrado");
            }

        }
    }
}

