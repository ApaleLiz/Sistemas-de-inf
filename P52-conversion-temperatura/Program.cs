// Genera una tabla de conversion de centigrados a farenheit en un rango de valores

float tc= 0f;
float ini, fin, p;
char resp;

do{
Console.Clear();
Console.WriteLine("Genera una tabla de conversion de dentigrtados a farenheit");

do{
Console.Write(" Inicio?"); ini= float.Parse(Console.ReadLine());
Console.Write(" Fin?"); fin= float.Parse(Console.ReadLine());
} while(fin<ini);   //se repite mientras el rango de valores no se valido


p= ini;
Console.WriteLine(new string('-', 25));
Console.WriteLine("celcius\t   Farenheit");
Console.WriteLine(new string('-', 25));
while (p <=fin ){
    Console.WriteLine($"{p:n2}\t \t{(p*9/5)+32:f2}");
    p +=1;
}
Console.WriteLine(new string('-', 25));

Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
Console.WriteLine("\n Proceso terminado");