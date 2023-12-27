
using C__project.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");
estados.Add("CE","Ceará");

foreach (var item in estados)
{
    Console.WriteLine($"Sigla: {item.Key}\nEstado: {item.Value}");
}

Console.WriteLine("------------");

estados.Remove("CE");

estados["SP"] = "Sao Paulo";

foreach (var item in estados)
{
    Console.WriteLine($"Sigla: {item.Key}\nEstado: {item.Value}");
}


string chave = "BA";

Console.WriteLine($"verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"chave existente: {chave}");
}else
{
    Console.WriteLine($"Valor não existente. É seguro adiocionar a {chave} ao dictionary");
}

Console.WriteLine(estados["MG"]);

// Stack<int> pilha = new Stack<int>();

// pilha.Push(10);
// pilha.Push(7);
// pilha.Push(2);
// pilha.Push(5);


// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"removemos o topo {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(7);
// fila.Enqueue(1);

// foreach(int item in fila){

//     Console.WriteLine(item);

// }

// Console.WriteLine($"removendo o elemento {fila.Dequeue()}");
// fila.Enqueue(10); 


// foreach (int item in fila)
// {

//     Console.WriteLine(item);

// }















// new Exceções().Metodo1(); 


// try
// {

// string [] linhas = File.ReadAllLines("Arquivos/leitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);   
// }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"erro na localização do arquivo: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"erro no caminho desta pasta: {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Houve uma exceção genérica : {ex.Message}");
// }finally{
//     Console.WriteLine("deu bom mano");
// }











// using C__project.Models;

// PessoaFisica p = new PessoaFisica("Lucas", "Melo");

// PessoaFisica p2 = new PessoaFisica("ton ton", "zavaglia");

// Curso c1 = new Curso();

// c1.Nome = "tecno";
// c1.Alunos = new List<PessoaFisica>();

// c1.AdicionaAluno(p);
// c1.AdicionaAluno(p2);
// c1.ListarAluno();

