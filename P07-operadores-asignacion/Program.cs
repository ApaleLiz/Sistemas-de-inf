// Utiliza los operadores de asignación para efectur diversas operaciones

Console.Clear();
Console.WriteLine("Utiliza los operadores de asignación para efectur diversas operaciones\n");

Console.Write("Dame un numero ? ");
float num=float.Parse(Console.ReadLine());
Console.WriteLine($"El numero original es: {num}");
Console.WriteLine($"Incremantar 1 : {++num}");
Console.WriteLine($"Sumar 50 : {num+=50}");
Console.WriteLine($"Restar 35 : {num-=35}");
Console.WriteLine($"Multiplicar por 15 : {num*=15}");
Console.WriteLine($"Dividir entre 4 : {num/=4}");
Console.WriteLine($"Decrementar 1 : {--num}");