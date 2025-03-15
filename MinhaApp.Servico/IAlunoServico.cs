using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Servico
{
    public interface IAlunoServico
    {
        bool AdicionarAluno(string nome, decimal nota);
    }
}
