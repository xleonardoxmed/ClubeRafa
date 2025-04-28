using ClubeDaLeitura.ConsoleApp.RepositorioCaixa;
using ClubeDaLeitura.ConsoleApp.RepositorioCliente;
using ClubeDaLeitura.ConsoleApp.RepositorioEmprestimo;
using ClubeDaLeitura.ConsoleApp.RepositorioRevista;
using System.Collections.Concurrent;

namespace ClubeDaLeitura.ConsoleApp.RepositorioCompartilhado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaCliente telaCliente = new TelaCliente();
            TelaCaixa telaCaixa = new TelaCaixa();
            TelaRevista telaRevista = new TelaRevista();
            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();

            while (true)

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
                    string menuCliente = telaCliente.ApresentarMenuCliente();                        

                        switch (menuCliente)
                        {
                            case "1":                                
                                    telaCliente.CadastrarCliente(); break;
                            case "2":                                
                                    telaCliente.EditarCliente(); break;
                            case "3":                                
                                    telaCliente.ExcluirCliente(); break;
                            case "4":                                
                                    telaCliente.VisualizarCliente(true); break;                                
                        }
                        break;

                    case "2":
                        {
                            string menuCaixa = telaCaixa.ApresentarMenuCaixa();

                            switch (menuCaixa)
                            {
                                case "1":                                    
                                        telaCaixa.CadastrarCaixa(); break;                                    
                                case "2":                                    
                                        telaCaixa.EditarCaixa(); break;                                    
                                case "3":                                    
                                        telaCaixa.ExcluirCaixa(); break;                                    
                                case "4":                                    
                                        telaCaixa.VisualizarCaixa(true); break;                                                                          
                            }
                        }
                        break;                        

                    case "3":
                        {
                            string menuRevista = telaRevista.ApresentarMenuRevista();

                            switch (menuRevista)
                            {
                                case "1":
                                    telaRevista.CadastrarRevista(); break;
                                case "2":
                                    telaRevista.EditarRevista(); break;
                                case "3":
                                    telaRevista.ExcluirRevista(); break;
                                case "4":                                    
                                    telaRevista.VisualizarRevista(true); break;                                                          
                            }
                            break;
                        }

                    case "4":
                        {
                            string menuEmprestimo = telaEmprestimo.ApresentarMenuEmprestimo();

                            switch (menuEmprestimo)
                            {
                                case "1":                                    
                                        telaEmprestimo.RegistrarEmprestimo(); break;
                                case "2":                                    
                                        telaEmprestimo.RegistrarDevolucao(); break;
                                case "3":                                    
                                        telaEmprestimo.VisualizarEmprestimo(); break;                                    
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Saindo do programa..."); break;
                        }                        
                }
                Console.ReadLine();
            }
        }
    }        
}