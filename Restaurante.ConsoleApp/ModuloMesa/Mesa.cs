using Restaurante.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string numero;

        public Mesa(string numero)
        {
            this.numero = numero;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesa = (Mesa)registroAtualizado;

            numero = mesa.numero;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(numero.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }
    }
}
