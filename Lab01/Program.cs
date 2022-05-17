byte b = byte.MaxValue;
Console.WriteLine($"Valor maximo de byte: {b}");

int i = int.MaxValue;
Console.WriteLine($"Valor maximo de int: {i}");

long l = long.MaxValue;
Console.WriteLine($"Valor maximo de long: {l}");
Console.WriteLine("\n");

string strPrimeira = "Alo ";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;
Console.WriteLine(strTerceira);

int cchTamanho = strTerceira.Length;

string strQuarta = "Tamanho = " + cchTamanho.ToString();
Console.WriteLine(strQuarta);
Console.WriteLine(strTerceira.Substring(0,5));

DateTime dt = new DateTime(2015, 04, 23);
string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);
Console.WriteLine("\n");

// Exercício 1

float f = float.MaxValue;
double d = double.Epsilon;
decimal dec = decimal.MinValue;
Console.WriteLine($"Valor maximo de float: {f}");
Console.WriteLine($"Valor epsilon de double: {d}");
Console.WriteLine($"Valor minimo de decimal: {dec}");
Console.WriteLine("\n");

// Exercicio 2

string s1 = "I like to study";
string bu = "\u4E00";

Console.WriteLine(s1.Substring(2,4));
Console.WriteLine(s1.Replace("like", "don't like"));
Console.WriteLine($"Tamanho da string = {s1.Length}");
Console.WriteLine(bu);
Console.WriteLine("\n");

// Exercicio 3

DateTime date = DateTime.Now;
Console.WriteLine($"Dia de hoje: {date}");
Console.WriteLine($"Dia do ano: {date.DayOfYear}");
Console.WriteLine($"Dia da semana: {date.DayOfWeek}");
Console.WriteLine($"Hora do dia: {date.Hour}");

date = DateTime.MaxValue;
Console.WriteLine($"Maior data possível: {date}");

date = DateTime.MinValue;
Console.WriteLine($"Menor data possível: {date}");

date = DateTime.Now;
date = date.AddDays(100);
Console.WriteLine($"Daqui a 100 dias será: {date}");
Console.WriteLine("\n");

// Exercicio 4

int i2 = 10;
float f2 = 0;
f2 = i2;
Console.WriteLine(f2);
f2 = 0.5F;
i2 = (int)f2;
Console.WriteLine(i2);
Console.WriteLine("\n");

// Exercicio 5

string stringInteiro = "123456789";
int valorStringInteiro = Convert.ToInt32(stringInteiro);
Console.WriteLine(valorStringInteiro);
Int64 valorInt64 = 123456789;
int valorInt = Convert.ToInt32(valorInt64);
Console.WriteLine(valorInt);

// string stringInteiroGrande = "9999999999999999999";
// int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);

Console.WriteLine("\n");

// Exercicio 6

stringInteiro = "123456789";
bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);
Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);

string stringInteiroGrande = "999999999999999999999999999999999999999999999";
int valorStringInteiroGrande;
bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande);

string stringLetras = "abc";
double valorStringLetras;
bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);
Console.WriteLine("\n");

// Exercicio 7

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);
Console.WriteLine("Conversao explicita = " + valorInteiro1);
Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);
Console.WriteLine("\n");


// Exercicio 8

int x = 10;
double y = 3.4;
Console.WriteLine("{0} {1}",x,y);


