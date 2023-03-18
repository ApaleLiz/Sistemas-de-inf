// se desean imprimir los primeros n números de la será de fibbonaci.

int a = 0, b = 1;
char resp;
do{
Console.Clear();
Console.WriteLine("\nSe desean imprimir los primeros n números de la será de fibbonaci");
 Console.Write("\nIngrese la cantidad de números de la serie de Fibonacci que desea imprimir: ");
  int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a);
                int temp = a;
                a = b;
                b = temp + b;
            }

    System.Console.Write("\nDeseas continuar (S/N): ");
    resp = char.ToUpper(Console.ReadLine()[0]);
        
}while (resp !='N');
System.Console.WriteLine("Proceso terminado");