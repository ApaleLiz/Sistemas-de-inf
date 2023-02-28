// Efectua operaciones matemáticas básicas con 2 números


float n1, n2;
char op;
Console.Clear();
Console.WriteLine("Efectua operaciones matemáticas básicas con 2 números \n");
Console.Write("Dame número 1 ?"); n1= float.Parse(Console.ReadLine());
Console.Write("Dame número 2 ?"); n2= float.Parse(Console.ReadLine());
Console.Write("Operaciones ( + - * /) ?");
op = Console.ReadLine()[0];
switch(op){

    case '+': Console.WriteLine($" n1 + n2 = { n1 + n2}"); break;
    case '-': Console.WriteLine($" n1 - n2 = { n1 - n2}"); break;
    case '*': Console.WriteLine($" n1 * n2 = { n1 * n2}"); break;
    case '/': Console.WriteLine($" n1 / n2 = { n1 / n2}"); break;
    case '^': Console.WriteLine($" n1 / n2 = { Math.Pow (n1,n2)}"); break;
    default : Console.WriteLine("operacion invalida... "); break;
}
Console.WriteLine("\n Proceso terminado ...");
