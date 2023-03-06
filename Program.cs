using smartphone.modelos;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"2142141242", modelo:"235325",imei:"",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");



Console.WriteLine("Smartphone Nokia");
Smartphone iphone = new Iphone(numero:"1231234124", modelo:"32535",imei:"",memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");