//Ejercicio #1
byte edad;

Console.WriteLine("Cual es tu edad?");
edad = Convert.ToByte(Console.ReadLine());
Console.WriteLine("No aparentas tener: " + edad + " Años.");

//Ejercicio #2

byte numero1, numero2;
ushort resultado;

Console.WriteLine("\nIngresa dos Numeros de dos cifras para Multiplicar:");
Console.WriteLine("Numero1:");
numero1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Numero2:");
numero2 = Convert.ToByte(Console.ReadLine());
resultado = Convert.ToUInt16(numero1 * numero2);
Console.WriteLine("El Resultado es:" + resultado);

//Ejercicico #3 

long num1, num2;
long suma;
long resta;
long producto;

Console.WriteLine("Escriba su primer numero:");
num1 = long.Parse(Console.ReadLine());
Console.WriteLine("Escriba su segundo numero:");
num2 = long.Parse(Console.ReadLine());
suma = num1 + num2;
resta = num1 - num2;
producto = num1 * num2;
Console.WriteLine("El resultado de la suma es:" + suma);
Console.WriteLine("El resultado de la resta es:" + resta);
Console.WriteLine("El resultado del Producto es:" + producto);
