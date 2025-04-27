namespace ClubeDaLeitura.ConsoleApp
{
    public static class GeradorIds
    {
        public static int IdCliente = 0;
        public static int IdCaixa = 0;
        public static int IdRevista = 0;
        public static int IdEmprestimo = 0;

        public static int GerarIdCliente()
        {
            IdCliente++;
            return IdCliente;

        }

        public static int GerarIdCaixa()
        {
            IdCaixa++;
            return IdCaixa;

        }

        public static int GerarIdRevista()
        {
            IdRevista++;
            return IdRevista;

        }

        public static int GerarIdEmprestimo()
        {
            IdEmprestimo++;
            return IdEmprestimo;
        }

    }
}
