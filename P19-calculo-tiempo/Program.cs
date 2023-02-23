//Dada una cantidad en horas, calcular su equivalente en días, minutos y segundos.

int  hrs;
float seg, min, dias;

Console.Clear(); 
Console.WriteLine("Dada una cantidad en horas, calcular su equivalente en días, minutos y segundos\n");

Console.Write("Ingresa las hrs: ");  hrs=int.Parse(Console.ReadLine());

dias=  hrs/24;
//hrs=hrs;
min=  hrs* 60;
seg= hrs*3600;

Console.WriteLine($"Dias= {dias:f}");
Console.WriteLine($"Minutos= {min}");
Console.WriteLine($"Segundos= {seg}");
