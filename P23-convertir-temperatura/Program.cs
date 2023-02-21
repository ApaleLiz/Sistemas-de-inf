// Convertir temperatura de grados celcius a farenheit y viceversa

char op;
float temp, res;
Console.Clear();
Console.WriteLine("Convertir de grados celcius a farenheit y viceversa\n");
Console.WriteLine("[F]arenheit ");
Console.WriteLine("[C]entigrados  ");
Console.Write("Elije una opcion ? ");

op  = char.ToUpper( Console.ReadLine()[0]);
//op=char.Parse(Console.ReadLine());
//op = char.ToUpper(op);
if( op=='F' ) {
Console.WriteLine("\nConvertir a Farenheit \n");
Console.Write("Dame los grados celcius ? "); temp=float.Parse(Console.ReadLine());
res =( temp * 9 / 5 ) + 32;
Console.WriteLine($"{temp} Celcius, equivale a {res} Farenheit");
}
else {
Console.WriteLine("\nConvertir a Centigrados \n");
Console.WriteLine("Dame los grados Farenheit ? "); temp=float.Parse(Console.ReadLine());
res =  ( temp - 32 ) * 5 / 9;
Console.WriteLine($"{temp} Farenheit, equivale a {res} Centigrados");
}
Console.WriteLine("\nGracias por utilizar este programa");