//   convertir una temperatura de grados fahrenheit a grados celsius,
float fa;
float ce;

Console.Clear(); 
Console.WriteLine("convertir una temperatura de grados fahrenheit a grados celsius, \n");

Console.Write("Dame los grados Farenheit : ");  fa=float.Parse(Console.ReadLine());
ce =  ( fa - 32 )  * 5/9;
Console.WriteLine($"{fa} Farenheit, equivale a {ce} Celcius");