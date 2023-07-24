using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido 
            // reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
           
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"
            char letra;  
            int indice = 0;
            char[] cadenaFuente = new char [20];
            char caracter1 ;
            char caracter2 ;

            Console.WriteLine("Ingrese una oración letra a letra: (termina con ingresar un punto)");
            letra = char.Parse(Console.ReadLine());
            while (letra != '0' || indice < 20 )
            {
                cadenaFuente[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            } 
            cadenaFuente[indice] = '\0';
            
            
            Console.WriteLine("Ingrese el primer carácter: ");
            caracter1 = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el segundo carácter: ");
            caracter2 = char.Parse(Console.ReadLine());

            indice = 0;
            while (indice < 20)
            {
                if (cadenaFuente[indice] == caracter1)
                    cadenaFuente[indice] = caracter2;
                indice++;
            }
            indice = 0;
            while(cadenaFuente[indice] != '\0')
                Console.Write(cadenaFuente[indice]);
        }
    }
}
