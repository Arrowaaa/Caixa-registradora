using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto = "", marca = "";
            float preco =0;
            int menu;
            int quantidade =0;
            string loop = "s";
            string loop2 = "s";


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\r\n ____  _  ____  _____  _____ _      ____    ____  ____    ____  _____ _          _  ____  ____  ____ \r\n/ ___\\/ \\/ ___\\/__ __\\/  __// \\__/|/  _ \\  /  _ \\/  _ \\  / ___\\/  __// \\ /\\     / |/  _ \\/  _ \\/  _ \\\r\n|    \\| ||    \\  / \\  |  \\  | |\\/||| / \\|  | | \\|| / \\|  |    \\|  \\  | | ||     | || / \\|| / \\|| / \\|\r\n\\___ || |\\___ |  | |  |  /_ | |  ||| |-||  | |_/|| \\_/|  \\___ ||  /_ | \\_/|  /\\_| || \\_/|| |-||| \\_/|\r\n\\____/\\_/\\____/  \\_/  \\____\\\\_/  \\|\\_/ \\|  \\____/\\____/  \\____/\\____\\\\____/  \\____/\\____/\\_/ \\|\\____/\r\n                                                                                                     \r\n");
            Console.ResetColor();


            while (loop == "s") 
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Welcome Sr.  ");
            Console.WriteLine("MENU: ");
            Console.WriteLine("1 - Cadastrar novo Produto: ");
            Console.WriteLine("2 - Realizar venda de produto: ");
            Console.WriteLine("3 - Gerar relatório do produto: ");
            Console.Write("Escolha a Opção: ");
            menu = int.Parse(Console.ReadLine());
                Console.Clear();

                if (menu == 1)
                {
                    while (loop2 == "s")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        Console.WriteLine("\n Você escolheu CADASTRAR um produto? ");

                        Console.Write("\n Qual é o Produto que deseja cadastrar? ");
                        produto = Console.ReadLine();

                        Console.Write("\n Qual a marca do produto ? ");
                        marca = Console.ReadLine();

                        Console.Write("\n Qual é o preço do produto ? ");
                        preco = float.Parse(Console.ReadLine());

                        Console.Write("\n Qual é a quantidade do produto ? ");
                        quantidade = int.Parse(Console.ReadLine());




                        Console.WriteLine("\nO produto cadastrado foi: ");
                        Console.WriteLine("Produto: " + produto);
                        Console.WriteLine("Marca: " + marca);
                        Console.WriteLine("Quantidade: " + quantidade);
                        Console.WriteLine("Preço: " + preco);


                        Console.Clear() ;
                        Console.Write("Deseja Fazer um novo cadrastro ? (s/n) ");
                        loop2 = Console.ReadLine();


                    }
                }

                else if (menu == 2)
                {
                    Console.WriteLine("Você escolheu VENDER/COMPRAR um produto: ");
                    float valor = float.Parse(Console.ReadLine());
                    // Realizar a lógica de venda/compra aqui com o valor informado.
                }
                else if (menu == 3)
                {
                    //Console.WriteLine("Você Escolheu gerar um Relatório do Produto? ")

                    Console.WriteLine("Bem Vindo Ao Relatório!!");
                    Console.WriteLine("Produto : " + produto + "Marca:  " + marca + " -  Estoque: " + quantidade + " - Valor: " + preco);
                    

                    // Gerar relatório do produto aqui.
                }
                else if (menu == 4)
                {
                    // Console.Write("Digite uma frase: ");
                    //   string frase = Console.ReadLine();

                    //  Console.WriteLine(frase.ToUpper);
                    //   Console.WriteLine(frase.ToLower);


                }
                else
                {
                    Console.WriteLine("Opção inválida. Escolha uma opção válida do menu.");
                    Console.Write("Deseja Regreçar ao MENU? (s/n) ");
                    loop = Console.ReadLine();

                }

            Console.ReadKey();
                //ToUpper Converte todos os strimer em Maiusculo.
                //ToLower Converte todos os strimer em Menusculo.
                //While Comando de loop
                //Console.ForegroundColor = ConsoleColor.DarkRed; // Altera a cor da fontes

            }

        }
    }
}