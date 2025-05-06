using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloCliente;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    class TelaEmprestimo
    {
        public Emprestimo[] emprestimos = new Emprestimo[100];   //quando no caso de devolução, usar o contador negativo (--)
        public int contadorEmprestimo = 0;

        public TelaEmprestimo(TelaCaixa telaCaixa, TelaCliente telaCliente, TelaRevista telaRevista)
        {
            TelaCaixa = telaCaixa;
            TelaCliente = telaCliente;
            TelaRevista = telaRevista;
        }

        public TelaCaixa TelaCaixa { get; }
        public TelaCliente TelaCliente { get; }
        public TelaRevista TelaRevista { get; }

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
            int idCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o ID da revista/caixa desejada: ");
            int idCaixaRevista = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
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

            Console.Write("Digite o ID do cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());

        }

    }
}
