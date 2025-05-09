using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloCliente;
using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    class TelaEmprestimo
    {
        public RepositorioEmprestimo repositorioEmprestimo;
        public RepositorioCaixa repositorioCaixa;
        public RepositorioCliente repositorioCliente;
        public RepositorioRevista repositorioRevista;

        public TelaEmprestimo(RepositorioEmprestimo repositorioEmprestimo, RepositorioCaixa repositorioCaixa, RepositorioCliente repositorioCliente, RepositorioRevista repositorioRevista)
        {
            this.repositorioEmprestimo = repositorioEmprestimo;
            this.repositorioCaixa = repositorioCaixa;
            this.repositorioCliente = repositorioCliente;
            this.repositorioRevista = repositorioRevista;
        }

        public TelaEmprestimo(TelaCaixa telaCaixa, TelaCliente telaCliente, TelaRevista telaRevista)
        {
            TelaCaixa = telaCaixa;
            TelaCliente = telaCliente;
            TelaRevista = telaRevista;
        }

        public TelaCaixa TelaCaixa { get; set; }
        public TelaCliente TelaCliente { get; set; }
        public TelaRevista TelaRevista { get; set; }

        public string ApresentarMenuEmprestimo()
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

            return menuEmprestimo;
        }

        public void RegistrarEmprestimo()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Registrando empréstimo...");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.Write("Digite o ID do cliente: ");
            int idClienteSelecionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o ID da revista desejada: ");
            int idRevistaSelecionada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Cliente clienteSelecionado = repositorioCliente.SelecionarClientePorId(idClienteSelecionado);
            
            Revista revistaSelecionada = repositorioRevista.SelecionarRevistaPorId(idRevistaSelecionada);

            Emprestimo novoEmprestimo = new Emprestimo(clienteSelecionado, revistaSelecionada, DateTime.Now);

            Notificador.ExibirMensagem("O registro foi concluído com sucesso!", ConsoleColor.Green);

        }

        public void RegistrarDevolucao()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Registrando devolução...");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.Write("Digite o ID do cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());

        }

        public void VisualizarEmprestimo()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Visualizando empréstimos...");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            Console.WriteLine("{0, - 8} | {1, -12} | {2, -12} | {3, -10}",
                              "ID", "Nome", "Responsável", "Contato");

            Console.WriteLine();
            Console.Write("Digite o ID do cliente que deseja visualizar: ");

            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Cliente[] clientesCadastrados = RepositorioCliente.SelecionarClientes(idSelecionado);

            for (int i = 0; i < clientesCadastrados.Length; i++)
            {
                Cliente clienteSelecionado = clientesCadastrados[i];

                if (clienteSelecionado == null)
                    continue;

                Console.WriteLine("{0, - 8} | {1, -12} | {2, -12} | {3, -10}",
                clienteSelecionado.Id, clienteSelecionado.NomeCliente, clienteSelecionado.NomeResponsavel, clienteSelecionado.Telefone);
            }

        }

    }
}
