// Tabla de multiplicar

void Tablamultiplicar(int tabla, int n) {
Console.WriteLine($"\nTabla del {tabla}");
for(int i=1; i <= n; i++)
Console.WriteLine($"{tabla} x {i} = {tabla*i}");
}

//tablamultiplicar(5,3);
Console.Write("Que tabla deseas ? ");
int tabla = int.Parse(Console.ReadLine());
Console.Write("Hasta donde ? ");
int n = int.Parse(Console.ReadLine());
Tablamultiplicar(tabla,n);