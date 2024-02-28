using ExemploFundamentos.NETS;
using ExemploFundamentos.NETS8;
Console.WriteLine("Hello, World!");

Pessoas p = new Pessoas();

Calculadora c = new Calculadora();

p.Nome = "Matheus Gomes";
p.Idade = 24;


p.Apresentar();

c.Somar( 10,43);

c.Subtrair(21,171);

c.Dividir(32,45);

c.Multiplicar(45, 12);

int[] ArrayInteiro = new int[10];

List<string> listaString = new List<string>();

ArrayInteiro[0] = 14;
ArrayInteiro[1] = 23;
ArrayInteiro[2] = 36;
ArrayInteiro[3] = 42;
ArrayInteiro[4] = 53;
ArrayInteiro[5] = 60;
ArrayInteiro[6] = 74;
ArrayInteiro[7] = 89;
ArrayInteiro[8] = 97;
ArrayInteiro[9] = 100;



Console.WriteLine("");

Console.WriteLine("Percorrendo o Array com o FOR");

//Percorrendo uma lista
for (int contador = 0; contador < ArrayInteiro.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {ArrayInteiro[contador]}");
}


//Metodo do Array de recria todos elemento de um Array.
Array.Resize(ref ArrayInteiro, ArrayInteiro.Length * 2);


//Novo Array 
int[] arrayInteiroDobrado = new int[ArrayInteiro.Length];


//Metodo do Array de copia todos elemento para outro Array.
Array.Copy(ArrayInteiro, arrayInteiroDobrado, ArrayInteiro.Length);


Console.WriteLine("Percorrendo Array com o FOREACH");


int contadorForach = 0;

foreach (int valor in ArrayInteiro)
{
    Console.WriteLine($"Posição Nº {contadorForach}  {valor}");
    contadorForach++;
}



//////////Listas\\\\\\\\\\\\\
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");


Console.WriteLine($"Items da minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("RJ");

Console.WriteLine($"Items da minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("RJ");

Console.WriteLine($"Items da minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("BA");

Console.WriteLine("ConsoleWriteLine google .com.br ");

listaString.Add("Agora vamos começar a fazer de uma forma mais clara para qual podemos elabora um conjunto de acontecimento ");

Console.WriteLine($"Items da minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");


//Percorrendo uma lista usando o for.
Console.WriteLine("Percorra a lista com o FOR");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}


//Percorrendo uma lista usando o foreach.
foreach (string elemento in listaString)
{
    Console.WriteLine($"Poisição Nº{contadorForach} - {elemento}");
    contadorForach++;
}