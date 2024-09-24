using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeague.View
{
    public partial class TelaHome : Form
    {
        public TelaHome()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisaPorNome telaPesquisaPorNome = new TelaPesquisaPorNome();
            telaPesquisaPorNome.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar altera = new Alterar();
            altera.Show();
        }
    }
}
