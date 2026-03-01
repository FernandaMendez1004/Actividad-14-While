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
        while (num11 <= 10)
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
        while (num13 != 20)
        {
            if (num13 % 2 == 0)
            { Console.WriteLine($"{num13}"); }
            else { Console.WriteLine(); }
            num13++;
        }
        break;
    case 14:
        Console.WriteLine("Ejercio 14");
        int num14 = 1;
        while (num14 != 20)
        {
            if (num14 % 2 == 0)
            { Console.WriteLine(); }
            else { Console.WriteLine($"{num14}"); }
            num14++;
        }
        break;
    case 15:
        Console.WriteLine("Ejercicio 15");
        int num15 = 1;
        int t = 1;
        while (num15 != 100)
        {
            t = t + num15;
            num15++;
            t++;

        }
        Console.WriteLine($"{t}");
        break;
    case 16:
        Console.WriteLine("Ejercicio 16");
        int num16 = 1;
        while (num16 != 0)
        { Console.WriteLine("Ingrese un numero");
           num16 = int.Parse(Console.ReadLine()); } 
break;
    case 17:
        Console.WriteLine("Ejercicio 17");
        int num17 = 1;
        int posi = 0;
        while (num17 != 0)
        {
            Console.WriteLine("Ingrese un nuumero");
            num17 = int.Parse(Console.ReadLine());
            if (num17 > 0)
            { 
            posi ++; 
            }
            else { Console.WriteLine(); }
        }
        Console.WriteLine($"Fueron {posi} positivos");
        break;
    case 18:
        Console.WriteLine("Ejercicio 18");
        Console.WriteLine("Ingrese el numero para calcular el factorial:");
        int num18 = int.Parse(Console.ReadLine());
        int factorial = 1;
        int i = 1;
        while (i <= num18)
        {
            factorial = factorial * i;
            i++;
        }
        Console.WriteLine($"El factorial de {num18}! = {factorial}");
        break;
    case 19:
        Console.WriteLine("Ejercicio 19");
        Console.WriteLine("Ingrese un numero para tabla de multiplicar");
        int num19 = int.Parse(Console.ReadLine());
        int numtabla = 1;
        while (numtabla <= 10 )
        { Console.WriteLine($"{numtabla} * {num19} = {numtabla * num19} ");
            numtabla++; 
        }
        break;
    case 20:
        Console.WriteLine("Ejercicio 20");
        Console.WriteLine("Ingrese un número:");
        int num20 = int.Parse(Console.ReadLine());
        int contador = 0;
        while (num20 != 0)
        {
            num20 = num20 / 10;
            contador++;
        }
        Console.WriteLine($"El número tiene {contador} dígitos");
        break;
}