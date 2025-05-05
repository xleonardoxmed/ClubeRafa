using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
  public  class Emprestimo
    {
        public int Id;
        public string ClienteSelecionado { get; set; }
        public Revista Revista { get; set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }


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
