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
    public partial class tarefa2 : Form
    {
        public bool feito = false;
        public tarefa2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarefa realizada com sucesso!");
            Form1.vetor[1] = true;
            this.Hide();
        }
    }
}
