namespace ClubeDaLeitura.ConsoleApp
{
    public class TelaRevista
    {
        public Revista[] revistas = new Revista[100];
        public int contadorRevista = 0;
        public string ApresentarMenuRevista()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Gestão de revistas");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Escolha a operação desejada: ");
            Console.WriteLine("1 - Cadastrar nova revista: ");
            Console.WriteLine("4 - Visualizar revistas: ");

            string menuRevista = Console.ReadLine();

            return menuRevista;
        }

        public void CadastrarRevista()
        {
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
            novaRevista.IdRevista = GeradorIds.GerarIdRevista;

            revistas[contadorRevista++] = novaRevista;
        }

        public void EditarRevista()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Editando Revistas...");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            VisualizarRevista(false);

            Console.Write("Digite o ID da revista que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o título da revista: ");
            string tituloRevista = Console.ReadLine();

            Console.Write("Digite o número da edição da revista: ");
            int numeroRevista = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o ano de publicação da revista");
            int anoPublicacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a caixa que ela pertence");
            string caixaPertencente = Console.ReadLine();

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
                    Console.WriteLine("Houve um erro durante a edição das informações da revista...");
                    return;
                };

                Console.WriteLine("As informações da revista foram editadas com sucesso!");
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
                    Console.WriteLine("Houve um erro durante a exclusão da revista...");
                }

                Console.WriteLine("A revista foi devidamente excluída do sistema.");
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

    }
}

