// Acepta a un estudiante en base a su sexo, edad y sus calificaciones
Console.Clear();
 Console.WriteLine("Bienvenido al sistema de admisiones de la Universidad Kitty Kat SA");
            Console.WriteLine("Por favor ingrese la información del estudiante:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Sexo (h/m): ");
            char sexo = char.ToLower(Console.ReadKey().KeyChar); // convertir a minúscula y leer un solo carácter
            Console.WriteLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Calificación 1: ");
            double cal1 = double.Parse(Console.ReadLine());
            Console.Write("Calificación 2: ");
            double cal2 = double.Parse(Console.ReadLine());
            Console.Write("Calificación 3: ");
            double cal3 = double.Parse(Console.ReadLine());

            // Verificar si el estudiante cumple con los requisitos
            if (sexo == 'h')
            {
                Console.WriteLine("Lo siento, la Universidad Kitty Kat SA es solo para mujeres.");
            }
            else if (edad < 21)
            {
                Console.WriteLine("Lo siento, la Universidad Kitty Kat SA es solo para mujeres mayores de 21 años.");
            }
            else if (cal1 < 8 || cal1 > 10 ||
                     cal2 < 8 || cal2 > 10 ||
                     cal3 < 8 || cal3 > 10)
            {
                Console.WriteLine("Lo siento, las calificaciones deben estar entre 8 y 10.");
            }
            else
            {
                double promedio = (cal1 + cal2 + cal3) / 3;
                if (promedio >= 8 && promedio <= 9.5)
                {
                    Console.WriteLine("{0} ha sido aceptada en la Universidad Kitty Kat SA. ¡Felicidades!", nombre);
                }
                else
                {
                    Console.WriteLine("Lo siento, el promedio de calificaciones debe estar entre 8 y 9.5 para ser aceptada.");
                }
            }