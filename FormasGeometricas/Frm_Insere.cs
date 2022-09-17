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
    public partial class Frm_Insere : Form
    {
        SoundPlayer S;
        List<PictureBox> Comandos = new List<PictureBox>();
        Jogador jogador;
        PictureBox PB;
        public Frm_Insere(SoundPlayer S)
        {
            this.S = S;
            InitializeComponent();
            Comandos.Add(pb_AvatarMenina);
            Comandos.Add(pb_AvatarMenino);
        }
        private void cmd_Iniciar_Click(object sender, EventArgs e)
        {
            jogador= new Jogador();
            jogador.Nome = txt_Nome.Text;
            jogador.Avatar = PB;
            if (PB.Name == "pb_AvatarMenina")
                jogador.Image = 1;
            else
                jogador.Image = 0;
            Frm_Fase1 F1 = new Frm_Fase1(jogador);
            //Frm_Fase6 F1 = new Frm_Fase6(jogador);
            Frm_Carregando C = new Frm_Carregando(F1);
            S.Stop();
            C.ShowDialog();
            Close();
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
        private void pb_AvatarMenino_Click(object sender, EventArgs e)
        {
            cmd_Iniciar.Enabled = true;
            PB = pb_AvatarMenino;
            Destaca(pb_AvatarMenino);
        }

        private void pb_AvatarMenina_Click(object sender, EventArgs e)
        {
            cmd_Iniciar.Enabled = true;
            PB = pb_AvatarMenina;
            Destaca(pb_AvatarMenina);
        }
    }
}
