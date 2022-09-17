using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeometricas
{
    public partial class Frm_Resultados : Form
    {
        string[] txt;
        string[,] txt1;
        int i, f, j;
        public Frm_Resultados()
        {
            txt = System.IO.File.ReadAllLines(@"Dados\BaseDados.txt");
            txt1 = new string[txt.Length, 1];
            for (int cont = 0; cont < txt.Length; cont++)
            {
                    txt1[cont, 0] = txt[cont];
            }
            f = txt.Length;
            i = 0; j = 0;
            InitializeComponent();
        }

        private void cmd_TelaInicial_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_Voltar_Click(object sender, EventArgs e)
        {
            Limpa();
            Preenher(false);
            Botoes();
        }

        private void cmd_Prox_Click(object sender, EventArgs e)
        {
            Limpa();
            Preenher(true);
            Botoes();
        }

        private void Frm_Resultados_Load(object sender, EventArgs e)
        {
            Preenher(true);
            Botoes();
        }
        private void Limpa() 
        {
            foreach(Control item in Controls) 
            {
                foreach (Control item1 in Controls) 
                {
                    if (item1 is TextBox)
                        item1.Text = "";
                }
            }
        }

        private void Botoes()
        {
            if ((i <= 0) && (f > 0))
            {
                cmd_Voltar.Enabled = false;
                cmd_Prox.Enabled = true;
            }
            else if (i < (f - 1))
            {
                cmd_Prox.Enabled = true;
            }
            else if ((i >= (f - 1)) && (f > 0))
            {
                cmd_Prox.Enabled = false;
                cmd_Voltar.Enabled = true;
            }
        }
        private void Preenher(bool op)
        {
            if (f == 0)
            {
                MessageBox.Show("Não há nenhum resultado!!");
                Close();
            }
            else
            {
                if (op == true)
                {
                    string[] A;
                    int c = 1;
                    while (c <= 6)
                    {
                        A = txt1[i, 0].Split(';');
                        txt_Nome.Text = A[0];
                        if (A[1] == "0")
                            pb_Avatar.Image = FormasGeometricas.Properties.Resources.Avatar_Menino;
                        else
                            pb_Avatar.Image = FormasGeometricas.Properties.Resources.Avatar_Menina;
                        foreach (Control itens in Controls)
                        {
                            foreach (Control Acerto in Controls)
                            {
                                if ((Acerto is TextBox) && (Acerto.Text == ""))
                                {
                                    if (Acerto.Name == "txt_Acerto" + c.ToString())
                                    {
                                        Acerto.Text = A[2];
                                        break;
                                    }
                                    if (Acerto.Name == "txt_Erro" + c.ToString())
                                    {
                                        Acerto.Text = A[3];
                                        break;
                                    }
                                    if (Acerto.Name == "txt_Tempo" + c.ToString())
                                    {
                                        Acerto.Text = A[4];
                                        break;
                                    }
                                }
                            }
                        }
                        c++;
                        i++;
                        Botoes();
                    }
                }
                else if (op == false)
                {
                    
                    string[] A;
                    int c = 6;
                    while (c > 0)
                    {
                        A = txt1[i-1, 0].Split(';');
                        txt_Nome.Text = A[0];
                        if (A[1] == "0")
                            pb_Avatar.Image = FormasGeometricas.Properties.Resources.Avatar_Menino;
                        else
                            pb_Avatar.Image = FormasGeometricas.Properties.Resources.Avatar_Menina;
                        foreach (Control itens in Controls)
                        {
                            foreach (Control Acerto in Controls)
                            {
                                if ((Acerto is TextBox) && (Acerto.Text == ""))
                                {
                                    if (Acerto.Name == "txt_Acerto" + c.ToString())
                                    {
                                        Acerto.Text = A[2];
                                        break;
                                    }
                                    if (Acerto.Name == "txt_Erro" + c.ToString())
                                    {
                                        Acerto.Text = A[3];
                                        break;
                                    }
                                    if (Acerto.Name == "txt_Tempo" + c.ToString())
                                    {
                                        Acerto.Text = A[4];
                                        break;
                                    }
                                }
                            }
                        }
                        c--;
                        i--;
                        Botoes();
                    }
                }
            }
        }
    }
}