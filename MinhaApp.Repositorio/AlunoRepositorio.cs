using MinhaApp.Dominio;

namespace MinhaApp.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly MinhaAppDbContext _context;

        public AlunoRepositorio(MinhaAppDbContext context)
        {
            _context = context;
        }

        public List<Aluno> ObterTodos()
        {
            return _context.Alunos.ToList();
        }

        public void Salvar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }
    }
}
