//Calcula el área de un circulo

double area, radio;

Console.WriteLine("Calculando el área de un circulo");
Console.Write("Dame el radio: ");
radio= double.Parse (Console.ReadLine());

area= Math.PI * radio*radio;   //area= Math.Pow(radio, 2);

Console.WriteLine($"El circulo de radio {radio} tiene un area de {area}\n");
Console.WriteLine("El tipo de ddato de las variables es");
Console.WriteLine(radio.GetType());
Console.WriteLine(area.GetType());


