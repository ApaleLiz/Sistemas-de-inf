// See https://aka.ms/new-console-template for more information

Console.Clear();

Console.WriteLine("Muestra el tipo de angulo según los grados :\n");
Console.Write("Dame un angulo entre 0 y 360 grados : ");
int angulo = int.Parse(Console.ReadLine());

if(angulo < 0 && angulo >360){
    Console.WriteLine("Angulo invalido ...");
} 
else
 {
    if(angulo<90) Console.WriteLine("\n El angulo es AGUDO..");
    if(angulo==90) Console.WriteLine("\n El angulo es RECTO..");
    if(angulo>90 && angulo<180) Console.WriteLine("\n El angulo es OBTUSO..");
    if(angulo==180) Console.WriteLine("\n El angulo es LLANO..");
    if(angulo>180 && angulo<360) Console.WriteLine("\n El angulo es CONCAVO..");
    if(angulo==360) Console.WriteLine("\n El angulo es COMPLETO..");
}
Console.WriteLine("\n Preoceso termindo");
