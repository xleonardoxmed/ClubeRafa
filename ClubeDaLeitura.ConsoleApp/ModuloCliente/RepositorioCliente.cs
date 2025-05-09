using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;

namespace ClubeDaLeitura.ConsoleApp.ModuloCliente
{
    public class RepositorioCliente
    {
        public Cliente[] clientes = new Cliente[100];
        public int contadorClientes = 0;  

    public void CadastrarCliente(Cliente novoCliente)
    {
        novoCliente.Id = GeradorIds.GerarIdCliente();
        clientes[contadorClientes++] = novoCliente;
    }

    public Cliente[] SelecionarClientes(int idSelecionado)
    {
            return clientes;
    }


    public Cliente SelecionarClientePorId(int idClienteSelecionado)
    {
            for (int i = 0; i < clientes.Length; i++)
            {
                Cliente cliente = clientes[i];

                if (cliente == null)
                    continue;

                else if (cliente.Id == idClienteSelecionado)
                    return cliente;
            }

            return null;
    }

    }
}
