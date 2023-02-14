// Efectua operaciones matemáticas básicas con dos números
double suma, resta, multi, divi, resi, pote;

Console.Clear();
Console.WriteLine("Efectua operaciones matemáticas básicas con dos números\n");

double x=10.5, y = 2.5;

suma= x + y;
resta= x - y;
multi= x * y;
divi= x / y;
resi= x % y;
pote= Math.Pow(x,y);

Console.WriteLine($"Los números son {x}, {y}");
Console.WriteLine($"Suma : {suma}");
Console.WriteLine($"Resta : {resta}");
Console.WriteLine($"Multiplicación : {multi}");
Console.WriteLine($"Division : {divi}");
Console.WriteLine($"Residuo : {resi}");
Console.WriteLine($"Potencia : {pote}");
