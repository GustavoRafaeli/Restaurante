using Restaurante.ConsoleApp.ModuloConta;
using Restaurante.ConsoleApp.ModuloGarcom;
using Restaurante.ConsoleApp.ModuloMesa;
using Restaurante.ConsoleApp.ModuloProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.ConsoleApp.InfraMenu
{
    public class Menu
    {
        public TelaProduto telaProduto = null;
        public TelaMesa telaMesa = null;
        public TelaGarcom telaGarcom = null;
        public TelaConta telaConta = null;

        public Menu(TelaProduto telaProduto, TelaMesa telaMesa, TelaGarcom telaGarcom, TelaConta telaConta)
        {
            this.telaProduto = telaProduto;
            this.telaMesa = telaMesa;
            this.telaGarcom = telaGarcom;
            this.telaConta = telaConta;
        }

        public void ExecutarMenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("(1) Gerenciar Produtos");
                Console.WriteLine("(2) Gerenciar Mesa");
                Console.WriteLine("(3) Gerenciar Garçom");
                Console.WriteLine("(4) Gerenciar Conta");
                Console.WriteLine("(S) Sair");
                Console.WriteLine("-------------------------------------");

                string opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1": MenuProduto(); break;
                    case "2": MenuMesa(); break;
                    case "3": MenuGarcom(); break;
                    case "4": MenuConta(); break;
                    case "S": VoltarAoMenu(); return;
                }
            }
        }
        public void MenuProduto()
        {
            while (true)
            {
                string opcao = telaProduto.ApresentarMenu();
                telaProduto.SelecionarOpcao(opcao);
                break;
            }
        }
        public void MenuMesa()
        {
            while (true)
            {
                string opcao = telaMesa.ApresentarMenu();
                telaMesa.SelecionarOpcao(opcao);
                break;
            }
        }
        public void MenuGarcom()
        {
            while (true)
            {
                string opcao = telaGarcom.ApresentarMenu();
                telaGarcom.SelecionarOpcao(opcao);
                break;
            }
        }
        public void MenuConta()
        {
            while (true)
            {
                string opcao = telaConta.ApresentarMenu();
                telaConta.SelecionarOpcao(opcao);
                break;
            }
        }
        public static void VoltarAoMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------");
            Console.WriteLine("|Voltando...|");
            Console.WriteLine("-------------");
            Console.ResetColor();
        }
    }
}
