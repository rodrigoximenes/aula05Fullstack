using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Dominio;

namespace MinhaApp.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Salvar(Aluno aluno);
        List<Aluno> ObterTodos();
    }
}
