using System;

namespace Unidad5
{
    public enum TipoPokemon
    {
        Agua,
        Fuego,
        Planta
    }

    public class Pokemon
    {
        private static int numeroPokemons = 0;

        private string nombre;
        private int ataqueBase;
        private int vidaBase;
        private int ataqueActual;
        private int vidaActual;
        private bool debilitado;
        private TipoPokemon tipo;

        public Pokemon(string nombre, int ataqueBase, int vidaBase, TipoPokemon tipo)
        {
            this.nombre = nombre;
            this.ataqueBase = ataqueBase;
            this.vidaBase = vidaBase;
            this.ataqueActual = ataqueBase;
            this.vidaActual = vidaBase;
            this.tipo = tipo;
            this.debilitado = false;
            numeroPokemons++;
        }

        public string Nombre => nombre;
        public int AtaqueBase => ataqueBase;
        public int VidaBase => vidaBase;
        public int AtaqueActual => ataqueActual;
        public int VidaActual => vidaActual;
        public bool Debilitado => debilitado;
        public TipoPokemon Tipo => tipo;
        public static int NumeroPokemons => numeroPokemons;

        public void ImprimirInformacion()
        {
            Console.WriteLine("Hola, soy " + nombre + ", mi vida actual es " + vidaActual + " y mi ataque actual es " + ataqueActual + ".");
        }

        public void ComerCaramelos(int cantidad)
        {
            if (cantidad < 0)
            {
                cantidad = 0;
            }

            long nuevoAtaque = (long)ataqueActual * cantidad;
            if (nuevoAtaque < 0)
            {
                nuevoAtaque = 0;
            }

            if (nuevoAtaque > int.MaxValue)
            {
                nuevoAtaque = int.MaxValue;
            }

            ataqueActual = (int)nuevoAtaque;
        }

        public void Curar()
        {
            ataqueActual = ataqueBase;
            vidaActual = vidaBase;
            if (vidaActual > 0)
            {
                debilitado = false;
            }
        }

        public void EstablecerAtaqueActual(int valor)
        {
            if (valor < 0)
            {
                valor = 0;
            }

            ataqueActual = valor;
        }

        public void EstablecerVidaActual(int valor)
        {
            if (valor < 0)
            {
                valor = 0;
            }

            vidaActual = valor;
            if (vidaActual == 0)
            {
                debilitado = true;
            }
            else
            {
                debilitado = false;
            }
        }

        public void RecibirDanio(int danio)
        {
            if (danio < 0)
            {
                danio = 0;
            }

            int nuevaVida = vidaActual - danio;
            if (nuevaVida < 0)
            {
                nuevaVida = 0;
            }

            EstablecerVidaActual(nuevaVida);
        }
    }
}
