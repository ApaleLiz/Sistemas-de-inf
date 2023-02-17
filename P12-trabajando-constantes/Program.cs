// Trabajando con constantes

const double DESCUENTO = 0.10;
const int VELOCIDADLUZ = 30000;
const float TASA = 0.5f;
const byte SEPARADOR = 254;
const sbyte LITERAL = 0x64;
const string MENSAJE = "ERROR EN EL SISTEMA, TODO VA A EXPLOTAR EN 5 4 3 2 1 0";

Console.Clear();
Console.WriteLine("El valor de la constante es: \n");
Console.WriteLine("Descuento x 2: {0}", 2 * DESCUENTO);
Console.WriteLine("Velocidad / 2 : {0}", VELOCIDADLUZ / 2);
Console.WriteLine("Tasa : {0:p}", TASA);

Console.WriteLine("MENSAJE");
Console.WriteLine("separador - literal en formato hexadecimal : {0:x} - {1:x}", SEPARADOR, LITERAL);
Console.WriteLine("separador - literal en formato binario : {0:x} - {1:x}",
Convert.ToString(SEPARADOR, 2), Convert.ToString(LITERAL, 2));

//

