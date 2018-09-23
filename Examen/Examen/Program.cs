using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcion, OpcionDos;
            Console.Title = "Examen Jaramillo Regino Hector Armando";
            Marcador:
            Console.WriteLine("Menu para escoger el programa a ejecutar \nPresione el numero de la opcion y Enter " +
                "\n1.-Codigo 1 \n2.-Codigo 2 \n3.-Codigo 3 \n4.-Codigo 4 \n5.-Codigo 5 \n6.-Codigo 6,\n7.-Codigo 7 \n8.-Codigo 8");
            Opcion = Convert.ToInt32(Console.ReadLine());
            switch(Opcion)
            {
                case 1:
                    Codigo1(); 
                    break;
                case 2:
                    Codigo2();
                    break;
                case 3:
                    Codigo3();
                    break;
                case 4:
                    Codigo4();
                    break;
                case 5:
                    Codigo5();
                    break;
                case 6:
                    Codigo6();
                    break;
                case 7:
                    Codigo7();
                    break;
                case 8:
                    Codigo8();
                    break;

            }
            Console.WriteLine("Presione Enter Para Continuar...");
            Console.ReadKey(true);
            Console.WriteLine("¿Desea consultar otro codigo? \n1.-Si \n2.-No");
            OpcionDos = Convert.ToInt32(Console.ReadLine());
            switch(OpcionDos)
            {
                case 1:
                    {
                        Console.Clear();
                        goto Marcador;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Gracias por Utilizar el Programa \nPresione Enter Para Terminar");
                        break;
                    }
            }
            Console.ReadKey();
        }
        public static void Codigo1()
        {
            int Tamaño, Guardado, Tamaño2;
            Console.WriteLine("Ingrese la cantidad de numeros tendra la sucesion");
            Tamaño = Convert.ToInt32(Console.ReadLine());
            Tamaño2 = Tamaño - 1;
            int[] Arreglo = new int[Tamaño];
            for (int Indice = 0; Indice < Arreglo.Length; Indice++)
            {
                Console.WriteLine("Ingrese un numero ");
                Guardado = Convert.ToInt32(Console.ReadLine());
                Arreglo[Indice] = Guardado;
            }
            string Impress()
            {
                Console.WriteLine("La sucesion es: ");
                for (int Indice2 = 0; Indice2 < Tamaño; Indice2++)
                {
                    Console.Write(Arreglo[Indice2] + " ");
                }
                return " ";
            }
            Console.WriteLine(Impress());
            Array.Sort(Arreglo);
            Console.WriteLine("Numero Menor= {0}, Numero Mayor= {1}", Arreglo[0], Arreglo[Tamaño2]);
            
        }
        public static void Codigo2()
        {
            int Tamaño;
            string Guardado;
            Console.WriteLine("Ingrese la cantidad de numeros que tendra la sucesion");
            Tamaño = Convert.ToInt32(Console.ReadLine());            
            string[] ArreglaDos = new string[Tamaño];
            for (int Indice = 0; Indice < ArreglaDos.Length; Indice++)
            {
                Console.WriteLine("Ingrese un numero ");
                Guardado = Console.ReadLine();
                ArreglaDos[Indice] = Guardado;
            }
            string Impresion()
            {                
                for (int Indice2 = 0; Indice2 < Tamaño; Indice2++)
                {
                    Console.Write(ArreglaDos[Indice2] + " ");
                }
                return " ";
            }
            Console.Write("Sucesion Normal: ");
            Console.WriteLine(Impresion());
            Array.Reverse(ArreglaDos);
            Console.Write("Sucesion Invertida: ");
            Console.Write(Impresion());
        }
        public static void Codigo3()
        {
            int Tamaño, Variable = 0, SuperIndice = 0;
            int Guardado;
            Console.WriteLine("Ingrese la cantidad de numeros tendra la sucesion");
            Tamaño = Convert.ToInt32(Console.ReadLine());           
            int[] Arreglo = new int[Tamaño];
            for (int Indice = 0; Indice < Arreglo.Length; Indice++)
            {
                Console.WriteLine("Ingrese un numero ");
                Guardado = Convert.ToInt32(Console.ReadLine());
                Arreglo[Indice] = Guardado;
            }
            for (int Indice = 0; Indice < Arreglo.Length; Indice++)
            {
                if (Variable < Arreglo[Indice] || Variable == Arreglo[Indice])
                {
                    Variable = Arreglo[Indice];
                    SuperIndice = Indice;
                }
            }
            string Impress()
            {
                Console.WriteLine("La sucesion es: ");
                for (int Indice = 0; Indice < Tamaño; Indice++)
                {
                    Console.Write(Arreglo[Indice] + " ");
                }
                return " ";
            }
            Console.WriteLine(Impress());
            Console.WriteLine("El numero mayor es: {0} y la ultima vez que aparece es en la posicion {1}", Variable, SuperIndice + 1);
        }
        public static void Codigo4()
        {
            int VariableA, VariableB, VariableC;
            Console.WriteLine("Ingrese el valor de A:");
            VariableA=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de B:");
            VariableB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de C:");
            VariableC = Convert.ToInt32(Console.ReadLine());
            if(VariableA>VariableB && VariableB>VariableC){ Console.WriteLine("El numero menor es C: {0}", VariableC);}
            if(VariableB>VariableA && VariableA>VariableC){ Console.WriteLine("El numero menor es C: {0}", VariableC);}
            if(VariableA>VariableC && VariableC>VariableB){ Console.WriteLine("El numero menor es B: {0}", VariableB);}
            if(VariableC>VariableA && VariableA>VariableB){ Console.WriteLine("El numero menor es B: {0}", VariableB);}
            if(VariableB>VariableC && VariableC>VariableA){ Console.WriteLine("El numero menor es A: {0}", VariableA);}
            if(VariableC>VariableB && VariableB>VariableA){ Console.WriteLine("El numero menor es A: {0}", VariableA);}
        }
        public static void Codigo5()
        {
            int Tamaño, Variable = 0, SuperIndice = 0;
            int guardado;
            Console.WriteLine("Ingrese la cantidad de numeros tendra la sucesion");
            Tamaño = Convert.ToInt32(Console.ReadLine());
            int[] Arreglo = new int[Tamaño];
            for (int Indice = 0; Indice < Arreglo.Length; Indice++)
            {
                Console.WriteLine("Ingrese un numero ");
                guardado = Convert.ToInt32(Console.ReadLine());
                Arreglo[Indice] = guardado;
            }
            for (int Indice = 0; Indice < Arreglo.Length; Indice++)
            {
                if (Variable < Arreglo[Indice])
                {
                    Variable = Arreglo[Indice];
                    SuperIndice = Indice;
                }
            }
            string Impress()
            {
                Console.WriteLine("La sucesion es: ");
                for (int Indice = 0; Indice < Tamaño; Indice++)
                {
                    Console.Write(Arreglo[Indice] + " ");
                }
                return " ";
            }
            Console.WriteLine(Impress());
            Console.WriteLine("El numero mayor es: {0} y la primera vez que aparece es en la posicion {1}", Variable, SuperIndice + 1);
        }
        public static void Codigo6()
        {
            int Tamaño;
            int Guardado;
            Console.WriteLine("Ingrese la cantidad de numeros tendra la sucesion");
            Tamaño = Convert.ToInt32(Console.ReadLine());
            int[] Arreglo = new int[Tamaño];
            int Variable = Arreglo[0];
            for (int Indice = 0; Indice < Arreglo.Length; Indice++)
            {
                Console.WriteLine("Ingrese un numero ");
                Guardado = Convert.ToInt32(Console.ReadLine());
                Arreglo[Indice] = Guardado;
            }
            for (int Indice = 1; Indice < Arreglo.Length; Indice++)
            {
                if (Variable < Arreglo[Indice])
                {
                    Variable = Arreglo[Indice];
                    if (Variable < Arreglo[Indice])
                    {
                        break;
                    }
                }
            }
            string Impress()
            {
                Console.WriteLine("La sucesion es: ");
                for (int Indice = 0; Indice < Tamaño; Indice++)
                {
                    Console.Write(Arreglo[Indice] + " ");
                }
                return " ";
            }
            Console.WriteLine(Impress());
            Console.WriteLine("El primer numero mayor que su predecesor es {0}", Variable);
            if (Arreglo[0] < Arreglo[1])
            { Console.WriteLine("La sucesion es No Decreciente:  0"); }
        }
        public static void Codigo7()
        {
            int Tamaño, Guardado;
            Console.WriteLine("Ingrese la cantidad de numeros tendra el vector");
            Tamaño = Convert.ToInt32(Console.ReadLine());            
            int[] b = new int[Tamaño];
            Random Aleatorio = new Random();
            for (int Indice = 0; Indice < b.Length; Indice++)
            {                
                Guardado = Aleatorio.Next(1,100);
                b[Indice] = Guardado;
            }
            string Impresion()
            {
                Console.WriteLine("La sucesion es: ");
                for (int Indice2 = 0; Indice2 < Tamaño; Indice2++)
                {
                    Console.Write(b[Indice2] + " ");
                }
                return " ";
            } 
            string ImpresionDos()
            {
                Console.WriteLine("La sucesion Ordenada en Orden asendente es : ");
                for (int Indice2 = 0; Indice2 < Tamaño; Indice2++)
                {
                    Console.Write(b[Indice2] + " ");
                }
                return " ";
            }
            Console.WriteLine(Impresion());
            Array.Sort(b);
            Console.WriteLine(ImpresionDos());
        }
        public static void Codigo8()
        {
            String Numero;
            Marca:
            int Contador = 0;
            Console.WriteLine("Ingrese un numero de 5 digitos");
            Numero = Console.ReadLine();
            foreach (char Digito in Numero)
            {
                Contador++;
            }
            if (Contador > 5)
            { Console.WriteLine("El numero solo debe tener 5 digitos"); goto Marca; }
            else if (Contador < 5)
            { Console.WriteLine("El numero debe tener 5 digitos"); }
            Char[] Capturador = Numero.ToCharArray();
            Console.Write("Numero Inverso es: ");
            for (int Indice = 4; Indice > -1; Indice--)
            {
                Console.Write(Capturador[Indice]);
            }
            Console.WriteLine();
            Array.Reverse(Capturador);
            string Inverso = new string(Capturador);
            if (Numero.Equals(Inverso))
            {
                Console.WriteLine("El numero es Palindrome");
            }
            else { Console.WriteLine("El numero no es Palindrome"); }
        }
    }
}
