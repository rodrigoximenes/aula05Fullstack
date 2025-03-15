using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Repositorio;
using MinhaApp.Dominio;

namespace MinhaApp.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public bool AdicionarAluno(string nome, decimal nota)
        {
            var aluno = new Aluno(nome, nota);
            _alunoRepositorio.Salvar(aluno);
            return aluno.EstaAprovado();
        }
    }
}
