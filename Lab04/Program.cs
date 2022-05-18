ContaCorrente minhaConta = new ContaCorrente(340, "gert");

minhaConta.Depositar(100);
minhaConta.Sacar(50);
minhaConta.Depositar(77);
minhaConta.Sacar(55);
minhaConta.Depositar(123);
minhaConta.Sacar(89);
Console.WriteLine(minhaConta.Media());
Console.WriteLine(minhaConta.Saldo);