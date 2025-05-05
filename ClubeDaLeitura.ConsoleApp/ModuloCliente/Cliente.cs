namespace ClubeDaLeitura.ConsoleApp.ModuloCliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string NomeResponsavel { get; set; }
        public int Telefone { get; set; }


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
