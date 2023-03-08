//  calcular el promedio de 5 calificaciones
float c1, c2, c3, c4, c5, R;
Console.Clear();
Console.Write("calcular el promedio de tus notas \n");
Console.Write("Introduce Calificación 1: ");   c1=float.Parse(Console.ReadLine());
Console.Write("Introduce Calificación 2: ");   c2=float.Parse(Console.ReadLine());
Console.Write("Introduce Calificación 3: ");   c3=float.Parse(Console.ReadLine());
Console.Write("Introduce Calificación 4: ");   c4=float.Parse(Console.ReadLine());
Console.Write("Introduce Calificación 5: ");   c5=float.Parse(Console.ReadLine());

R=(c1+c2+c3+c4+c5)/5;

if (R > 0 && R < 6) Console.WriteLine("\n Quedas reprobado");
else if (R > 6 && R <= 7) Console.Write("\n Pasas de panzazo");
else if (R > 7 && R <= 8) Console.Write("\n Muy bien puedes mejorar");
else if (R > 8 && R <= 9) Console.Write("\n Excelente sigue asi");
else if (R > 9 && R <= 10) Console.Write("\n Perfecto tu esfuerzo valio la pena");



Console.WriteLine($" \nEl promedio es : {R}");

Console.WriteLine( "\n Gracias por participar");