using Restaurante.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto) 
        {
            repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}|", "Id", "Nome", "Valor");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}|", produto.id, produto.nome, produto.valor);
            }
            Console.ReadLine();
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor: ");
            double valor = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, valor);

            return produto;
        }
    }
}
