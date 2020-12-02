using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            calc.elegirOp();
            calc.pedirNum1();
            calc.pedirNum2();
            calc.realizarOp();

            // Clase Ejemplo
            //Ejemplo hola = new Ejemplo();
            //hola.hola();
        }
    }
}
