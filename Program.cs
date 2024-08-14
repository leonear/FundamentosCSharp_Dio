using Projeto1.Models;//Verifica o caminho lógico para a classe criada





int inteiro = 5;
string a = inteiro.ToString();

Console.WriteLine(a);

//Tudo pode ser convertido para String a partir do ToString().

















//----------------------------------------------------------------------------------------------------------


//int a = Convert.ToInt32("5");//casting - conversão de variável
//int a = int.Parse("5c"); //5c vai dar errado pois não esta no formato correto, temos que tomar cuidado quando convertemos, por que o input tem que estar de acordo com o formato iniciado.

//Convert vai entender um valor nulo como 0.
//Parse não aceita valores nulos, enviando assim uma exceção.

//Console.WriteLine(a);

//----------------------------------------------------------------------------------------------------------






//----------------------------------------------------------------------------------------------------------
// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5; //30 + 5
// //c += 5;


// Console.WriteLine(c);

//----------------------------------------------------------------------------------------------------------
 


//----------------------------------------------------------------------------------------------------------
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
//----------------------------------------------------------------------------------------------------------



//----------------------------------------------------------------------------------------------------------
// string apresentacao = "Ola, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80; //double sempre vai ignorar o 0

// decimal preco = 1.80M;//por estar declarando um valor diretamente a variavel decimal pede esse "m" no final

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura);
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);
//----------------------------------------------------------------------------------------------------------




//----------------------------------------------------------------------------------------------------------
// Pessoa pessoa1 = new Pessoa();//p é a variável, pode ter qualquer nome

// pessoa1.Nome = "Leo";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();//método