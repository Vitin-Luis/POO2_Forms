using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240509_pt2
{
    public partial class Form1 : Form
    {
        public List<Contato> lista { get; set; }
        public Contato selecionado { get; set; }
        public Form1()
        {
            InitializeComponent();
            lista = new List<Contato>();
        }

        

        private void btnTelaAdicionar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            selecionado = lista[e.RowIndex];
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lista.Remove(selecionado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
