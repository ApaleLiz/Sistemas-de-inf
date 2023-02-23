// calcula el volumen de un cilindro
float radio, altura;
double volumen;

Console.Clear(); 
Console.WriteLine("calcula el volumen de un cilindro \n");

Console.Write("Ingresa el radio del cilindro en cm : ");  radio=float.Parse(Console.ReadLine());
Console.Write("Ingresa la altura del  en cm : ");  altura=float.Parse(Console.ReadLine());

volumen = 3.1416 * (radio * radio) * altura;

Console.WriteLine($"Radio de {radio} cm y altura {altura} cm");
Console.WriteLine($"El volumen del cilindro es {volumen} cm3");