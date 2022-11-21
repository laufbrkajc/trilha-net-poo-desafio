using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone1 = new Iphone("34 00000-0000", "14 Max", Guid.NewGuid().ToString(), 616616);
Nokia nokia1 = new Nokia("34 11111-1111", "2.1", Guid.NewGuid().ToString(), 10000);

nokia1.Ligar("0800 616 456");
iphone1.Ligar("190");

return 0;
