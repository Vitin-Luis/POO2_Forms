using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240508
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSobrenome_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCompleto_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            // Recebe nome completo das caixas de texto
            string nomeCompleto;
            nomeCompleto = textBoxNome.Text + " " + textBoxSobrenome.Text;

            string nomeCompletoSemEspaco;
            nomeCompletoSemEspaco = textBoxNome.Text + textBoxSobrenome.Text;

            if (nomeCompletoSemEspaco.Equals(string.Empty))
            {
                MessageBox.Show("Nome Vazio!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblNomeVerdadeiramenteCompleto.Text = nomeCompleto;

                // Adiciona nome completo Concatenado na lista de elementos do BomBox
                cbxNomesAdicionados.Items.Add(lblNomeVerdadeiramenteCompleto.Text);

                // Limpa os nomes da caixa de texto após Concatenar o nome
                textBoxNome.Clear();
                textBoxSobrenome.Clear();
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Botão para limpar nome, sobrenome e nome completo
            textBoxNome.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;
            lblNomeVerdadeiramenteCompleto.Text = string.Empty;
            cbxNomesAdicionados.Items.Clear();
            listViewNomesCompletos.Clear();
             
        }

        private void cbxNomesAdicionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Guarda o nome selecionado na BomBox e joga na lista
            string selecionado;
            selecionado = cbxNomesAdicionados.SelectedItem.ToString();

            // Verifica se o item já existe na lista e depois o Adiciona
            if(selecionado.Equals(listViewNomesCompletos))
            {
                MessageBox.Show("Nome já adicionado!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listViewNomesCompletos.Items.Add(selecionado);
            }
        }

        private void listViewNomesCompletos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblVerdadeiramenteCompleto_Click(object sender, EventArgs e)
        {

        }

    }
}
