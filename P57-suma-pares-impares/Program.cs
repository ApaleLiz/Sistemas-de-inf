// Imprime pares de 1 a n e impares de n a 1 y su suma
int op, i, n, suma;
do{
    suma=0;
Console.Clear();
Console.WriteLine("[1] numeros de 1 a n");
Console.WriteLine("[2] numeros de n a 1");
Console.WriteLine("[3] salir");
Console.Write("Elige ?"); op=int.Parse(Console.ReadLine());

switch(op){
    case 1:{
    Console.WriteLine("\n Imprimiendo números de 1 a n");
    Console.Write("Hasta donde ? "); n= int.Parse(Console.ReadLine());
    for(i=2; i<=n; i+=2){
    Console.Write($"{i}  ");
    suma +=i;
    }
    
        Console.WriteLine($"\n Suma de pares {suma}");
}break;

    case 2: {
    Console.WriteLine("\n Imprimiendo números de n a 1");
    Console.Write("Hasta donde ? "); n= int.Parse(Console.ReadLine());
    n=(n%2==0 ? --n: n);
    for(i=n; i>=1; i-=2){
    Console.Write($"{i}  ");
    suma +=i;
    }
    
        Console.WriteLine($"\n Suma de impares {suma}");
}break;
    case 3: Console.WriteLine("\n Te vas por que yo quiero que te vayas"); break;
    default:
    Console.WriteLine("\n opcion invalida !"); break;
}
 Console.WriteLine("\n Presiona cualquier tecla para continuar.."); Console.ReadLine();
}while(op !=3);
Console.WriteLine("\n Proceso termiando...!"); 
