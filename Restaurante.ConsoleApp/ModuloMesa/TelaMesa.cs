using Restaurante.ConsoleApp.Compartilhado;
using Restaurante.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Número");

            Console.WriteLine("-----------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20}", mesa.id, mesa.numero);
            }
            Console.ReadLine();
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero: ");
            string numero = Console.ReadLine();

            Mesa mesa = new Mesa(numero);

            return mesa;
        }
    }
}
