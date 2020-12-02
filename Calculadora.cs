using System;
using System.Collections.Generic;
using System.Text;

namespace calc
{
    class Calculadora
    {
        // Variables globales en clase
        int op, res, num1, num2;
        // 
        public int elegirOp()
        {
            // Mensaje de Bienvenida
            Console.WriteLine("Elige una de las operaciones");
            Console.WriteLine("1. Suma");       // 5 + 0 = 5
            Console.WriteLine("2. Resta");      // 5 - 0 = 5
            Console.WriteLine("3. Producto");   // 5 * 0 = 0
            Console.WriteLine("4. División");   // Evitar dividir por cero
            Console.WriteLine("5. Potencia");   // 5 ^ 3 = 125
            // Recibir int para elegir operación
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elegiste: " + op);
            return op;
        }
        public float pedirNum1()
        {
            Console.WriteLine("Introduce primer operando:");
            num1 = Convert.ToInt32(Console.ReadLine());
            //num1 = float.Parse(Console.ReadLine());
            return num1; 
        }
        public float pedirNum2()
        {
            // if +  while
            // if (condicion para comprobar si op es 4){ while ...}
            // while (condicion de que num2 sea cero) {pedir otro número ==> lo guardamos en num2}
            Console.WriteLine("Introduce segundo operando:");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (op == 4)
            {
                while (num2 == 0)
                {
                    Console.WriteLine("Por favor, elige un número distinto de cero: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
            }
            return num2;
            // Ejercicio 1: ¿cómo se puede validar que no sea cero para la división?
            // Ejercicio 2: Introducir un contador para pedir el valor distinto de cero
            //              solo 3 veces. Después, salir del programa.
        }
        public void realizarOp()
        {
            switch (op)
            {
                case 1:
                    Suma(num1, num2);
                    break;
                case 2:
                    Resta(num1, num2);
                    break;
                case 3:
                    Prod(num1, num2);
                    break;
                case 4:
                    Div(num1, num2);
                    break;
                case 5:
                    Pot(num1, num2);
                    break;
            }
        }
        public int Suma(int num1, int num2)
        {
            Console.WriteLine("--- Suma ---");
            res = num1 + num2;
            Console.WriteLine("Resultado: " + res);
            return res;
            // Ejercicio 3: Expresar los decimales de "float"
        }
        public int Resta(int num1, int num2)
        {
            Console.WriteLine("--- Resta ---");
            res = num1 - num2;
            Console.WriteLine("Resultado: " + res);
            return res;
        }
        public int Prod(int num1, int num2)
        {
            Console.WriteLine("--- Producto ---");
            res = num1 * num2;
            Console.WriteLine("Resultado: " + res);
            return res;
        }
        public int Div(int num1, int num2)
        {
            Console.WriteLine("--- División ---");
            res = num1 / num2;  // 5 / 0 > Error
            Console.WriteLine("Resultado: " + res);
            return res;
        }
        public int Pot(int num1, int num2)
        {
            Console.WriteLine("--- Potencia ---");
            // Pasar la operación a doubles ^ 
            res = 1;
            for (int i = 0; i < num2; i++)
            {
                res *= num1; 
                // Ejemplo con 5 ^3
                // 5*1 = 5
                // 5*5 = 25
                // 25*5 = 125

            }
            //res = num1 ^ num2;
            //res = Math.Pow(double1, myexp);
            Console.WriteLine("Resultado: " + res);
            return res;
        }
    }
}
