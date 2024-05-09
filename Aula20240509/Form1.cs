using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEstados_Click(object sender, EventArgs e)
        {
            // Verifica se Algo foi digitado, se estiver vazio exibe uma mensagem de erro, do contrário adiciona o estado no combox
            if (textBoxEstados.Text.ToString() ==  "" || textBoxEstados.Text.ToString() == " ")
            {
                MessageBox.Show("Você não digitou um estado", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comboBoxListaEstados.Items.Add(textBoxEstados.Text.ToString().ToUpper());
                textBoxEstados.Clear();
            }
        
        
        }

        private void textBoxEstados_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxListaEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCopiarEstados_Click(object sender, EventArgs e)
        {
            // Adiciona cada item do comBox na lista
            for(int i = 0; i < comboBoxListaEstados.Items.Count; i++)
            {
                listBoxEstados.Items.Add(comboBoxListaEstados.Items[i].ToString());
            }
        }

        private void listBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCopiarSelecionados_Click(object sender, EventArgs e)
        {
            // Adiciona os items selecionados na lista para a outra lista
            for(int i = 0; i < listBoxEstados.SelectedItems.Count; i++)
            {
                listBoxEstadosSelecionados.Items.Add(listBoxEstados.SelectedItems[i]);
            }
    
        }

        private void listBoxEstadosSelecionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
