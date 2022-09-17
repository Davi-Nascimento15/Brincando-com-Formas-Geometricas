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

namespace FormasGeometricas
{
    public partial class Frm_Carregando : Form
    {
        int tempo = 3;
        Form A;
        public Frm_Carregando(Form F)
        {
            InitializeComponent();
            timer1.Start();
            A = F;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempo > 0)
            {
                tempo--;
                PGB_Carregando.Value += 33;
            }
            else if (tempo == 0)
            {
                timer1.Stop();
                A.ShowDialog();
                Close();
            }
            else
                tempo--;
        }
    }
}
