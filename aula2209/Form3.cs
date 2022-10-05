using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listagemAlunos_Enter(object sender, EventArgs e)
        {
            Matricula.Items.Clear();
            foreach(Aluno aluno in global.Sala1)
            {
                Matricula.Items.Add(aluno.Matricula.ToString());
            }
        }

        private void Matricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selecao = Matricula.SelectedItem.ToString();
            foreach(Aluno aluno in global.Sala1)
            {
                if (selecao.Equals(aluno.Matricula.ToString()))
                    nomeAluno.Text = aluno.Nome;
                IdadeAluno.Text = aluno.Idade.ToString();
            }
        }
    }
}
