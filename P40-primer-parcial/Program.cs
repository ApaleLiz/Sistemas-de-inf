﻿// Control de la inscripción a un evento académico

Console.Clear();
void Menu() {
    Console.Clear();
    Console.WriteLine("Control de la inscripción a un evento académico");
    Console.WriteLine("Tipo de usuario: [1] Alumno $100, [2] Trabajador $200, [3] Docente $500");
    Console.WriteLine("Tipo de paquete: [1] Solo conferencias $600, [2] Con eventos sociales $800, [3] Con kit de acceso $900");
}

int usu, paq, cantidad;
string usuario = "", paquete = "";
float subtot = 0, desc = 0, total = 0;

if(args.Length < 3) {
    Menu();
    return 1;
}

//Procesando usuario
usu = int.Parse(args[0]);
if(usu == 1){usuario = "Alumno"; subtot += 100;}
else if(usu == 2){usuario = "Trabajador"; subtot += 200;}
else {usuario = "Docente"; subtot += 500;}

//Procesando paquete
paq = int.Parse(args[1]);
if(paq == 1){paquete = "Solo conferencias"; subtot += 600;}
else if(paq == 2){paquete = "Con eventos sociales"; subtot += 800;}
else {paquete = "Con kit de acceso"; subtot += 900;}

//Procesando cantidad
cantidad = int.Parse(args[2]);
subtot = subtot * cantidad;

//Procesando descuento
if(subtot >= 5000) {
    if(usu == 1)desc = 0.20f;
    else if(usu == 2)desc = 0.10f;
    else desc = 0.05f;
}
total = subtot - (subtot * desc);


Console.WriteLine($"-----------------------Universidad Patito ------------------");
Console.WriteLine($"Cantidad : {cantidad} // Usuario : {usuario} // Paquete: {paquete}");
Console.WriteLine($"Precio : {subtot:c} // con descuento: {(desc * subtot):c} ({desc*100}%) // total : {total:c}");
Console.WriteLine($"Gracias por entrar a este programa!!");
return 0;