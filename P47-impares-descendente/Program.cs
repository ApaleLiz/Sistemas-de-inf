// Imprime ,los numeros impares  de n al 1, clcula su suma, el proceso se repite

int n, c, s;
char resp;

do{
Console.Clear();
Console.WriteLine("Imprime ,los numeros impares  de n al 1, clcula su suma, el proceso se repite");
Console.Write("Hasta donde deseas los impares ?"); n= int.Parse(Console.ReadLine());

c=( n%2==0 ? --n: n);
s=0;
while( c>= 1){
    Console.Write($"{c} ");
    s += c;
    c -=2;
    
}
Console.WriteLine($"\n La suma de los números pares de {n}  al 1 es = {s}");
Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');

Console.WriteLine("\n Proceso termiando, ya me canse de repetir ...");