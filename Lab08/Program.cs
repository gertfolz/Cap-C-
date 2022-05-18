﻿string[] lista = { "Julio", "Lucia", "Daniel", "Joao" };
Console.WriteLine("Array antes da ordenacao");
for (int i = 0; i < lista.Length; i++)
{
    Console.Write(lista[i] + " ");
}
Console.WriteLine();
Array.Sort(lista);
Console.WriteLine("Array depois da ordenacao");
for (int i = 0; i < lista.Length; i++)
{
    Console.Write(lista[i] + " ");
}

Console.WriteLine();
Pessoa[] lista2 = {
 new Pessoa("Jose", 25),
 new Pessoa("Ana", 28),
 new Pessoa("Paulo", 20)
};
Array.Sort(lista2);
Console.WriteLine("Array depois da ordenacao");
for (int i = 0; i < lista2.Length; i++)
{
    Console.Write(lista2[i].Nome + " ");
}
Console.WriteLine();
Array.Sort(lista2, new Pessoa.OrdenaPorNome());
for (int i = 0; i < lista2.Length; i++)
{
    Console.Write(lista2[i].Nome + " ");
}