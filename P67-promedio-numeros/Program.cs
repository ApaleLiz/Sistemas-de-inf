// calcula el promedio de tres númeeos usando una función

float promedio (float n1, float n2, float n3){
    float suma=0;
    suma = n1 + n2 + n3;
    return suma/3;
}

string [] nums;
float n1,n2,n3, prom;

Console.Clear();
Console.WriteLine("Dame tres numeros separados por espacio");
nums = Console.ReadLine().Split();
Console.WriteLine(nums);
n1 = float.Parse(nums[0]);
n2 = float.Parse(nums [1]);
n3 = float.Parse(nums [2]);

prom = promedio(n1,n2, n3);
Console.WriteLine($"El promedio es {prom:f2}");