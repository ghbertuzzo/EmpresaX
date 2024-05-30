using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaX.Data.Entities
{
    public class Cliente
    {
        private Cliente() { }
        public Cliente(string? nome, string? endereco, string? telefone, string? email)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
