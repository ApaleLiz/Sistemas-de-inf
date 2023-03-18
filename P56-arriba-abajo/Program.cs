// Imprime numeros de 1 a n o de n a 1 segun lo decida el usuario
int op,i,n;
do{
Console.Clear();
Console.WriteLine("[1] numeros de 1 a n");
Console.WriteLine("[2] numeros de n a 1");
Console.WriteLine("[3] salir");
Console.Write("Elige ?"); op=int.Parse(Console.ReadLine());

switch(op){
    case 1:
    Console.WriteLine("\n Imprimiendo números de 1 a n");
    Console.Write("Hasta donde ? "); n= int.Parse(Console.ReadLine());
    for(i=1; i<=n; i++)
    Console.Write($"{i}  ");
    break;
    case 2: 
    Console.WriteLine("\n Imprimiendo números de n a 1");
    Console.Write("Hasta donde ? "); n= int.Parse(Console.ReadLine());
    for(i=n; i>=1; i--)
    Console.Write($"{i}  ");
    break;
    case 3: Console.WriteLine("\n Te vas por que yo quiero que te vayas"); break;
    default:
    Console.WriteLine("\n opcion invalida !"); break;
}
 Console.WriteLine("\n Presiona cualquier tecla para continuar.."); Console.ReadLine();
}while(op !=3);
Console.WriteLine("\n Proceso termiando...!"); 
