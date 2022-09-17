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
    public partial class Frm_Inicio : Form
    {
        SoundPlayer S;
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void cmd_Iniciar_Click(object sender, EventArgs e)
        {
            Frm_Insere Ins = new Frm_Insere(S);
            Ins.ShowDialog();
            S.Play();
        }

        private void cmd_Resultados_Click(object sender, EventArgs e)
        {
            Frm_Resultados R = new Frm_Resultados();
            R.ShowDialog();
        }

        private void cmd_Creditos_Click(object sender, EventArgs e)
        {
            Frm_Creditos C = new Frm_Creditos();
            C.ShowDialog();
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            S = new SoundPlayer(@"Som\Fundo.wav");
            S.Play();
        }

        private void cmd_Sair_Click(object sender, EventArgs e)
        {
            S.Stop();
            Close();
        }
    }
}
