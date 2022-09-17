using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormasGeometricas.Classes;
using System.Media;

namespace FormasGeometricas
{
    public partial class Frm_Conclusao : Form
    {
        Jogador jogador;
        string []result;
        SoundPlayer Fundo = new SoundPlayer(@"Som\Fundo.wav");
        public Frm_Conclusao(Jogador jogador)
        {
            this.jogador = jogador;
            InitializeComponent();
            
        }

        private void Frm_Conclusao_Load(object sender, EventArgs e)
        {
            txt_Nome.Text = jogador.Nome;
            pb_Avatar.Image = jogador.Avatar.Image;
            result = new string[6];
            for (int i = 0; i < 6; i++)
            {
                result[i] = jogador.Nome + ";" + jogador.Image + ";" + jogador.FasesJogo[i].Acertos + "; " + jogador.FasesJogo[i].Erros + ";" + jogador.FasesJogo[i].Tempo;
                foreach (Control itens in Controls)
                {
                    foreach (Control Acerto in Controls)
                    {
                        if (Acerto is TextBox && Acerto.Text == "")
                        {
                            if (Acerto.Name == "txt_Acerto" + (i + 1))
                            {
                                Acerto.Text = jogador.FasesJogo[i].Acertos.ToString();
                                break;
                            }
                            else if (Acerto.Name == "txt_Erro" + (i + 1))
                            {
                                Acerto.Text = jogador.FasesJogo[i].Erros.ToString();
                                break;
                            }
                            else if (Acerto.Name == "txt_Tempo" + (i + 1))
                            {
                                Acerto.Text = jogador.FasesJogo[i].Tempo.ToString();
                                break;
                            }
                        }
                    }
                }
                StreamWriter txt = File.AppendText(@"Dados\BaseDados.txt");
                txt.WriteLine(result[i]);
                txt.Close();
            }

            Fundo.Play();

        }
        private void cmd_Iniciar_Click(object sender, EventArgs e)
        {
            Fundo.Stop();
            Close();
        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void pb_Avatar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Parabens_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_Acerto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Erro1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tempo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tempo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Erro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Acerto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tempo3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Erro3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Acerto3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tempo4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Erro4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Acerto4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tempo5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Erro5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Acerto5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tempo6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Erro6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Acerto6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
