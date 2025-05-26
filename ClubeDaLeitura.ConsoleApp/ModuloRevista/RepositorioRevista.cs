using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista
    {
        public Revista[] revistas = new Revista[100];
        public int contadorRevista = 0;

        public bool EditarRevista(int idSelecionado, Revista novaRevista)
        {
            bool conseguiuEditar = false;

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].IdRevista == idSelecionado)
                {
                    revistas[i].TituloRevista = novaRevista.TituloRevista;
                    revistas[i].NumeroRevista = novaRevista.NumeroRevista;
                    revistas[i].AnoPublicacao = novaRevista.AnoPublicacao;
                    revistas[i].CaixaPertencente = novaRevista.CaixaPertencente;

                    conseguiuEditar = true;
                }
            }

            return conseguiuEditar;

        }

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

        public bool ExcluirRevista(int idSelecionado)
        {
            bool conseguiuExcluir = false;

            for (int i = 0;i < revistas.Length;i++)
            {
                if (revistas[i] == null)
                    continue;

                else if (revistas[i].IdRevista == idSelecionado)
                {
                    revistas[i] = null;

                    conseguiuExcluir = true;
                }
            }
            return conseguiuExcluir;
        }
    }
}



