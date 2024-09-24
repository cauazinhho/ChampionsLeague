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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Ativos.Atleta = tbx_Nome.Text;
            Ativos.Elenco = tbx_Time.Text;
            Ativos.Posicao = cbx_Posicao.Text;
            Ativos.Gols = Convert.ToInt32(tbx_Gols.Text);
            Ativos.Assistencia = Convert.ToInt32(tbx_Assis.Text);

            ControllerEst controllerEst = new ControllerEst();
            controllerEst.Cadastro();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
