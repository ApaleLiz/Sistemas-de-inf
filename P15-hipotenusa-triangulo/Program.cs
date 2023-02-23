//   calcula la hipotenusa de un triángulo rectángulo dadas las longitudes de sus lados
     int cat_1;
	int cat_2;
	double h;
     
	Console.Clear(); 
	Console.WriteLine("calcula la hipotenusa de un triángulo rectángulo \n");
	/* Se ingresa y guarda el cateto 1 */
	Console.Write("Ingrese el valor del cateto 1: \n"); 
	cat_1=int.Parse(Console.ReadLine());
	
	
	/* Se ingresa y guarda el cateto 2 */
	Console.Write("Ingrese el valor del cateto 2: \n"); 
	cat_2=int.Parse(Console.ReadLine());
	
	/* Calculamos hipotenusa y mostramos el resultado */
	//h=sqrt (cat_1*cat_1+cat_2*cat_2);
	h = Math.Sqrt( (cat_1 * cat_1) + (cat_2 * cat_2) );
	Console.WriteLine($"Un triangulo de lados {cat_1} y {cat_2} tiene una hipotenusa de {h} "); 
	

