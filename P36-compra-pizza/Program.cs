// Administrar la venta de pizzas


Console.Clear();
Console.WriteLine("Elige el tamaño de tu pedido de pizzas: \n");
Console.WriteLine("Tamaño : 1- Chica - $5 2- Mediana - $10 3- Grande - $15");
Console.Write("Ingrese un numero del (1..3): ");
int n = int.Parse(Console.ReadLine());


char tam;
string tamaño="", cliente="";
float subtot=0, desc=0, total=0, cant=0;

if(args.Length<5) {
Menu();
return 1;
}
//Procesar tamaño
tam= char.Parse(args[0].ToUpper());
if(tam=='c') {tamaño ="chica"; subtot+=5;}
else if(tam=='M') {tamaño="Mediana"; subtot+=10;}
else{tamaño= "Grande"; subtot+=15;}

// Procesar descuento
if(subtot < 2000){
    desc=0.0f; cliente="No descuento";
}
else if(subtot>2000){
    desc=0.20f; cliente ="Con descuento";
}
total = subtot - (subtot*desc);

Console.WriteLine($"Tamaño: {tamaño}");
return 0;