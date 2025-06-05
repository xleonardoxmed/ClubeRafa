using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class RepositorioCaixa : RepositorioBase
    {
        public void CadastrarRegistro(EntidadeBase novoRegistro)
        {
            novoRegistro.Id = contadorRegistros++;
            registros[contadorRegistros] = novoRegistro;
        }

        public bool Editar(int idCaixa, Caixa caixaEditada)
        {
            bool conseguiuEditar = false;

            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] == null) continue;

                else if (registros[i].Id == idCaixa)
                {
                    registros[i].Editar(caixaEditada);

                    conseguiuEditar = true;
                }                
            }

            return conseguiuEditar;
        }

        public bool ExcluirCaixa(int idCaixa)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] == null) continue;

                else if (registros[i].Id == idCaixa)
                {
                    registros[i] = null;

                    return true;
                }
            }

            return false;            
        }

        public EntidadeBase[] SelecionarTodasCaixas()
        {
            return registros;
        }

        public Caixa SelecionarCaixaPorId(int idCaixaRevistaSelecionada)
        {
            for(int i = 0; i < registros.Length; i++)
            {
                Caixa caixa = (Caixa)registros[i];

                if (caixa == null) 
                    continue;

                else if (caixa.Id == idCaixaRevistaSelecionada)
                    return caixa;
            }

            return null;
        }

        
    }
}
