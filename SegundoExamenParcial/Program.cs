const int MAX = 100;
double [] nums = new double [MAX];
double suma = 0;
double promedio = 0;
double buscar, pos;
int op;
int n = 0;



do{
 op = menu();
    switch (op)
    {
        case 1:
        System.Console.Write("Cuantos elementos deseas? ");
        n = int.Parse(Console.ReadLine());
        if (n > MAX)
        {
            System.Console.WriteLine("TE PASATE");
        }else
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.Write($"Elemento [{i+1}] " );
                nums[i] = double.Parse(Console.ReadLine());
                
            }
        }
        break;
        case 2: Mostrar(nums, n);
      
            break;
        case 3:
            suma = Sumar(nums, n);
            promedio = suma / n;
        MayorPromedio(nums, n, promedio);
            break;
        case 4: 
        Complemento(nums, n);
            break;
        case 5:
        System.Console.Write("\nQue elemento buscas? ");
        buscar = double.Parse(Console.ReadLine());
        pos = BuscarContar(nums, buscar, n);
        if (pos > 1){
            System.Console.WriteLine($"Encontrado elemento: {buscar} un total de {pos} veces");
        }else{
            System.Console.WriteLine($"No se ha encontrado el elemento{buscar}");
        }
        break;
        default:
            break;
    }
    
    System.Console.WriteLine("\nPresione cualquier tecla para continuar..");
    Console.ReadLine();
} while (op != 6);

int menu(){
    Console.Clear();
    System.Console.WriteLine("Leer Calificaciones....................[1]");
    System.Console.WriteLine("Mostrar Calificaciones.................[2]");
    System.Console.WriteLine("mostrar mayores al promedio............[3]");
    System.Console.WriteLine("Mostrar Complemento a 100..............[4]");
    System.Console.WriteLine("Contar Calificaciones..................[5]");
    System.Console.WriteLine("Salir..................................[6]");
    System.Console.Write("Elige una Opción: ");

    int op = int.Parse(Console.ReadLine());
    return op;
}

void Mostrar(double[] a, int n){
    for (int i = 0; i < n; i++)
    {
        System.Console.Write($"{a[i]} ");
    }
}

void MayorPromedio(double[] a, int n, double promedio){
    double suma = Sumar(a, n);
    double promFunct = suma / a.Length;
    Console.WriteLine($"\nEl promedio es: {promedio:f2}");
    Console.WriteLine($"\n Los numeros mayores al promedio son: ");
    for (int i = 0; i < n; i++)
    {
        if(a[i] > promFunct){
            System.Console.Write($"{a[i]} ");
        }else{

        }
    }
}

void Complemento(double[] a, int n){
    double value;
    for (int i = 0; i < n; i++)
    {
        value = 100 - a[i];
        System.Console.Write ($"{value} ");
    }
}

double Sumar(double[] a, int n){
    double suma = 0;
    for (int i = 0; i < n; i++)
        suma = suma + a[i];
        return suma;

}

double BuscarContar(double[] a, double nb, int n){
    int pos = 1;
    int nt = 0;
    for (int i = 0; i < n; i++)
    if (a[i] == buscar)
        ++nt;

    return nt;
    
}