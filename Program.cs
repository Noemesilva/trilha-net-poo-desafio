using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"12546", modelo:"78568", imei:"1111111", memoria: 56);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero:"568956", modelo:"363636", imei: "58585858", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
