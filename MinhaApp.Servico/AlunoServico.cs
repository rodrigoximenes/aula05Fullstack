using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Repositorio;
using MinhaApp.Dominio;
using MinhaApp.Servico.DTOs;

namespace MinhaApp.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public bool AdicionarAluno(AlunoDto alunoDto)
        {
            var aluno = new Aluno(alunoDto.Nome, alunoDto.Nota);
            _alunoRepositorio.Salvar(aluno);
            return aluno.EstaAprovado();
        }

        public List<AlunoDto> ListarAlunos()
        {
            return _alunoRepositorio.ObterTodos()
                .Select(aluno => new AlunoDto { Nome = aluno.Nome, Nota = aluno.Nota })
                .ToList();
        }
    }
}
