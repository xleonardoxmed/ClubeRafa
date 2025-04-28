using ClubeDaLeitura.ConsoleApp.RepositorioCompartilhado;
using System;

namespace ClubeDaLeitura.ConsoleApp.RepositorioCaixa
{
    public class TelaCaixa
    {
        public Caixa[] caixas = new Caixa[100];
        public int contadorCaixa = 0;
        public string ApresentarMenuCaixa()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Gestão de caixas");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Escolha a operação desejada: ");
            Console.WriteLine("1 - Cadastrar nova caixa: ");
            Console.WriteLine("4 - Visualizar caixa: ");

            string menuCaixa = Console.ReadLine();

            return menuCaixa;
        }

        public void CadastrarCaixa()
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
            novaCaixa.IdCaixa = GeradorIds.GerarIdCaixa();

            caixas[contadorCaixa++] = novaCaixa;
        }

        public void EditarCaixa()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Editando Caixa...");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            VisualizarCaixa(false);

            Console.WriteLine("Digite o ID da caixa que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o texto da etiqueta da caixa: ");
            string etiquetaCaixa = Console.ReadLine()!.Trim();

            Console.Write("Selecione a cor da caixa: ");
            string corCaixa = Console.ReadLine()!.Trim();

            Console.Write("Dias em que a caixa será emprestada (padrão: 7 dias): ");
            int diasEmprestimoCaixa = Convert.ToInt32(Console.ReadLine());

            Caixa novaCaixa = new Caixa(etiquetaCaixa, corCaixa, diasEmprestimoCaixa);

            bool conseguiuEditar = false;

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null) continue;

                else if (caixas[i].IdCaixa == idSelecionado)
                {
                    caixas[i].EtiquetaCaixa = novaCaixa.EtiquetaCaixa;
                    caixas[i].CorCaixa = novaCaixa.CorCaixa;
                    caixas[i].DiasEmprestimoCaixa = novaCaixa.DiasEmprestimoCaixa;

                    conseguiuEditar = true;
                }

                if (!conseguiuEditar)
                {
                    Console.WriteLine("Houve um erro durante a edição das informações da caixa...");
                    return;
                }

                Console.WriteLine("As informações da caixa foram editadas com sucesso!");
            }
        }

        public void ExcluirCaixa()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Excluindo caixa...");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            VisualizarCaixa(false);

            Console.WriteLine();
            Console.Write("Digite o ID da caixa que deseja excluir: ");

            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null) continue;

                else if (caixas[i].IdCaixa == idSelecionado)
                {
                    caixas[i] = null;

                    conseguiuExcluir = true;
                }

                if (!conseguiuExcluir)
                {
                    Console.WriteLine("Houve um erro durante a exclusão da caixa...");
                }

                Console.WriteLine("A caixa foi devidamente excluída do sistema!");
            }

        }

        public void VisualizarCaixa(bool exibirMenu)
        {
            if (exibirMenu)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Visualizando Caixas...");
                Console.WriteLine("----------------------");
                Console.WriteLine();
            }

            Console.WriteLine("{0, - 8} | {1, -15} | {2, -10} | {3, -10}",
                                 "ID Caixa", "Etiqueta", "Cor", "Status");

            for (int i = 0; i < caixas.Length; i++)
            {
                Caixa caixaSelecionada = caixas[i];

                if (caixaSelecionada == null) continue;

                Console.WriteLine("{0, - 8} | {1, -15} | {2, -10} | {3, -10}",
caixaSelecionada.IdCaixa, caixaSelecionada.EtiquetaCaixa, caixaSelecionada.CorCaixa, caixaSelecionada.DiasEmprestimoCaixa);

            }

        }


    }
}
