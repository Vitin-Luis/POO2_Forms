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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNomeDigitar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefoneDigitar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTipo.Items.Add("Zap");
            comboBoxTipo.Items.Add("Comercial");
            comboBoxTipo.Items.Add("Pessoal");
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefone_Click(object sender, EventArgs e)
        {

        }

        private void labelTipo_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAceitarTermos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(checkBoxAceitarTermos.Checked)
            {
                var nome = labelNome.Text;
                var telefone = labelTelefone.Text;
                var tipo = comboBoxTipo.SelectedItem.ToString();

                Contato contato = new Contato(nome, telefone, tipo);
                listBoxContato.Items.Add(contato);
            }
            else
            {
                MessageBox.Show("Você não aceitou o pacto!!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
