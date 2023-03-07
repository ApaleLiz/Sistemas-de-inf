// Muestra un continente del mundo que corresponde del número (1 - 6)

Console.Clear();

Console.WriteLine("Muestra un continente del mundo que corresponde del número (1 - 6)\n");
Console.Write("Ingrese un numero del (1..6): ");
int n = int.Parse(Console.ReadLine());

if(n>=1 && n<=6){

    if(n==1) Console.WriteLine("Asia\n");
    if(n==2) Console.WriteLine("Africa\n");
    if(n==3) Console.WriteLine("America del Norte\n");
    if(n==4) Console.WriteLine("America del Sur\n");
    if(n==5) Console.WriteLine("Antartida\n");
    if(n==6) Console.WriteLine("Europa\n");
    
}else Console.WriteLine("ERROR!! NO EXISTE ESE CONTINENTE!!!");