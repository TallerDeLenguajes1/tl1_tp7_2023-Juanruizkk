namespace EspacioCalculadora
{

    public class calculadora
    {
        private double dato;

        public double Resultado { get => dato; }
        public int a = 10;
        private int a = 4;

        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Resta(double termino)
        {
            dato -= termino;
        }
        public void Division(double termino)
        {
            dato /= termino;
        }
        public void Multiplicacion(double termino)
        {
            dato *= termino;
        }
        public void Limpiar()
        {
            dato = 0;
        }
    }

}

