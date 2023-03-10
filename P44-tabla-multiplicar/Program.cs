// Imprimir la tabla de multiplicar que el usuario la pida hasta donde la pida

int c, t, n;
Console.Clear();
Console.WriteLine("Imprir la tabla de multiplicar que el usuario pida hasta donde la pida \n");
Console.Write("Cual tabla quieres ?");  t = int.Parse(Console.ReadLine());
Console.Write("Hasta donde");       n = int.Parse(Console.ReadLine());


c=1;
while (c<=n){
    Console.WriteLine($"{t,3} x {c,3} = {t*c}");
    c++;

}

