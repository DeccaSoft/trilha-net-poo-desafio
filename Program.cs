using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia XYZ");
Console.WriteLine("--------------------");
Smartphone nokia = new Nokia(numero: "123456789", marca: "Nokia",  modelo: "Modelo XYZ", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");


Console.WriteLine("iPhone 76");
Console.WriteLine("--------------------");
Smartphone iphone = new Iphone(numero: "987654321", marca: "Aplle", modelo: "iPhone 76", imei: "999999999", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

nokia.FazerLigacao();
iphone.ReceberLigacao();

Console.WriteLine("\n");

nokia.ExecutarAplicativo("WhatsApp");
iphone.ExecutarAplicativo("Telegram");