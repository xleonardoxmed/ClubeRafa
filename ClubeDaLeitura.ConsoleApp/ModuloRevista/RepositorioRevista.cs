using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista
    {
        public Revista[] revistas = new Revista[100];
        public int contadorRevista = 0;

        public void CadastrarRevista(Revista novaRevista)
        {
            novaRevista.IdRevista = GeradorIds.GerarIdRevista();

            revistas[contadorRevista++] = novaRevista;
        }

        public Revista[] SelecionarRevista()
        {
            return revistas;
        }

        public Revista SelecionarRevistaPorId(int idCaixaRevistaSelecionada)
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                Revista revista = revistas[i];

                if (revista == null)
                    continue;

                else if (revista.IdRevista == idCaixaRevistaSelecionada)
                    return revista;
            }

            return null;
        }
    }
}



