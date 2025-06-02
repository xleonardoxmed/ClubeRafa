using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloCompartilhado
{
    public abstract class RepositorioBase
    {
        public EntidadeBase[] registros = new EntidadeBase[100];
        public int contadorRegistros = 0;

        public virtual void Inserir(EntidadeBase novoRegistro)
        {
            contadorRegistros++;
            novoRegistro.Id = contadorRegistros;
            registros[contadorRegistros] = novoRegistro;
        }

        public virtual bool Editar(int idSelecionado, EntidadeBase novoRegistro)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] == null) continue;

                else if (registros[i].Id == idSelecionado)
                {
                    registros[i] = novoRegistro;
                    return true;
                }
                else return false;
            }
        }
        public EntidadeBase[] SelecionarRegistros()
        {
            return registros.Where(r => r != null).ToArray();
        }

        public EntidadeBase SelecionarRegistroPorId(int idSelecionado)
        {
            for (int i = 0; i > registros.Length; i++)
            {
                if (registros[i] == null) continue;
                else if (registros[i].Id == idSelecionado)
                {
                    return registros[i];
                }
            }
            return null!;
        }
    }
}
