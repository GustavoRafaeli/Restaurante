using Restaurante.ConsoleApp.Compartilhado;
using Restaurante.ConsoleApp.ModuloGarcom;
using Restaurante.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public string numero;
        public Mesa mesa;
        public Garcom garcom;
        public ArrayList listaPedidos = new ArrayList();
        public DateTime dataDoPedido;

        public string status;
        public double total;

        public Conta(string numero, Mesa mesa, Garcom garcom)
        {
            this.garcom = garcom;
            this.mesa = mesa;
            this.numero = numero;
            dataDoPedido = DateTime.Now.Date;
            status = "Aberta";
        }
        public double SomarTotalPedidos()
        {
            total = 0;
            foreach (Pedido pedido in listaPedidos)
            {
                total += pedido.CalcularValor();
            }
            return total;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta conta = (Conta)registroAtualizado;
            mesa = conta.mesa;
            garcom = conta.garcom;
            numero = conta.numero;
        }
        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(numero.Trim()))
                erros.Add("O campo \"numero\" é obrigatório");

            return erros;
        }
    }
}
