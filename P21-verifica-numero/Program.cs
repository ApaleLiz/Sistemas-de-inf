// verifica si un numero es positivo, negativo o cero


int n;
Console.Clear();
Console.WriteLine(" verifica si un numero es positivo, negativo o cero\''n");
Console.Write("Dame un número");
n = int.Parse(Console.ReadLine());

if(n>0) Console.WriteLine("El número es positivo ..");

if(n<0) Console.WriteLine("El número es negativo ..");

if(n==0) Console.WriteLine("El número es cero ..");

Console.WriteLine("\n Gracias por utilizar este super programa");