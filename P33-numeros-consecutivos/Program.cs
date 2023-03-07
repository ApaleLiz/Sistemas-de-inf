// Dados tres números enteros, verificar si son consecutivos o no


int n1=0, n2=0, n3=0;

Console.Clear();
Console.WriteLine("Dados tres números enteros, verificar si son consecutivos o no");
Console.WriteLine("\n Introduzca n1: "); n1=int.Parse(Console.ReadLine());
Console.WriteLine("\n Introduzca n2: "); n2=int.Parse(Console.ReadLine());
Console.WriteLine("\n Introduzca n3: "); n3=int.Parse(Console.ReadLine());

 if ((n2 != n1+1) && (n3 != n2+1)) 
 {
    Console.WriteLine("\n Error!!!");

 }
 else 
 {
    if((n2 == n1+1) && (n3 == n2+1)) Console.WriteLine("\n Los numeros ingresados son consecutivos!!");
 }
