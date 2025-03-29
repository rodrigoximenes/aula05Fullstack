using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Servico.DTOs;

namespace MinhaApp.Servico
{
    public interface IAlunoServico
    {
        bool AdicionarAluno(AlunoDto alunoDto);
        List<AlunoDto> ListarAlunos();
    }
}
