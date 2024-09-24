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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }
        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            Ativos.Codigo = Convert.ToInt32(tbn_CodigoAtle.Text);
            ControllerEst controllerEst = new ControllerEst();
            controllerEst.PesquisaCodigo();

            tbx_NomeAtleta.Text = Ativos.Atleta;
            tbx_TimeAtleta.Text = Ativos.Elenco;
            tbx_Posicao.Text = Ativos.Posicao;
            tbx_Gols.Text = Ativos.Gols.ToString();
            tbx_Assistencia.Text = Ativos.Assistencia.ToString();
            tbn_CodigoAtle.Text = Ativos.Codigo.ToString();

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (btn_Pesquisa.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Atleta.");
            }
            else
            {
                {
                    var resposta = MessageBox.Show("Deseja fazer alteração nesses dados" + btn_Pesquisa.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resposta == DialogResult.Yes)
                    {
                        Ativos.Atleta = tbx_NomeAtleta.Text;
                        Ativos.Elenco = tbx_TimeAtleta.Text;
                        Ativos.Posicao = tbx_Posicao.Text;
                        Ativos.Gols = Convert.ToInt32(tbx_Gols.Text);
                        Ativos.Assistencia = Convert.ToInt32(tbx_Assistencia.Text);
                        Ativos.Codigo = Convert.ToInt32(tbn_CodigoAtle.Text);
                        ControllerEst controller = new ControllerEst();
                        controller.Alterar();
                    }
                    else
                    {
                        tbx_NomeAtleta.Text = "";
                        tbx_TimeAtleta.Text = "";
                        tbx_Posicao.Text = "";
                        tbx_Gols.Text = "";
                        tbx_Assistencia.Text = "";



                    }
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (btn_Pesquisa.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Jogador");
            }
            else
            {
                var codigo = MessageBox.Show("Deseja excluir informações do jogador " + btn_Pesquisa.Text + " ? ", " Atenção ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (codigo == DialogResult.Yes)
                {
                    Ativos.Codigo = Convert.ToInt32(tbn_CodigoAtle.Text);
                    ControllerEst controllerEst = new ControllerEst();
                    controllerEst.Excluir();
                }
                else
                {
                    tbx_NomeAtleta.Text = "";
                    tbx_TimeAtleta.Text = "";
                    tbx_Posicao.Text = "";
                    tbx_Gols.Text = "";
                    tbx_Assistencia.Text = "";

                }
            }
        }

        private void Alterar_Load(object sender, EventArgs e)
        {

        }
    }
}
        
