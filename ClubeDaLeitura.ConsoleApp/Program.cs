using System.Collections.Concurrent;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static Cliente[] clientes = new Cliente[100];
        static int contadorClientes = 0;


        static Caixa[] caixas = new Caixa[100];
        static int contadorCaixa = 0;

        static Revista[] revistas = new Revista[100];
        static int contadorRevista = 0;

        static Emprestimo[] emprestimos = new Emprestimo[100];   //quando no caso de devolução, usar o contador negativo (--)
        static int contadorEmprestimo = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("CLUBE DA LEITURA");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            Console.WriteLine("Escolha a operação desejada: ");
            Console.WriteLine("1 - Gestão de clientes: ");
            Console.WriteLine("2 - Gestão de Caixas: ");
            Console.WriteLine("3 - Gestão de Revistas: ");
            Console.WriteLine("4 - Empréstimos e devoluções: ");

            string opcaoEscolhida = Console.ReadLine();

            switch (opcaoEscolhida)
            {
                case "1":
                    Console.WriteLine("------------------");
                    Console.WriteLine("Gestão de clientes");
                    Console.WriteLine("------------------");
                    Console.WriteLine();
                    Console.WriteLine("Escolha a operação desejada: ");
                    Console.WriteLine("1 - Cadastrar novo cliente: ");
                    Console.WriteLine("4 - Visualizar clientes: ");

                    string menuCliente = Console.ReadLine();

                    switch (menuCliente)
                    {
                        case "1":
                            {
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Cadastrando cliente...");
                                Console.WriteLine("----------------------");
                                Console.WriteLine();
                                Console.Write("Digite o nome do cliente: ");
                                string nomeCliente = Console.ReadLine();

                                Console.Write("Digite o nome do responsável: ");
                                string nomeResponsavel = Console.ReadLine();

                                Console.Write("Digite o telefone para contato: ");
                                int telefone = Convert.ToInt32(Console.ReadLine());

                                Cliente novoCliente = new Cliente(nomeCliente, nomeResponsavel, telefone);

                                clientes[contadorClientes++] = novoCliente;

                                break;
                            }

                        case "4":
                            {
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Visualizando cliente...");
                                Console.WriteLine("----------------------");
                                Console.WriteLine();

                                break;
                            }
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Gestão de caixas");
                        Console.WriteLine("------------------");
                        Console.WriteLine();
                        Console.WriteLine("Escolha a operação desejada: ");
                        Console.WriteLine("1 - Cadastrar nova caixa: ");
                        Console.WriteLine("4 - Visualizar caixa: ");

                        string menuCaixa = Console.ReadLine();

                        switch (menuCaixa)
                        {
                            case "1":
                                {
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Cadastrando caixa...");
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine();

                                    Console.Write("Digite o texto da etiqueta da caixa: ");
                                    string etiquetaCaixa = Console.ReadLine();

                                    Console.Write("Selecione a cor da caixa: ");
                                    string corCaixa = Console.ReadLine();

                                    Console.Write("Dias em que a caixa será emprestada (padrão: 7 dias): ");
                                    int diasEmprestimoCaixa = Convert.ToInt32(Console.ReadLine());

                                    Caixa novaCaixa = new Caixa(etiquetaCaixa, corCaixa, diasEmprestimoCaixa);
                                    caixas[contadorCaixa++] = novaCaixa;

                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Visualizando Caixas...");
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine();

                                    break;
                                }
                        }


                        break;
                    }

                case "3":
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Gestão de revistas");
                        Console.WriteLine("------------------");
                        Console.WriteLine();
                        Console.WriteLine("Escolha a operação desejada: ");
                        Console.WriteLine("1 - Cadastrar nova revista: ");
                        Console.WriteLine("4 - Visualizar revistas: ");

                        string menuRevista = Console.ReadLine();

                        switch (menuRevista)
                        {
                            case "1":
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Cadastrando revista...");
                                Console.WriteLine("----------------------");
                                Console.WriteLine();

                                Console.Write("Digite o título da revista: ");
                                string tituloRevista = Console.ReadLine();

                                Console.Write("Digite o número da edição da revista: ");
                                int numeroRevista = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Informe o ano de publicação da revista");
                                int anoPublicacao = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Informe a caixa que ela pertence");
                                string caixaPertencente = Console.ReadLine();

                                Revista novaRevista = new Revista(tituloRevista, numeroRevista, anoPublicacao, caixaPertencente);
                                revistas[contadorRevista++] = novaRevista;

                                break;

                            case "4":
                                {
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Visualizando Revistas...");
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine();

                                    break;
                                }
                        }

                        break;
                    }

                case "4":
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Gestão de empréstimos e devoluções");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Selecione a operação desejada: ");
                        Console.WriteLine();
                        Console.WriteLine("1 - Registrar novo empréstimo: ");
                        Console.WriteLine("2 - Registrar devolução: ");
                        Console.WriteLine("3 - Visualizar empréstimos: ");
                        Console.WriteLine();

                        string menuEmprestimo = Console.ReadLine();

                        switch (menuEmprestimo)
                        {
                            case "1":
                                {
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("Registrando empréstimo...");
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine();
                                    break;
                                }

                            case "2":
                                {
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("Registrando devolução...");
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine();
                                    break;
                                }

                            case "3":
                                {
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("Visualizando empréstimos...");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    break;
                                }
                        }


                        break;
                    }

                default:
                    {
                        Console.WriteLine("Saindo do programa...");
                        break;
                    }


                    Console.ReadLine();
            }
        }
    }
        
}
