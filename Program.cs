using Projeto1.Models;//Verifica o caminho lógico para a classe criada


int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um numero(0 para parar):");
    numero = Convert.ToInt32(Console.ReadLine());
    
    soma += numero;

} while (numero != 0);

Console.WriteLine($"O Total da soma dos números digitados é: {soma} ");














// int numero = 5;
// int contador = 0;
//
// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//     contador++;
//
//     if (contador == 6)
//     {
//         break;//testando a funcao break
//     }
// }





// int numero = 5;
//
// for (int contador = 0; contador < 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }
//
















//----------------------------------------------------------------------------------------------------------


// Calculadora calc = new Calculadora();

// calc.Somar(4, 2);
//
// calc.Subtrair(4 , 2);
//
// calc.Multiplicar(4, 2);
//
// calc.Dividir(4, 2);
//
// calc.Potencia(4, 2);
//
// calc.Seno(10);
//
// calc.Coseno(10);
//
// calc.Tangente(10);

// calc.RaizQuadrada(9);

//
// Console.WriteLine("\n-----------------------------\n");
//
// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);
//
// Console.WriteLine("\n-----------------------------\n");
//
// int numeroDecremento = 20;
// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;
//
// Console.WriteLine(numeroDecremento);


//----------------------------------------------------------------------------------------------------------




//----------------------------------------------------------------------------------------------------------


// bool choveu = false;
// bool isLate = false;
//
// if (!choveu && !isLate)//O ! é utilizado para negar uma variável, ou seja por padrão a variável é esperada como true, se receber um ! irá esperar false.
// {
//     Console.WriteLine("Pedalar");
// }
// else
// {
//     Console.WriteLine("Pedalar outro dia!");
// }
//
//



//----------------------------------------------------------------------------------------------------------







//----------------------------------------------------------------------------------------------------------


// bool possuiPresencaMinima = true;
// double media = 7.8;
//
// if (possuiPresencaMinima && media < 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

//----------------------------------------------------------------------------------------------------------












//----------------------------------------------------------------------------------------------------------


// bool maiorDeIdade = true;
// bool autorizacaoDoResponsavel = false;
//
// if (maiorDeIdade || autorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");// O Pipe: || funciona como o operador OR
// }
// else
// {
//     Console.WriteLine("Entrada nao liberada!");
// }


//----------------------------------------------------------------------------------------------------------















//----------------------------------------------------------------------------------------------------------

// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();
//
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");    
//         break;
//     
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();
//
// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")  
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Consoante");
// }






// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
//
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
//
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
//
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
//
// else
// {
//     Console.WriteLine("Consoante");
// }
//Essa é uma prática bem ruim, afinal o programa irá demorar para excutar, perderemos mais tempo escrevendo, será mais
//difícil de ler etc.


//----------------------------------------------------------------------------------------------------------









//----------------------------------------------------------------------------------------------------------
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
//
//
// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque} ");
// Console.WriteLine($"Quantidade de Compra: {quantidadeCompra} ");
// Console.WriteLine($"É Possível realizar a venda? {possivelVenda}");
//
// if (quantidadeCompra == 0)//Dois sinais de igual é uma comparação, um só é quando quer passar um valor para variável
// {
//     Console.WriteLine("Venda Invalida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
// }


//----------------------------------------------------------------------------------------------------------













//----------------------------------------------------------------------------------------------------------

// double a = 4 / (2 + 2);//parenteses define prioridade
//
// Console.WriteLine(a);

//----------------------------------------------------------------------------------------------------------










// //----------------------------------------------------------------------------------------------------------

// int a = 5;
// double b = a;

// // int a = 5;
// // long b = a;

// // Deve se atentar ao fato de que se trocarmos o Long pelo int, não irá funcionar pois a variável int não suporta a variável long, teriamos que fazer a conversão manualmente.
// // long a = 5;
// // int b = Convert.ToInt32(a);

// //Não irá funcionar pois o long suporta um número muito maior que o Int, logo o contrário irá funcionar.
// // long a = long.MaxValue;
// // int b = Convert.ToInt32(a);


// Console.WriteLine(5);

// //Casting Implicito



// //----------------------------------------------------------------------------------------------------------

















//----------------------------------------------------------------------------------------------------------


// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// //Tudo pode ser convertido para String a partir do ToString().

//----------------------------------------------------------------------------------------------------------



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