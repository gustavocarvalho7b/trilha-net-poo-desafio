using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "1269854125", modelo: "12PRO", imei: "ww8110q", memoria: 8);
Nokia nokia = new Nokia(numero: "12991547282", modelo: "G21", imei: "a326b", memoria: 128);
iphone.Ligar(nokia);
iphone.InstalarAplicativo("Angry Birds", 12);
Console.WriteLine("\n");
Console.WriteLine("Smartphone Nokia:");
nokia.ReceberLigacao(iphone);
nokia.InstalarAplicativo("Music Player", 2);