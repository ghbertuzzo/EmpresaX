﻿using EmpresaX.Data.Entities;

namespace EmpresaX.Business.Validators
{
    public class ClienteValidator
    {
        public void Validate(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                throw new ArgumentException("O nome do cliente é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Email))
            {
                throw new ArgumentException("O email do cliente é obrigatório.");
            }

            //criar validação de formato de email simples
        }
    }
}
