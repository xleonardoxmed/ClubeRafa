using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;
using System;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class TelaRevista
    {
        public TelaCaixa TelaCaixa;

        public string ApresentarMenuRevista()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Gestão de revistas");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Escolha a operação desejada: ");
            Console.WriteLine("1 - Cadastrar nova revista: ");
            Console.WriteLine("2 - Editar uma revista já cadastrada: ");
            Console.WriteLine("3 - Excluir revista: ");
            Console.WriteLine("4 - Visualizar revistas: ");

            string menuRevista = Console.ReadLine();

            return menuRevista;
        }

        public void CadastrarRevista()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Cadastrando revista...");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.Write("Digite o título da revista: ");
            string tituloRevista = Console.ReadLine()!.Trim();

            Console.Write("Digite o número da edição da revista: ");
            int numeroRevista = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o ano de publicação da revista");
            int anoPublicacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a caixa que ela pertence");
            string caixaPertencente = Console.ReadLine()!.Trim();

            VisualizarCaixas();

            Revista novaRevista = new Revista(tituloRevista, numeroRevista, anoPublicacao, caixaPertencente);
            novaRevista.IdRevista = GeradorIds.GerarIdRevista();

            revistas[contadorRevista++] = novaRevista;

            Notificador.ExibirMensagem("A revista foi cadastrada com sucesso!", ConsoleColor.Green);
        }

        public void EditarRevista()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Editando Revistas...");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            VisualizarRevista(false);

            Console.Write("Digite o ID da revista que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o título da revista: ");
            string tituloRevista = Console.ReadLine()!.Trim();

            Console.Write("Digite o número da edição da revista: ");
            int numeroRevista = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o ano de publicação da revista");
            int anoPublicacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a caixa que ela pertence");
            string caixaPertencente = Console.ReadLine()!.Trim();

            Revista novaRevista = new Revista(tituloRevista, numeroRevista, anoPublicacao, caixaPertencente);

            bool conseguiuEditar = false;

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].idRevista == idSelecionado)
                {
                    revistas[i].TituloRevista = novaRevista.TituloRevista;
                    revistas[i].NumeroRevista = novaRevista.NumeroRevista;
                    revistas[i].AnoPublicacao = novaRevista.AnoPublicacao;
                    revistas[i].CaixaPertencente = novaRevista.CaixaPertencente;

                    conseguiuEditar = true;
                }

                if (!conseguiuEditar)
                {
                    Notificador.ExibirMensagem("Houve um erro durante a edição das informações...", ConsoleColor.Red);
                    return;
                };

                Notificador.ExibirMensagem("A revista foi editada com sucesso!", ConsoleColor.Green);
            }
        }

        public void ExcluirRevista()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Exlcuindo revista...");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            VisualizarRevista(false);

            Console.Write("Digite o ID da revista que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].IdRevista == idSelecionado)
                {
                    revistas[i] = null;

                    conseguiuExcluir = true;
                }

                if (!conseguiuExcluir)
                {
                    Notificador.ExibirMensagem("Houve um erro durante a exclusão da revista...", ConsoleColor.Red);
                }

                Notificador.ExibirMensagem("A revista foi devidamente excluída do sistema.", ConsoleColor.Green);
            }

        }

        public void VisualizarRevista(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Visualizando Revistas...");
                Console.WriteLine("----------------------");
                Console.WriteLine();
            }

            Console.WriteLine("{0, - 8} | {1, -15} | {2, -8} | {3, -8} | {4, -8}",
                              "ID", "Título", "Número", "Ano Publicação", "Caixa");

            for (int i = 0; i < revistas.Length; i++)
            {
                Revista revistaSelecionada = revistas[i];

                if (revistaSelecionada == null) continue;

                Console.WriteLine("{0, - 8} | {1, -15} | {2, -8} | {3, -8} | {4, -8}",
revistaSelecionada.IdRevista, revistaSelecionada.TituloRevista, revistaSelecionada.NumeroRevista, revistaSelecionada.AnoPublicacao, revistaSelecionada.CaixaPertencente);

            }

        }

        public void VisualizarCaixas()
        {

        }

    }
}

