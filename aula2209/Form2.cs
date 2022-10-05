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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            nomeAluno.Clear();
            idadeAluno.Clear();
            matriculaAluno.Clear();
            nomeAluno.Focus();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Cadastro formulario = (Cadastro)FindForm();
            formulario.Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if("".Equals(nomeAluno.Text) || matriculaAluno.Text.Equals("") || "".Equals(idadeAluno.Text))
                {
                var resultado = MessageBox.Show("Preencha TODOS os campos!","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Aluno objAluno = new Aluno();
                objAluno.Nome = nomeAluno.Text;
                objAluno.Matricula = Convert.ToInt32(matriculaAluno.Text);
                objAluno.Idade = Convert.ToInt32(idadeAluno.Text);
                global.Sala1.Add(objAluno);
                nomeAluno.Text = "";
                idadeAluno.Text = "";
                matriculaAluno.Text = "";
                nomeAluno.Focus();
                MessageBox.Show("Aluno Registrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
