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
    public partial class Form2 : Form
    {
        Form1 origem;
        public Form2(Form1 origem)
        {
            InitializeComponent();
            this.origem = origem;
            comboBoxContato.Items.Add(new TipoTelefone(1, "zap"));
            comboBoxContato.Items.Add(new TipoTelefone(1, "Comercial"));
            comboBoxContato.Items.Add(new TipoTelefone(1, "Pessoal"));
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Contato aux = new Contato(origem.lista.Count +1, textBoxNomeDigitar.Text, textBoxTelefoneDigitar.Text, (TipoTelefone)comboBoxContato.SelectedItem);
            origem.lista.Add(aux);
            origem.dataGridView1.DataSource = origem.lista;
            origem.dataGridView1.Refresh();
            this.Close();
        }

        private void comboBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
