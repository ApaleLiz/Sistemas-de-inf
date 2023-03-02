// Administrar la venta de pizzas


void Menu(){
Console.Clear();
Console.WriteLine("Elige como deseas armar tu pedido de pizzas: \n");
Console.WriteLine("Tamaño : [C]hica - $5 [M]ediana - $10 [G]rande - $15");
Console.WriteLine("Ingredientes: [E]xtra queso [C]hampiñoness [P]iña , unidos por un + - $5 por ingrediente");
Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
Console.WriteLine("Donde : [A]qui [L]levar");
}

char tam, cub, don;
string[] ings;

string tamaño="", ingredientes="", cubierta="", donde="", cliente="";
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

//procesar ingredientes
ings = args[1].Split("+");
foreach(string ing in ings){
    switch( char.Parse(ing.ToUpper()) ){
        case 'E' : ingredientes+= "Extraqueso "; break;
        case 'C' : ingredientes+= "Champiñones "; break;
        case 'P' : ingredientes+= "Piña "; break;

    }
  subtot+=5;
}

//Cubierta
cub = char.Parse( args[2].ToUpper());
cubierta = (cub=='D'? "Delgada" : "Gruesa");

//Procesar donde
don = char.Parse(args[3].ToUpper());
donde = ( don== 'A' ? "Aqui" : "Llevar");

//procesar la cantidad
cant = float.Parse( args[4]);
subtot = subtot * cant;

// Procesar descuento
if(subtot < 1000){
    desc=0.0f; cliente="Platino";
}
else if(subtot<2000){
    desc=0.20f; cliente ="plata";
}
else{
    desc=0.20f; cliente="oro";
}
total = subtot - (subtot*desc);

Console.WriteLine($"Tamaño: {tamaño}");
Console.WriteLine($"Ingredientes: {ingredientes}");
Console.WriteLine($"Cubierta: {cubierta}");
Console.WriteLine($"Donde: {donde}");
Console.WriteLine($"Cantidad: {cant}, Subtotal: {subtot:c}, eres cliente {cliente}, descuento: { subtot*desc:c} ({desc:p2}), total: {total:c}");


return 0;