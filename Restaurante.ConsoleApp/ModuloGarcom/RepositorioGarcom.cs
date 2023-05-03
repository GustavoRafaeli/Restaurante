using Restaurante.ConsoleApp.Compartilhado;
using Restaurante.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.ModuloGarcom
{
     public class RepositorioGarcom : RepositorioBase
    {
        public RepositorioGarcom(ArrayList listaGarcom)
        {
            listaRegistros = listaGarcom;
        }
        public override Garcom SelecionarPorId(int id)
        {
            return (Garcom)base.SelecionarPorId(id);
        }
    }
}
