using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__project.Models
{
    public class Curso
    {
     
        public String Nome { get; set; }
        public List<PessoaFisica> Alunos {get;set;}

        public void AdicionaAluno(PessoaFisica aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAluno()
        {
      
        int quantidadeAlunos = Alunos.Count();
        
        return quantidadeAlunos;
        
        }
        public bool RemoveAluno(PessoaFisica aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAluno()
        {
            string titulo = $"Alunos que pertencem ao curso {Nome}";
            
            Console.WriteLine(titulo);
           
            int quantidadeAlunos = ObterQuantidadeAluno();
           
            for (int contador = 0; contador < quantidadeAlunos; contador++){

                int exibicao = contador + 1;
                string texto = $"N: {exibicao} - {Alunos[contador].NomeCompleto}";
                Console.WriteLine(texto);

                
            }
        }
    }
}