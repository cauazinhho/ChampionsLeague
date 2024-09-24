using ChampionsLeague.Controller;
using ChampionsLeague.Model;
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



    public partial class TelaPesquisaPorNome : Form
    {
        public TelaPesquisaPorNome()
        {
            InitializeComponent();
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            Ativos.Atleta = tbx_PesquisaAtleta.Text;
            dataGridView1.DataSource = ControllerEst.VisualizarNomeAtleta();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;


            dataGridView1.Columns[5].HeaderCell.Value = "Código";
            dataGridView1.Columns[6].HeaderCell.Value = "Atleta";
            dataGridView1.Columns[7].HeaderCell.Value = "Time";
            dataGridView1.Columns[8].HeaderCell.Value = "Posição";
            dataGridView1.Columns[9].HeaderCell.Value = "Gols";
            dataGridView1.Columns[10].HeaderCell.Value = "Assistência";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaPesquisaPorNome_Load(object sender, EventArgs e)
        {

        }
    }
}
