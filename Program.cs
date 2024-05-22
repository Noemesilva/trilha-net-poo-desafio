using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"12546", modelo:"78568", imei:"1111111", memoria: 56);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"56895", modelo:"36363", imei: "5858585 ", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
