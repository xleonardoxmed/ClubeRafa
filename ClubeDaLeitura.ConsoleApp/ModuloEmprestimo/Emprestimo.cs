using ClubeDaLeitura.ConsoleApp.RepositorioRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
  public  class Emprestimo
    {
        public int Id;
        public string ClienteSelecionado;
        public Revista Revista;
        public DateTime DataEmprestimo;
        public DateTime DataDevolucao;


        public Emprestimo(string clienteSelecionado, string revista, DateTime dataEmprestimo)
        {            
            ClienteSelecionado = clienteSelecionado;
            Revista = revista;
            DataEmprestimo = DateTime.Today;
            
        }

        public int TempoCorridoEmprestimo()
        {
            TimeSpan tempoTotalEmprestimo = DateTime.Now.Subtract(DataEmprestimo);

            return tempoTotalEmprestimo.Days;
        }
    }
}
