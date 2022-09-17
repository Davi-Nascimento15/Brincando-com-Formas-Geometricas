using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormasGeometricas.Classes;
using System.Media;

namespace FormasGeometricas
{
    public partial class Frm_Fase1 : Form
    {
        int interações;
        int acertos;
        int erros;
        int min, seg,seq;
        int Fala;
        List<string> Lista;
        string[] Dicas = System.IO.File.ReadAllLines(@"Dicas\DicasTexto.txt");
        SoundPlayer DicasSom;
        SoundPlayer Fundo = new SoundPlayer(@"Som\Fundo.wav");
        List<PictureBox> Comandos = new List<PictureBox>();
        PictureBox PB;
        Jogador jogador;
        public Frm_Fase1(Jogador jogador)
        {
            
            this.jogador = jogador;
            acertos = 0;
            erros = 0;
            //interações = 3;
            interações = 11;
            Lista = new List<string>();
            InitializeComponent();
            txt_Interacoes.Text = "Restam 11";
            txt_Acertos.Text = "Acertou 0";
            txt_Erros.Text = "Errou 0";
            Comandos.Add(pb_Quadrado);
            Comandos.Add(pb_Circulo);
            Comandos.Add(pb_Triangulo);
            pb_Avatar.Image = jogador.Avatar.Image;
        }
        private void Frm_Fase1_Load(object sender, EventArgs e)
        {
            timer_tempo.Start();
            tempo_Dicas.Start();
            Fundo.Play();
        }

        private void tempo_Dicas_Tick(object sender, EventArgs e)
        {
            DicasTempo();
        }

        private void timer_tempo_Tick(object sender, EventArgs e)
        {
            TempoFase();
        }
        private void Confere(PictureBox P, int S)
        {

            if (Lista.Find(x => x.Contains(P.Name)) == null)
            {
                if (PB.Name == P.Name.Substring(0, S))
                {
                    P.Image = PB.Image;
                    Lista.Add(P.Name);
                    Frm_MensagemBox M = new Frm_MensagemBox(0);
                    M.ShowDialog();
                    interações--;
                    acertos++;
                    txt_Acertos.Text = "Acertou " + acertos;
                    txt_Interacoes.Text = "Restam " + interações;
                    Fundo.Play();
                }
                else
                {
                    erros++;
                    txt_Erros.Text = "Errou " + erros;
                    Frm_MensagemBox M = new Frm_MensagemBox(1);
                    M.ShowDialog();
                    Fundo.Play();
                }
            }
            else 
            {
                Frm_MensagemBox M = new Frm_MensagemBox(2);
                M.ShowDialog();
                Fundo.Play();
            }
            PB.BorderStyle = BorderStyle.None;
            PB.BackColor = Color.Transparent;
            PB = null;
            foreach (Control img in Controls)
            {
                foreach (Control item in Controls)
                {
                    if ((item is PictureBox) && (item.Name != pb_Quadrado.Name) && (item.Name != pb_Triangulo.Name) && (item.Name != pb_Circulo.Name))
                        item.Enabled = false;     
                }
            }
            if (interações == 0) 
            {
                timer_tempo.Stop();
                tempo_Dicas.Stop();
                string[] A;
                A = txt_Acertos.Text.Split(' ');
                Jogo jogo = new Jogo();
                jogo.Acertos = int.Parse(A[1]);
                A = txt_Erros.Text.Split(' ');
                jogo.Erros = int.Parse(A[1]);
                jogo.Tempo = txt_TempoFase.Text;
                jogador.FasesJogo.Add(jogo);
                Fundo.Stop();
                Frm_Fase2 F2 = new Frm_Fase2(jogador);
                Frm_Carregando C = new Frm_Carregando(F2);
                C.ShowDialog();
                Close();
            }
        }
        public void Ativa() {
            foreach (Control img in this.Controls)
            {
                foreach (Control item in this.Controls)
                {

                    if ((item is PictureBox) && (item.Name != pb_Quadrado.Name) && (item.Name != pb_Triangulo.Name) && (item.Name != pb_Circulo.Name) && (item != pb_Trem))
                        item.Enabled = true;
                }
            }
        }
        
        public void Destaca(PictureBox P) 
        {
            foreach (PictureBox item in Comandos) 
            {
                if (P.Name == item.Name)
                {
                    item.BackColor = Color.DimGray;
                    item.BorderStyle = BorderStyle.Fixed3D;
                }
                else 
                {
                    item.BackColor = Color.Transparent;
                    item.BorderStyle = BorderStyle.None;
                }
            }
        }

        public void TempoFase() 
        {
            if (seg < 59)
            {
                seg++;    
            }
            else 
            {
                min++;
                seg = 0;
            }
            if ((seg < 10) && (min < 10))
            {
                txt_TempoFase.Text = "0" + min + ":0" + seg;
            }
            else if ((seg > 10) && (min < 10))
            {
                txt_TempoFase.Text = "0" + min + ":" + seg;
            }
            else if((seg < 10) && (min > 10))
            {
                txt_TempoFase.Text = min + ":0" + seg;
            }else
                txt_TempoFase.Text = min + ":" + seg;
        }
        public void DicasTempo() 
        {
            if (seq < Dicas.Length)
            {
                txt_Dica.Text = Dicas[seq];
                cmd_DicaVoz.Enabled = true;
                seq++;
            }
            else
            {
                txt_Dica.Text = "";
                cmd_DicaVoz.Enabled = false;
                seq = 0;
            }
        }

        private void cmd_DicaVoz_Click(object sender, EventArgs e)
        {
            DicasSom = new SoundPlayer(@"DicasSom\Dica" + (seq) + ".wav");
            DicasSom.Play();
            Fala = 2;
            timerFalaDica.Start();   
        }

        private void timerFalaDica_Tick(object sender, EventArgs e)
        {
            if (Fala == 0)
            {
                timerFalaDica.Stop();
                Fundo.Play();
            }
            else {
                Fala--;
            }
        }
        private void pb_Quadrado_Click(object sender, EventArgs e)
        {
            Ativa();
            PB = pb_Quadrado;
            Destaca(PB);
        }

        private void pb_Triangulo_Click(object sender, EventArgs e)
        {
            Ativa();
            PB = pb_Triangulo;
            Destaca(PB);
        }

        private void pb_Circulo_Click(object sender, EventArgs e)
        {
            Ativa();
            PB = pb_Circulo;
            Destaca(PB);
        }

        private void pb_QuadradoBranco1_Click(object sender, EventArgs e)
        {
            Confere(pb_QuadradoBranco1,11);
        }
        private void pb_QuadradoBranco2_Click(object sender, EventArgs e)
        {
            Confere(pb_QuadradoBranco2,11);
        }

        private void pb_QuadradoBranco3_Click(object sender, EventArgs e)
        {
            Confere(pb_QuadradoBranco3,11);
        }

        private void pb_QuadradoBranco4_Click(object sender, EventArgs e)
        {
            Confere(pb_QuadradoBranco4,11);
        }

        private void pb_TrianguloBranco1_Click(object sender, EventArgs e)
        {
            Confere(pb_TrianguloBranco1,12);
        }

        private void pb_TrianguloBranco2_Click(object sender, EventArgs e)
        {
            Confere(pb_TrianguloBranco2,12);
        }

        private void pb_TrianguloBranco3_Click(object sender, EventArgs e)
        {
            Confere(pb_TrianguloBranco3,12);
        }

        private void pb_CirculoBranco1_Click(object sender, EventArgs e)
        {
            Confere(pb_CirculoBranco1,10);
        }

        private void pb_CirculoBranco2_Click(object sender, EventArgs e)
        {
            Confere(pb_CirculoBranco2,10);
        }

        

        private void pb_CirculoBranco3_Click(object sender, EventArgs e)
        {
            Confere(pb_CirculoBranco3,10);
        }
        private void pb_CirculoBranco4_Click(object sender, EventArgs e)
        {
            Confere(pb_CirculoBranco4,10);
        }
    }
}
