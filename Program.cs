using Projeto1.Models;//Verifica o caminho lógico para a classe criada

string apresentacao = "Ola, seja bem vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;//por estar declarando um valor diretamente a variavel decimal pede esse "m" no final

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel quantidade: " + quantidade);
Console.WriteLine("Valor da variavel altura: " + altura);
Console.WriteLine("Valor da variavel preco: " + preco);
Console.WriteLine("Valor da variavel condicao: " + condicao);


// Pessoa pessoa1 = new Pessoa();//p é a variável, pode ter qualquer nome

pessoa1.Nome = "Leo";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();//método