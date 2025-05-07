using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class RepositorioRevista
    {
        public Revista[] revista = new Revista[100];
        public int contadorRevista = 0;
    }

    public void CadastrarRevista(Revista novaRevista)
        {
            novaRevista.IdRevista = GeradorIds.GerarIdRevista();

            revista[contadorRevista++] = novaRevista;
        }

        public Revista[] SelecionarRevista()
        {
            return revista;
        }
    }
}
    


