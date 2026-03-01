Console.WriteLine("Actividad 14");
Console.WriteLine("11.Mostrar los números del 1 al 10.\r\n12.Mostrar los números del 10 al 1.\r\n13.Mostrar los números pares del 1 al 20.\r\n14.Mostrar los números impares del 1 al 20.\r\n15.Sumar los números del 1 al 100.");
Console.WriteLine("16.Pedir números hasta que el usuario ingrese 0.\r\n17.Contar cuántos números positivos ingresa el usuario.\r\n18.Calcular el factorial de un número ingresado.\r\n19.Mostrar la tabla de multiplicar de un número ingresado.\r\n20.Contar cuántos dígitos tiene un número.");
Console.WriteLine("21.Sumar números ingresados hasta que el total supere 100.\r\n22.Pedir una contraseña hasta que sea correcta.\r\n23.Mostrar los múltiplos de 3 menores a 50.\r\n24.Generar una secuencia que aumente de 5 en 5 hasta 100.\r\n25.Simular un menú que se repita hasta que el usuario elija salir.");
int opcion = int.Parse(Console.ReadLine());


switch (opcion)
{
    case 11:
        Console.WriteLine("Ejercicio 11");
        int num11 = 1;
        while (num11 <= 10 )
        { Console.WriteLine($"{num11}");
            num11++;
        }
    break;
    case 12:
        Console.WriteLine("Ejercicio 12");
        int num12 = 10;
        while (num12 >= 1)
        { Console.WriteLine($"{num12}");
            num12--;
        }
        break;
    case 13:
        Console.WriteLine("Ejercio 13");
        int num13 = 1;
        while (num13 != 20 )
        {
            if (num13 % 2 == 0)
            { Console.WriteLine($"{num13}"); }
            else { Console.WriteLine(); }
            num13++;
               }
             break;
    case 14:
        Console.WriteLine("Ejercio 13");
        int num14 = 1;
        while (num14 != 20)
        {
            if (num14 % 2 == 0)
            { Console.WriteLine(); }
            else { Console.WriteLine($"{num14}"); }
            num14++;
        }
        break;


}