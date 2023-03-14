// Imprime ,los numeros pares de 2 a n, clcula su suma, el proceso se repite

int n, c, s;
char resp;

do{
Console.Clear();
Console.WriteLine("Imprime ,los numeros pares de 2 a n, clcula su suma, el proceso se repite");
Console.Write("Hasta donde deseas los pares ?"); n= int.Parse(Console.ReadLine());

c=2;
s=0;
while( c<= n){
    Console.Write($"{c} ");
    s += c;
    c +=2;
    
}
Console.WriteLine($"\n La suma de los números pares de 2 al {n} es = {s}");
Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');

Console.WriteLine("\n Proceso termiando, ya me canse de repetir ...");