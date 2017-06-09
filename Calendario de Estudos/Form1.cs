using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario_de_Estudos
{
    public partial class Form1 : Form
    {
        string result;
       public static bool[] vetor = new bool[5];
        string[] atv = new string[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Segunda_Click(object sender, EventArgs e)
        {
            tarefa1 t = new tarefa1();
            t.Show();
            if (t.feito == true)
            {
                vetor[0] = true;
                t.Hide();
            }


        }

        private void Terca_Click(object sender, EventArgs e)
        {
            tarefa2 t = new tarefa2();
            t.Show();
            if (t.feito)
            {
                vetor[1] = true;
            }
        }

        private void Quarta_Click(object sender, EventArgs e)
        {
            tarefa3 t = new tarefa3();
            t.Show();
            if (t.feito)
            {
                vetor[2] = true;
            }
        }

        private void Quinta_Click(object sender, EventArgs e)
        {
            tarefa4 t = new tarefa4();
            t.Show();
            if (t.feito)
            {
                vetor[3] = true;
            }
        }

        private void Sexta_Click(object sender, EventArgs e)
        {
            tarefa5 t = new tarefa5();
            t.Show();
            if (t.feito)
            {
                vetor[4] = true;
            }
        }

        private void Apuração_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 5; i++)
            {
                if (vetor[i] == true)
                {
                    result += "Parabéns você conseguiu " + atv[i]+".\n";
                }
                else
                    result += "Você não conseguiu " + atv[i] + ".\n";
            }
            MessageBox.Show(result);
        }

        private void label1_Click(object sender, EventArgs e)
        {
                                                   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atv[0] = "Ler livros.";
            atv[1] = "Ver Video aulas.";
            atv[2] = "Discutir em grupo";
            atv[3] = "Network";
            atv[4] = "Fazer o teste Prático.";
        }
    }
}
