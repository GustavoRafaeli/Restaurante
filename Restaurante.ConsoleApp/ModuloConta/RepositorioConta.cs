using Restaurante.ConsoleApp.Compartilhado;
using Restaurante.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaConta)
        {
            listaRegistros = listaConta;
        }

        public override Conta SelecionarPorId(int id)
        {
            return (Conta)base.SelecionarPorId(id);
        }
        public double ValorTotal()
        {
            double totalTodasAsContas = 0;
            foreach (Conta conta in listaRegistros)
            {
                if (conta.dataDoPedido == DateTime.Now.Date)
                {
                    conta.SomarTotalPedidos();
                    totalTodasAsContas += conta.SomarTotalPedidos();
                }
            }
            return totalTodasAsContas;
        }
    }
}
