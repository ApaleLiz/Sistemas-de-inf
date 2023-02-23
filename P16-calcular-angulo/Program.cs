//   calcular el 3er ángulo de un triángulo dados los dos primeros ángulos del mismo
     int ang_1;
	 int ang_2;
	 double ang_3;
     
	Console.Clear(); 
	Console.WriteLine("calcular el 3er ángulo de un triángulo dados los dos primeros ángulos del mismo \n");
	
    /* Se ingresa y guarda el angulo 1 */
	Console.Write("Ingrese el valor del angulo 1 en grados: \n"); 
	ang_1=int.Parse(Console.ReadLine());
	
	
	/* Se ingresa y guarda el cangulo 2 */
	Console.Write("Ingrese el valor del angulo 2  en grados: \n"); 
	ang_2=int.Parse(Console.ReadLine());
	
	
	ang_3 = 180-(ang_1 + ang_2);
	
    Console.WriteLine($"Un triangulo de angulos {ang_1} y {ang_2} grados, tiene un tercer angulo de {ang_3} grados "); 
	

