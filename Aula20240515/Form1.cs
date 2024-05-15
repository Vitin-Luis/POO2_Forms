using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240515
{

    

    public partial class Form1 : Form
    {

        List<Item> lista;
        public Form1()
        {
            InitializeComponent();
            // Cria Lista de Items
            lista = new List<Item>();
            // Muda o display do objeto no comboBox para pegar o nome do objeto
            comboBoxItem.DisplayMember = "nome";
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            // Cria um auxiliar criando um objeto
            Item aux = new Item(comboBoxItem.Items.Count + 1, ("OPÇÃO" + (comboBoxItem.Items.Count + 1)).ToString());
            // adiciona o auxiliar na lista e depois no combobox
            lista.Add(aux);
            comboBoxItem.Items.Add(aux);
        }

        private void btnEnfiarLista_Click(object sender, EventArgs e)
        {
            // Define a fonte dos dados como null e referencia novamente para o comboBox para evitar problemas
            dataGridViewItem.DataSource = null;
            dataGridViewItem.DataSource =comboBoxItem.Items;
            dataGridViewItem.Refresh();
            // Define a visibilidade da coluna id como falsa
            //dataGridViewItem.Columns["id"].Visible = false;
        }

        private void dataGridViewItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Item i = dataGridViewItem.SelectedRows[0].DataBoundItem as Item;
                MessageBox.Show("ITEM (" + i.Id + " - " + i.Nome + ")");
            }
            catch
            {
                MessageBox.Show("ERRO", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
