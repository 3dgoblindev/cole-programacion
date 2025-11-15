namespace Unidad5
{
    public static class Gimnasio
    {
        public static void Combate(Pokemon a, Pokemon b)
        {
            int danio = a.AtaqueActual;
            if (Ventaja(a.Tipo, b.Tipo))
            {
                danio *= 2;
            }

            b.RecibirDanio(danio);
        }

        private static bool Ventaja(TipoPokemon atacante, TipoPokemon defensor)
        {
            if (atacante == TipoPokemon.Agua && defensor == TipoPokemon.Fuego)
            {
                return true;
            }

            if (atacante == TipoPokemon.Fuego && defensor == TipoPokemon.Planta)
            {
                return true;
            }

            if (atacante == TipoPokemon.Planta && defensor == TipoPokemon.Agua)
            {
                return true;
            }

            return false;
        }
    }
}
