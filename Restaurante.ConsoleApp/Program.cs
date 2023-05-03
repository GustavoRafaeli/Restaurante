using Restaurante.ConsoleApp.InfraMenu;
using Restaurante.ConsoleApp.ModuloConta;
using Restaurante.ConsoleApp.ModuloGarcom;
using Restaurante.ConsoleApp.ModuloMesa;
using Restaurante.ConsoleApp.ModuloProduto;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Restaurante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());

            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaConta telaConta = new TelaConta(repositorioConta, repositorioGarcom, repositorioProduto, repositorioMesa);

            Menu menu = new Menu(telaProduto, telaMesa, telaGarcom, telaConta);

            #region//REGISTROS
            Produto produto0 = new Produto("vinho", 12);
            Produto produto1 = new Produto("bife", 15);
            Produto produto2 = new Produto("salame", 15);
            Produto produto3 = new Produto("arroz", 8);
            repositorioProduto.Inserir(produto0);
            repositorioProduto.Inserir(produto1);
            repositorioProduto.Inserir(produto2);
            repositorioProduto.Inserir(produto3);

            Mesa mesa0 = new Mesa("0");
            Mesa mesa1 = new Mesa("1");
            Mesa mesa2 = new Mesa("2");
            Mesa mesa3 = new Mesa("3");
            repositorioMesa.Inserir(mesa0);
            repositorioMesa.Inserir(mesa1);
            repositorioMesa.Inserir(mesa2);
            repositorioMesa.Inserir(mesa3);

            Garcom garcom0 = new Garcom("Marco", "8432790");
            Garcom garcom1 = new Garcom("João", "324234");
            Garcom garcom2 = new Garcom("Luis", "1111111");
            Garcom garcom3 = new Garcom("Felipe", "2222222");
            repositorioGarcom.Inserir(garcom0);
            repositorioGarcom.Inserir(garcom1);
            repositorioGarcom.Inserir(garcom2);
            repositorioGarcom.Inserir(garcom3);

            Conta conta0 = new Conta("0", mesa0, garcom0);
            Conta conta1 = new Conta("1", mesa1, garcom1);
            Conta conta2 = new Conta("2", mesa2, garcom2);
            Conta conta3 = new Conta("3", mesa3, garcom3);
            Pedido pedido0 = new Pedido(2, produto0);
            Pedido pedido1 = new Pedido(1, produto1);
            Pedido pedido2 = new Pedido(3, produto2);
            Pedido pedido3 = new Pedido(4, produto3);
            Pedido pedido4 = new Pedido(2, produto1);
            Pedido pedido5 = new Pedido(2, produto2);
            Pedido pedido6 = new Pedido(3, produto3);
            Pedido pedido7 = new Pedido(3, produto3);
            Pedido pedido8 = new Pedido(4, produto1);

            conta0.listaPedidos.Add(pedido0);
            conta0.listaPedidos.Add(pedido4);
            conta1.listaPedidos.Add(pedido5);
            conta1.listaPedidos.Add(pedido6);
            conta2.listaPedidos.Add(pedido1);
            conta2.listaPedidos.Add(pedido2);
            conta3.listaPedidos.Add(pedido3);
            conta3.listaPedidos.Add(pedido7);
            conta3.listaPedidos.Add(pedido8);

            repositorioConta.Inserir(conta0);
            repositorioConta.Inserir(conta1);
            repositorioConta.Inserir(conta2);
            repositorioConta.Inserir(conta3);

            #endregion

            menu.ExecutarMenuPrincipal();

        }
    }
}
