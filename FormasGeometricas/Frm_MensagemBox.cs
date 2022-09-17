using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FormasGeometricas
{
    public partial class Frm_MensagemBox : Form
    {
        int resposta;
        int tempo;
        SoundPlayer S;
        public Frm_MensagemBox(int R)
        {
            resposta = R;
            tempo = 3;
            InitializeComponent();
        }

        private void Frm_MensagemBox_Load(object sender, EventArgs e)
        {
            if (resposta == 0)
            {
                lbl_Titulo.Location = new Point(93, 45);
                lbl_Explicacao.Location = new Point(49, 147);
                S= new SoundPlayer(@"Som\Acertou.wav");
                S.Play();
            }
            else if (resposta == 1)
            {
                lbl_Titulo.Location = new Point(93, 42);
                lbl_Explicacao.Location = new Point(77, 147);
                S = new SoundPlayer(@"Som\Errou.wav");
                S.Play();
            }
            else 
            {
                lbl_Titulo.Location = new Point(136, 40);
                lbl_Explicacao.Location = new Point(-4, 139);
                S = new SoundPlayer(@"Som\Repetiu.wav");
                S.Play();
            }
            timer1.Start();
            if (resposta == 0)
            {
                lbl_Titulo.Text = "Parabéns!!";
                lbl_Explicacao.Text = "Você Acertou";
            }
            else if (resposta == 1)
            {
                lbl_Titulo.Text = "Que Pena!!";
                lbl_Explicacao.Text = "Você Errou!";
            }
            else 
            {
                lbl_Titulo.Text = "Ops!!";
                lbl_Explicacao.Text = "Essa já foi, tente outra";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempo > 0)
                tempo--;
            else
            {
                S.Stop();
                timer1.Stop();
                Close();
            }
        }
    }
}
