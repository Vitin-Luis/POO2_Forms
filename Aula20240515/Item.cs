using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240515
{
    internal class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Item(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
