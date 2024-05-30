using EmpresaX.Data.Entities;

namespace EmpresaX.Business.Validators
{
    public class VendaValidator
    {
        public void Validate(Venda venda)
        {
            if (venda == null)
                throw new ArgumentNullException(nameof(venda), "Venda não pode ser nula.");

            if (venda.ClienteId <= 0)
                throw new ArgumentException("ClienteId deve ser maior que zero.", nameof(venda.ClienteId));

            if (venda.Itens == null || venda.Itens.Count == 0)
                throw new ArgumentException("Venda deve ter pelo menos um item.", nameof(venda.Itens));
        }
    }
}
