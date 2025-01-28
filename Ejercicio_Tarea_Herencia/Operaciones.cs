
namespace Ejercicio_Tarea_Herencia
{
    public class Operaciones
    {

        public double Area (double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double Longitud (double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double Volumen (double lado)
        {
            return Math.Pow(lado, 3);
        }

    }
}
