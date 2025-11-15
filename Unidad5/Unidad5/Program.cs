using System;

namespace Unidad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon uno = new Pokemon("Skuirtel", 10, 50, TipoPokemon.Agua);
            Pokemon dos = new Pokemon("Chormander", 12, 40, TipoPokemon.Fuego);

            ImprimirPokemon(uno);
            ImprimirPokemon(dos);

            uno.ImprimirInformacion();
            dos.ImprimirInformacion();

            uno.ComerCaramelos(2);
            uno.ImprimirInformacion();

            dos.EstablecerVidaActual(0);
            Console.WriteLine(dos.Nombre + " debilitado: " + dos.Debilitado);
            dos.Curar();
            Console.WriteLine(dos.Nombre + " debilitado: " + dos.Debilitado);

            Console.WriteLine("Numero total de pokemons: " + Pokemon.NumeroPokemons);

            Gimnasio.Combate(uno, dos);
            Console.WriteLine("Vida de " + dos.Nombre + " despues del combate: " + dos.VidaActual + " (debilitado: " + dos.Debilitado + ")");
        }

        static void ImprimirPokemon(Pokemon p)
        {
            Console.WriteLine("Hola, soy " + p.Nombre + " y mi vida es " + p.VidaActual + " y mi ataque es " + p.AtaqueActual + ".");
        }
    }
}
