Queue<Object> q = new Queue<Object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine("\n");


Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine("\n");

Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);
foreach (KeyValuePair<int, string> item in paises)
{
 int codigo = item.Key;
 string pais = item.Value;
 Console.WriteLine("Código {0} = {1}", codigo, pais);
}
Console.WriteLine("\n");


// Exercicios
// Exercicio 1
string buscaPais = "França";
foreach (KeyValuePair<int, string> item in paises)
{
    if (item.Value == buscaPais)
        Console.WriteLine($"Código {item.Key} = {buscaPais}");
}
Console.WriteLine("\n");

//Exercicio 2

List<float> minhaLista = new List<float>();
Random rnd = new Random();
for (int i = 0; i<100; i++)
{
    minhaLista.Append(rnd.Next(1,1000)/rnd.Next(1,1000));
}
double average = 0;
double sum = 0;

for (int i = 0; i<minhaLista.Count; i++)
{
    sum += minhaLista[i];
}
Console.WriteLine(sum);
average = sum/minhaLista.Count;
Console.WriteLine(average);