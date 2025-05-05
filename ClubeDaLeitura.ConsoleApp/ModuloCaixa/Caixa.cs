namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
  public  class Caixa
    {
        public int IdCaixa { get; set; }
        public string EtiquetaCaixa { get; set; }
        public string CorCaixa { get; set; }
        public int DiasEmprestimoCaixa { get; set; }


        public Caixa(string etiquetaCaixa, string corCaixa, int diasEmprestimoCaixa)
        {
            EtiquetaCaixa = etiquetaCaixa;
            CorCaixa = corCaixa;
            DiasEmprestimoCaixa = diasEmprestimoCaixa;
        }

    }


}
