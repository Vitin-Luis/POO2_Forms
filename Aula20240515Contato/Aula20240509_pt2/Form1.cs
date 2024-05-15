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
        List<Contato> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Contato>();
            comboBoxContato.DisplayMember = "nome";
        }

        private void textBoxNomeDigitar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefoneDigitar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                var nome = textBoxNomeDigitar.Text.ToString();
                var telefone = textBoxTelefoneDigitar.Text.ToString();
                var tipo = comboBoxTipo.SelectedItem.ToString();

                Contato aux = new Contato(nome, telefone, tipo);
                lista.Add(aux);
                comboBoxContato.Items.Add(aux);
                MessageBox.Show(aux.nome + aux.telefone + aux.tipo);
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

        private void dataGridViewContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Contato c = dataGridViewContatos.SelectedRows[0].DataBoundItem as Contato;
                MessageBox.Show("Contato (" + c.nome + " - " + c.telefone + " - " + c.tipo + ")");
            }
            catch
            {
                MessageBox.Show("ERRO", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewContatos.DataSource = null;
            dataGridViewContatos.DataSource = lista;
            dataGridViewContatos.Refresh();
        }
    }
}
