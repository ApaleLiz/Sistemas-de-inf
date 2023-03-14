// Genera una tabla de conversion de peso a dolar en un rango de valores

float tc= 18.54f, te=19.95f;
float ini, fin, p;
char resp;

do{
Console.Clear();
Console.WriteLine("Genera una tabla de conversion de peso a dolar en un rango de valores");

do{
Console.Write(" Inicio?"); ini= float.Parse(Console.ReadLine());
Console.Write(" Fin?"); fin= float.Parse(Console.ReadLine());
} while(fin<ini);   //se repite mientras el rango de valores no se valido

p= ini;
Console.WriteLine(new string('-', 25));
Console.WriteLine("Peso\tDollar\tEuro");
Console.WriteLine(new string('-', 25));
while (p <=fin ){
    Console.WriteLine($"{p:n2}\t{p/tc:f2}\t{p/te:f2}");
    p +=1;
}
Console.WriteLine(new string('-', 25));

Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
Console.WriteLine("\n Proceso terminado");