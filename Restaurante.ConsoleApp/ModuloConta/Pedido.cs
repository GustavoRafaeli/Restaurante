using Restaurante.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.ModuloConta
{
    public class Pedido
    {
        public int quantidade;
        public Produto produto;

        public Pedido(int quantidade, Produto produto)
        {
            this.quantidade = quantidade;
            this.produto = produto;
        }

        public double CalcularValor() 
        {
            return quantidade * produto.valor;
        }

    }
}
