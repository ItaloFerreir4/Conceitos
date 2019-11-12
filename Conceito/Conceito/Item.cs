using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceito
{
    class Item
    {
        public string NomeItem;
        public double ValorItem;
        public int QuantidadeItem;

        public double AtualizaIventario()
        {
            return ValorItem * QuantidadeItem;
        }
        public void AdicionaItens(int quantidade)
        {
            QuantidadeItem += quantidade;
        }
        public void RemoveItens(int quantidade)
        {
            QuantidadeItem -= quantidade;
        }

        public override string ToString()
        {
            return NomeItem
                + ", $"
                + ValorItem.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QuantidadeItem
                + " unidades, Total: $"
                + AtualizaIventario().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
