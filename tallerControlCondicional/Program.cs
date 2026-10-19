using System;
using System.ComponentModel;

class tallerControlCondicional
{
    static void Main()
    {
        string resultado = CheckNumber();
        Console.WriteLine(resultado);
    }

    static string CheckNumber()
    {
        Console.WriteLine("Ingrese un numero -> ");
        int numero = int.Parse(Console.ReadLine());

        string mensajeFinal;

        if (numero > 0)
        {
            mensajeFinal = "El número es positivo.";
        }
        else if (numero < 0)
        {
            mensajeFinal = "El número es negativo.";
        }
        else
        {
            mensajeFinal = "El número es cero.";
        }

        return mensajeFinal;

    }

};






