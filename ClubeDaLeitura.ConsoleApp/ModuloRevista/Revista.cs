namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
   
   public class Revista
    {
        public static int RevistaSelecionada = 0;

        public int IdRevista { get; set; }
        public string TituloRevista { get; set; }
        public int NumeroRevista { get; set; }
        public int AnoPublicacao { get; set; }
        public string CaixaPertencente { get; set; }

        public string NumeroSerie
        {
            get
            {
                string tresPrimeirosCaracteres = TituloRevista.Substring(0, 3).ToUpper();

                return $"{tresPrimeirosCaracteres}-{IdRevista}";
            }
        }


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
