// Calcula la suma y el promedio de n numeros

int n;
float  p, suma=0, num;
char resp;
do{
suma=0;
Console.Clear();
Console.WriteLine("Cuantos numeros ?"); n= int.Parse(Console.ReadLine());
for(int i=1; i<=n; i++){
    Console.WriteLine($"Calificacion {i} ?");
    num = float.Parse(Console.ReadLine());
    suma += num;
}
p=suma/n;

Console.WriteLine($"La suma es {suma} el promedio es {p}");
Console.Write("\n Deseas repetir (S/N)? "); resp=char.ToUpper(Console.ReadLine()[0]);
}while(resp != 'N');

Console.WriteLine("\n Proceso terminado ..");