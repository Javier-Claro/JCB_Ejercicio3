using Ejercicio3.Servicios;

namespace Ejercicio3.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {

            MetodosInterfaz mi = new MetodosImplementacion();
            int numPedido = mi.pedirNumero();

            mi.piramide(numPedido);


        }

    }

}