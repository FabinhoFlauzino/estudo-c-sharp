using exemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Fábio";
pessoa1.Idade = 38;

pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now;
Console.WriteLine("" + dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

//Tipos de dados no C#
string apresentacao = "Olá seja bem vindo!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine("variavel apresentacao " + apresentacao);
Console.WriteLine("variavel quantidade " + quantidade);
Console.WriteLine("variavel altura " + altura);
Console.WriteLine("variavel preco " + preco);
Console.WriteLine("variavel condicao " + condicao);


//atribuição
int a = 10;
int b = 20;
int c = a + b;

Console.WriteLine("a + b = " + c);

//convertendo variaveis
int d = Convert.ToInt32("5"); //convertendo para inteiro
int e = int.Parse("5"); //convertendo para inteiro
Console.WriteLine(d + e.ToString());//convertendo para string



