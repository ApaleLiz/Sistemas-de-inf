// Dados tres números enteros, verificar cual es el mayor


int n1=0, n2=0, n3=0;

Console.Clear();
Console.WriteLine("Dados tres números enteros, verificar cual es el mayoro");
Console.Write("\n Introduzca n1: "); n1=int.Parse(Console.ReadLine());
Console.Write("\n Introduzca n2: "); n2=int.Parse(Console.ReadLine());
Console.Write("\n Introduzca n3: "); n3=int.Parse(Console.ReadLine());

 if (n1 >= n2  && n1>=n3)  Console.WriteLine($"\n n1 es el mayor: {n1}");
  
 
    if(n2 >= n1  && n2>=n3) Console.WriteLine($"\n n2 es el mayor: {n2}");
 

 
    if(n3 >= n2  && n3>=n1) Console.WriteLine($"\n n3 es el mayor: {n3}");
 
 Console.WriteLine("\n Gracias por utilizar este super programa !!");
 


