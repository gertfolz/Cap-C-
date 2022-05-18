
IEstadoBinario[] lista = new IEstadoBinario[3];
lista[0] = new Lampada(110, 60);
lista[0].Ligar();
lista[1] = new TermometroEletrico();
lista[2] = new Computador();
for (int i = 0; i <lista.Length; i++)
{
    Console.WriteLine(lista[i].Estado);
}
