using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloCliente;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista
    {
        public Revista[] revista = new Revista[100];
        public int contadorRevista = 0;

;
    public void CadastrarRevista(Revista novaRevista)
        {
            novaRevista.IdRevista = GeradorIds.GerarIdRevista();

            revista[contadorRevista++] = novaRevista;
        }

        public Revista[] SelecionarRevista()
        {
            return revista;
        }

        public Revista SelecionarRevistaPorId(int idCaixaRevistaSelecionada)
        {
            for (int i = 0; i < revista.Length; i++)

            {
                Revista revista = revista[i];

                if (revista == null)
                    continue;

                else if (revista.IdRevista == idCaixaRevistaSelecionada)
                    return revista;
            }

            return null;
        }
    }
}
    


