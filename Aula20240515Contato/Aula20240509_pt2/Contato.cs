using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240509_pt2
{
    public class Contato
    {
        public string nome;
        public string telefone;
        public string tipo;

        public Contato(string nome, string telefone, string tipo)
        {
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
