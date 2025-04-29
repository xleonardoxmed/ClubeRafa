using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class RepositorioCaixa
    {
        public Caixa[] caixas = new Caixa[100];
        public int contadorCaixa = 0;


        public void CadastrarCaixa(Caixa novaCaixa)
        {
            novaCaixa.IdCaixa = GeradorIds.GerarIdCaixa();
            caixas[contadorCaixa++] = novaCaixa;
        }

        public bool EditarCaixa(int idCaixa, Caixa caixaEditada)
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null) continue;

                else if (caixas[i].IdCaixa == idCaixa)
                {
                    caixas[i].EtiquetaCaixa = caixaEditada.EtiquetaCaixa;
                    caixas[i].CorCaixa = caixaEditada.CorCaixa;
                    caixas[i].DiasEmprestimoCaixa = caixaEditada.DiasEmprestimoCaixa;

                    return true;
                }                
            }
        }

        public bool ExcluirCaixa(int idCaixa)
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null) continue;

                else if (caixas[i].IdCaixa == idCaixa)
                {
                    caixas[i] = null;

                    return true;
                }
            }

            return false;            
        }

        public Caixa[] SelecionarCaixa()
        {
            return caixas;
        }
    }
}
