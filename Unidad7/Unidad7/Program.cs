using System;

class Program
{
    static void Main()
    {
        //Ejemplo de uso según el PDF:

        Pokemon uno = new Pokemon(10, 2, "Jose Antonio");
        Pokemon otro = new Pokemon(20, 3, "Maria Luisa");

        Pikachu pi = new Pikachu(10, 3, "El de ash");
        Pokemon pi2 = new Pikachu(20, 2, "El detective");

        pi.Gritar();

        //pi2.Gritar(); //ERROR: la clase Pokemon no tiene Gritar()

        ((Pikachu)pi2).Gritar(); //casting para llamar a Gritar
    }
}


//-------------------------------
//Clase base
//-------------------------------
class Pokemon
{
    protected int ataque;
    protected int vida;
    protected string nombre;

    public Pokemon(int vida, int ataque, string nombre)
    {
        this.vida = vida;
        this.ataque = ataque;
        this.nombre = nombre;
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Vida: " + vida);
        Console.WriteLine("Ataque: " + ataque);
    }
}


//-------------------------------
//Clase derivada 
//-------------------------------
class Pikachu : Pokemon
{
    public Pikachu(int vida, int ataque, string nombre) : base(vida, ataque, nombre)
    {
    }

    public void Gritar()
    {
        Console.WriteLine("Pikaaaa");
        Console.WriteLine("ah, y tengo " + this.vida + " de vida");
    }
}
