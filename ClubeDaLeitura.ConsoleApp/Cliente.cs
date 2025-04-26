namespace ClubeDaLeitura.ConsoleApp
{
    public class Cliente
    {
        public int Id;
        public string NomeCliente;
        public string NomeResponsavel;
        public int Telefone;


        public Cliente(string nomeCliente, string nomeResponsavel, int telefone)
        {
            NomeCliente = nomeCliente;
            NomeResponsavel = nomeResponsavel;
            Telefone = telefone;
        }


        public string HistoricoEmprestimos()    //utilizar a revista que o usuário pegou emprestada e usar a aula Regras de Negócio 03
        {

            return "";
        }
    }
}
