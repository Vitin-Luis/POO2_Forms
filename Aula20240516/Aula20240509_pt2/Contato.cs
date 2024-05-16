using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240509_pt2
{
    public class Contato
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public TipoTelefone tipo { get; set; }

        public Contato(int id, string nome, string telefone, TipoTelefone tipo)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return nome.ToString();
        }

    }
}
