using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quizeitaeita
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Encerra todos os processos e janelas da aplicação

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form1 novoFormulario = new Form1(); // Cria uma instância do Form2
            novoFormulario.Show(); // Exibe o novo formulário. Use ShowDialog() se quiser que o usuário termine a interação neste novo form antes de voltar para o anterior
        }
    }
}
