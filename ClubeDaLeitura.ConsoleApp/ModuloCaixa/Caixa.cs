namespace ClubeDaLeitura.ConsoleApp.RepositorioCaixa
{
  public  class Caixa
    {
        public int IdCaixa;
        public string EtiquetaCaixa;
        public string CorCaixa;
        public int DiasEmprestimoCaixa;


        public Caixa(string etiquetaCaixa, string corCaixa, int diasEmprestimoCaixa)
        {
            EtiquetaCaixa = etiquetaCaixa;
            CorCaixa = corCaixa;
            DiasEmprestimoCaixa = diasEmprestimoCaixa;
        }

    }


}
