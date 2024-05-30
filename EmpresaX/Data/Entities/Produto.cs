using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaX.Data.Entities
{
    public class Produto
    {
        private Produto() { }
        public Produto(string? nome, string? descricao, Double? preco, int? estoque)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Double? Preco { get; set; }
        public int? Estoque { get; set; }
    }
}
