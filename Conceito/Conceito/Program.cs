using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Conceito
{
    class Program
    {      
        static void Main(string[] args)
        {
            Item i = new Item();
            bool continua = true;

            while (continua)
            {
                Clear();
                WriteLine("__________Entre com os dados do item__________");
                Write("Nome do item: ");
                i.NomeItem = ReadLine();
                Write("Valor do item: ");
                i.ValorItem = double.Parse(ReadLine(), CultureInfo.InstalledUICulture);
                Write("Quantidade do inventario: ");
                i.QuantidadeItem = int.Parse(ReadLine());
                WriteLine("");

                WriteLine("Dados do item: " + i);
                WriteLine("");

                Write("Digite o numero de itens a ser adicionado ao inventario: ");
                int qtda = int.Parse(ReadLine());
                i.AdicionaItens(qtda);
                WriteLine("");

                WriteLine("Dados atualizados: " + i);
                WriteLine("");

                Write("Digite o numero de itens a ser removido ao inventario: ");
                qtda = int.Parse(ReadLine());
                i.RemoveItens(qtda);
                WriteLine("");

                WriteLine("Dados atualizados: " + i);
                WriteLine("");

                WriteLine("Deseja continuar (sim ou nao): ");
                string vai = ReadLine();

                switch (vai.ToLower())
                {
                    case "sim":
                        continua = true;
                        break;
                    case "nao":
                        continua = false;
                        break;
                    default:
                        {                          
                            WriteLine("__________!!Favor digitar apenas sim ou nao (sem acentos)!!__________");
                            WriteLine("Deseja continuar (sim ou nao): ");
                            vai = ReadLine();
                            break;
                        }
                }
            }

            WriteLine("-___________Volte Sempre___________-");
            ReadLine();
        }
    }
}
