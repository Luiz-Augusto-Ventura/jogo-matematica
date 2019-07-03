using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMatematica
{
    public partial class frmMatematica : Form
    {
        public frmMatematica()
        {
            InitializeComponent();
            dtHora.Enabled = false;
        }

        Random x;
        int v1, v2;
        int pontos = 0;
        DateTime inicio, fim;
        int result = 0;
        Jogador J = null;
        List<Jogador> Jogadores = new List<Jogador>();
        Ranking R = null;

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                if (cmbOperacoes.SelectedIndex == 0)
                {
                    if ((v1 + v2) == Convert.ToInt32(txtResultado.Text))
                    {
                        MessageBox.Show("Parabéns você acertou\nTempo de resposta: " + result + " segundos");
                        if (rbFacil.Checked == true)
                            pontos++;
                        else
                            pontos = pontos + 2;
                        GerarValores();
                        lblstatus.Text = "Você tem " + pontos + " pontos.";
                    }
                    else
                    {
                        MessageBox.Show("Você errou\nTempo de resposta: " + result + " segundos");
                        if (pontos > 0)
                        {
                            if (rbFacil.Checked == true)
                                pontos--;
                            else
                                pontos = pontos - 2;
                            txtResultado.Clear();
                            lblstatus.Text = "Você tem " + pontos + " pontos.";
                        }
                    }
                }


                if (cmbOperacoes.SelectedIndex == 1)
                {
                    if ((v1 - v2) == Convert.ToInt32(txtResultado.Text))
                    {
                        MessageBox.Show("Parabéns você acertou\nTempo de resposta: " + result + " segundos");
                        if (rbFacil.Checked == true)
                            pontos++;
                        else
                            pontos = pontos + 2;                     
                        lblstatus.Text = "Você tem " + pontos + " pontos.";
                        GerarValores();
                    }
                    else
                    {
                        MessageBox.Show("Você errou\nTempo de resposta: " + result + " segundos");
                        if (pontos > 0)
                        {
                            if (rbFacil.Checked == true)
                                pontos--;
                            else
                                pontos = pontos - 2;
                            txtResultado.Clear();
                            lblstatus.Text = "Você tem " + pontos + " pontos.";
                        }
                    }
                }

                if (cmbOperacoes.SelectedIndex == 2)
                {
                    if ((v1 * v2) == Convert.ToInt32(txtResultado.Text))
                    {
                        MessageBox.Show("Parabéns você acertou\nTempo de resposta: " + result + " segundos");
                        if (rbFacil.Checked == true)
                            pontos++;
                        else
                            pontos = pontos + 2;
                        GerarValores();
                        lblstatus.Text = "Você tem " + pontos + " pontos.";                        
                    }
                    else
                    {
                        MessageBox.Show("Você errou\nTempo de resposta: " + result + " segundos");
                        if (pontos > 0)
                        {
                            if (rbFacil.Checked == true)
                                pontos--;
                            else
                                pontos = pontos - 2;
                            txtResultado.Clear();
                            lblstatus.Text = "Você tem " + pontos + " pontos.";
                        }
                    }
                }

                if (cmbOperacoes.SelectedIndex == 3)
                {
                    if ((v1 / v2) == Convert.ToInt32(txtResultado.Text))
                    {
                        MessageBox.Show("Parabéns você acertou\nTempo de resposta: " + result + " segundos");
                        if (rbFacil.Checked == true)
                            pontos++;
                        else
                            pontos = pontos + 2;
                        GerarValores();
                        lblstatus.Text = "Você tem " + pontos + " pontos.";
                        
                    }
                    else
                    {
                        MessageBox.Show("Você errou\nTempo de resposta: " + result + " segundos");
                        if (pontos > 0)
                        {
                            if (rbFacil.Checked == true)
                                pontos--;
                            else
                                pontos = pontos - 2;
                            txtResultado.Clear();
                            lblstatus.Text = "Você tem " + pontos + " pontos.";
                        }
                    }
                }
            }
            result = 0;
        }

        private void cmdEncerrar_Click(object sender, EventArgs e)
        {
            fim = DateTime.Now;
            MessageBox.Show("Parabéns você acertou " + pontos + "!\nVocê jogou das " + inicio.ToLongTimeString() + " até as " + fim.ToLongTimeString() + ".");
            J = new Jogador();
            J.Nome = txtNome.Text;
            J.Pontuacao = pontos;
            Jogadores.Add(J);
            groupBox1.Enabled = true; 
            txtNome.ResetText();
            txtResultado.ResetText();
            inicio = DateTime.Now;
            dtHora.Value = DateTime.Now;
            lblstatus.Text = "Status";
            cmdJogar.Enabled = true;
            cmbOperacoes.ResetText();
            lblOperacoes.Text = "Operação:";
            pontos = 0;
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdJogar_Click(object sender, EventArgs e)
        {
            bool teste = false;
            if (txtNome.Text != "")
            {
                foreach (Jogador item in Jogadores)
                {
                    if (item.Nome == txtNome.Text)
                    {
                        teste = true;
                    }
                }
                if (teste == true)
                {
                    MessageBox.Show("Você já jogou!");
                    txtNome.Clear();
                }
                else
                {
                    GerarValores();
                    result = 0;
                    groupBox1.Enabled = false;
                    cmdJogar.Enabled = false;
                }
            }
            else
                MessageBox.Show("Digite seu nome por favor");
        }

        private void cmdRanking_Click(object sender, EventArgs e)
        { 
            R = new Ranking(Jogadores);
            Jogador[] Rank = R.Ordena();
            for(int i =0; i < Rank.Length; i++)
            {
                lbRanking.Items.Add(i+1 + "º  - Nome: " + Rank[i].Nome + "    " + "Pontuação: " + Rank[i].Pontuacao);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            result++;
        }

        private void frmMatematica_Load(object sender, EventArgs e)
        {
            inicio = DateTime.Now;
            dtHora.Value = DateTime.Now;
        }

        private void GerarValores()
        {
            x = new Random(DateTime.Now.Millisecond);
            txtResultado.Clear();
            if (rbFacil.Checked == true)
            {
                v1 = x.Next(1, 10);
                v2 = x.Next(1, 10);
            }
            else
            {
                v1 = x.Next(1, 50);
                v2 = x.Next(1, 50);
            }
            if (cmbOperacoes.SelectedIndex == 0)
            {
                lblOperacoes.Text = v1.ToString() + " + " + v2.ToString() + " = ";
            }
            if (cmbOperacoes.SelectedIndex == 1)
            {
                lblOperacoes.Text = v1.ToString() + " - " + v2.ToString() + " = ";
            }
            if (cmbOperacoes.SelectedIndex == 2)
            {
                lblOperacoes.Text = v1.ToString() + " * " + v2.ToString() + " = ";
            }
            if (cmbOperacoes.SelectedIndex == 3)
            {
                lblOperacoes.Text = v1.ToString() + " / " + v2.ToString() + " = ";
            }
        }

    }
}
