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
    public partial class tarefa1 : Form
    {
        public bool feito = false;
        

        public tarefa1()
        {
            InitializeComponent();
        }

        private void tarefa1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarefa realizada com sucesso!");
            Form1.vetor[0] = true;
            this.Hide();
           
        }
    }
}
