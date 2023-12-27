using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace C__project.Models
{
    public class PessoaFisica
    {

        public PessoaFisica (String nome ,String sobrenome){
             Nome = nome;
             Sobrenome = sobrenome;
        }
        private String _nome;
        private String _sobrenome;
        private int _idade;
        public string Nome
        {

            get => _nome;
            
            set
            {
                if (value == null || value == "")
                {

                    throw new ArgumentException("nome invalido");

                }
                _nome = value;
            }
        }
        public int Idade
        {
            get => _idade;
            
            set{
                if(value < 0 ){

                    throw new ArgumentException("idade invalido");

                }   
                _idade = value;
            }
        }
        public String Sobrenome {
            get => _sobrenome;

            set
            {
                if (value == null || value == "")
                {

                    throw new ArgumentException("sobrenome invalido");

                }
                _sobrenome = value;
            }


        }

        public  String NomeCompleto => $"{Nome} {Sobrenome}";
        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome e {NomeCompleto} e minha idade {Idade}!");
        }

    }
}