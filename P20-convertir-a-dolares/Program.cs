//Dada una cantidad en pesos y la cotización del dólar, se desea obtener el equivalente en dólares
Console.WriteLine("Dada una cantidad en pesos y la cotización del dólar, se desea obtener el equivalente en dólares");

float pesos, precio;
float dolar;

Console.Clear();
Console.Write("Ingrese los pesos a convertir ? "); pesos=float.Parse(Console.ReadLine());
Console.Write("Dame el precio del dolar ? "); precio=float.Parse(Console.ReadLine());

dolar= pesos/precio;

Console.Write($"Pesos ingresados = {pesos} \n ");
Console.Write($"Precio del dolar  = {precio} \n");
Console.Write($"En total son = {dolar}  dolares");