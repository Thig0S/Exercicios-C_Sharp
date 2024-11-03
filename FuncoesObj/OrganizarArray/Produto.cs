using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OrganizarArray
{
    internal class Produto
    {
        public string NomeProduto;
        public double Preco;
        public int QuantidadeProduto;
        public double TotalEstoque;

        public void AddTotalEstoque(int remover)
        {
            QuantidadeProduto += remover;
        }
        public void RemoverTotalEstoque(int remover)
        {
            QuantidadeProduto -= remover;
        }
        public double GetTotalEstoque()
        {
            return TotalEstoque = Preco * QuantidadeProduto;         
        }
        public override string ToString()
        {
            return NomeProduto + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade: " + QuantidadeProduto + ", Total: R$" + GetTotalEstoque();
        }
    }
}
