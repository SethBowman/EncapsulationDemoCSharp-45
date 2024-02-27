using EncapsulationDemoCSharp_45;

var seth = new Person();

seth.AddMoney(200.00);

var currentWallet = seth.CheckWallet();

Console.WriteLine(currentWallet);

seth.AddMoney(1000.00);

currentWallet = seth.CheckWallet();

Console.WriteLine(currentWallet);