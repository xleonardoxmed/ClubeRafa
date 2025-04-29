namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
   
   public class Revista
    {
        public static int RevistaSelecionada = 0;

        public int IdRevista;
        public string TituloRevista;
        public int NumeroRevista;
        public int AnoPublicacao;
        public string CaixaPertencente;


        public Revista(string tituloRevista, int numeroRevista, int anoPublicacao, string caixaPertencente)
        {            
            TituloRevista = tituloRevista;
            NumeroRevista = numeroRevista;
            AnoPublicacao = anoPublicacao;
            CaixaPertencente = caixaPertencente;
        }


        public int HistoricoEmprestimosRevista()
        {
            RevistaSelecionada++;

            return RevistaSelecionada;
        }
    }
}
