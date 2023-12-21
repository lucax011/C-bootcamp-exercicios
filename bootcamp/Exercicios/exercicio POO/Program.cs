
using C__project.Models;

PessoaFisica p = new PessoaFisica("Lucas", "Melo");

PessoaFisica p2 = new PessoaFisica("ton ton", "zavaglia");

Curso c1 = new Curso();

c1.Nome = "tecno";
c1.Alunos = new List<PessoaFisica>();

c1.AdicionaAluno(p);
c1.AdicionaAluno(p2);
c1.ListarAluno();

