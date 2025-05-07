using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloCliente
{
    public class RepositorioCliente
    {
        public Cliente[] clientes = new Cliente[100];
        public int contadorClientes = 0;
 
    }

    public void CadastrarCliente(Cliente novoCliente)
    {
        novoCliente.Id = GeradorIds.GerarIdCliente();
        clientes[contadorClientes++] = novoCliente;
    }

        public Cliente[] SelecionarClientes()
        {
            return clientes;
        }
    }
}
