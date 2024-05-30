using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaX.Data.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataVenda { get; set; }
        public List<VendaItem> Itens { get; set; } = new List<VendaItem>();        
        public Cliente? Cliente { get; set; }
    }
}
