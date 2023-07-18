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

//Exemplo operador condicional
int tempoDeEspera = 10;
int tempoPassado = 4;

Console.WriteLine($"Tempo de espera é de {tempoPassado} minutos");

if (tempoDeEspera >= tempoPassado)
{
  Console.WriteLine("Aguardar ônibus.");
}
else
{
  Console.WriteLine("Pegar um taxi, para não chegar atrasado.");
}

Console.WriteLine("------------------------");
Console.WriteLine("Digite uma letra");
string? letra = Console.ReadLine();

switch (letra)
{
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
    Console.WriteLine("Vogal");
    break;
  default:
  Console.WriteLine("Não é uma Vogal");
    break;
}


//Exemplos de operadores lógicos
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoResponsavel = false;

if(ehMaiorDeIdade || possuiAutorizacaoResponsavel){
  Console.WriteLine("Entrada liberada");
} else {
  Console.WriteLine("Entrada NÃO permitida");
}

bool possuiPresencaMinima = true;
double media = 7.5;

if(possuiPresencaMinima && media >= 7){
 Console.WriteLine("Aprovado");
} else {
  Console.WriteLine("Reprovado");
}


bool choveu = true;
bool estaTarde = true;

if(choveu && estaTarde){
  Console.WriteLine("Vou pedalar");
} else{
  Console.WriteLine("Não Vou pedalar");
}

//Operadores Aritiméticos
Calculadora calc = new Calculadora();

calc.Somar(10,20);
calc.Subtrair(10,20);
calc.Multiplicar(10,20);
calc.Dividir(20,10);
calc.Potencia(2,4);

//Laço de REPETIÇÃO
int numero = 10;

for (int j = 0; j <= 10; j++)
{
  Console.WriteLine($"{numero} X {j} = {numero * j}");
}

int i = 0;
while (i <= 10)
{
  Console.WriteLine($"{numero} X {i} = {numero * i}");
  i++;

  if (i == 5)
  {
    break;
  }
}

int soma = 0, numero1 = 0;
do
{
  Console.WriteLine("Digite um número () para parar))");
  numero1 = Convert.ToInt32(Console.ReadLine());

  soma += numero1;
} while (numero1 != 0);

Console.WriteLine($"Total da soma dos números digitado é: {soma}");

string opcao;
bool menu = true;

while (menu)
{
  Console.WriteLine("Digite a sua opção");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar cliente");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de Cliente");
      break;
    case "2":
      Console.WriteLine("Buscar de Cliente");
      break;
    case "3":
      Console.WriteLine("Apagar de Cliente");
      break;

    case "4":
      Console.WriteLine("Finalizou Programa");
      menu = false;
      break;

    default:
      Console.WriteLine("Opção Inválida");
      break;
  }
}
