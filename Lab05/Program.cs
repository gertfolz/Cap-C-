List<Circulo> circArray = new List<Circulo>();
circArray.Add(new CirculoColorido());
circArray.Add(new CirculoColoridoPreenchido());
circArray.Add(new CirculoColoridoPreenchido(2.5, 3, 6, "violeta", "vermeio"));
circArray.Add(new CirculoColorido(2.5, 3, 6, "rosa"));
circArray.Add(new Circulo(1, 1, 6));
foreach (var circ in circArray)
{
    Console.WriteLine(circ);
}
