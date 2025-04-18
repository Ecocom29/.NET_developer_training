﻿namespace Interfaces_Middle_Level
{
    public sealed class Vehiculo: IVehiculo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Marca { get; set; }
        public string? Description { get; set; }

        public void Apagar()
        {
            Console.WriteLine("Se apagará");
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancará");
        }

        public void Avanzar()
        {
            Console.WriteLine("Avanzará");
        }

        public void Detener()
        {
            Console.WriteLine("Se detendrá");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenará");
        }
    }
}
