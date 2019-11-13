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
        //Variaveis locais / atributos
        private string nomeItem;
        private double valorItem;
        private int quantidadeItem;

        
        public string NomeItem { get => nomeItem; set => nomeItem = value; }
        public double ValorItem { get => valorItem; set => valorItem = value; }
        public int QuantidadeItem { get => quantidadeItem; set => quantidadeItem = value; }

        public Item(string nomeItem)
        {
            NomeItem = nomeItem;
        }

        public Item(double valorItem)
        {
            ValorItem = valorItem;
        }

        public Item(int quantidadeItem)
        {
            QuantidadeItem = quantidadeItem;
        }

        public Item(string nomeItem, double valorItem, int quantidadeItem) : this(nomeItem)
        {    
            ValorItem = valorItem;
            QuantidadeItem = quantidadeItem;
        }

        public double AtualizaIventario() // Assinatura do metodo
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

        public override string ToString() // Sobrescrever. Virtual || abstrat
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
