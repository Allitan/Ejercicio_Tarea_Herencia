

namespace Ejercicio_Tarea_Herencia
{
    public class Calculos : Operaciones
    {

        public void Imprimir()
        {
            double radio = 5;
            double lado = 5;

            Console.WriteLine("Operaciones: ");
            Console.WriteLine();
            Console.WriteLine($"Area de un circulo con radio {radio}: {Area(radio)}");
            Console.WriteLine();
            Console.WriteLine($"Longitud de una circunferencia con radio {radio}: {Longitud(radio)}");
            Console.WriteLine();
            Console.WriteLine($"Volumen de un cubo con un lado {lado}: {Volumen(lado)}");

            
        }

    }
}
