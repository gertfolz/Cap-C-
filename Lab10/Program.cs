﻿List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
    new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true},
    new Pessoa{Nome="Maria",DataNascimento=new DateTime(2000,1,10), Casada=false},
    new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
};

var linq1 =
    from p in pessoas
    where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
    select p;

foreach (var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));
foreach (var pessoa in linq2)
{
Console.WriteLine(pessoa);
}

var linq3 = 
    from p in pessoas
    orderby p.DataNascimento ascending
    select p;
Console.WriteLine($"Pessoa mais nova: {linq3.Last()}");
Console.WriteLine($"Pessoa mais velha: {linq3.First()}");

var linq4 = 
    from p in pessoas
    group p by p.Casada into grupo
    select new
    {
        casadas = grupo.Key,
        pessoas = grupo.Count()
    };
foreach (var pessoa in linq4)
{
Console.WriteLine(pessoa);
}

