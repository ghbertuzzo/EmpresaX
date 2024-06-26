﻿using EmpresaX.Data.Entities;

namespace EmpresaX.Business.Validators
{
    public class ProdutoValidator
    {
        public void Validate(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Nome))
            {
                throw new ArgumentException("O nome do produto é obrigatório.");
            }

            if (!produto.Preco.HasValue)
            {
                throw new ArgumentException("O preço do produto é obrigatório.");
            }

            //criar validação de formato de preço simples

            if (!produto.Estoque.HasValue)
            {
                throw new ArgumentException("O estoque do produto é obrigatório.");
            }
        }

    }
}
