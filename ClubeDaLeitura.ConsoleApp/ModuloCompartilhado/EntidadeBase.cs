using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloCompartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract void Validar(EntidadeBase entidade);


    }
}
