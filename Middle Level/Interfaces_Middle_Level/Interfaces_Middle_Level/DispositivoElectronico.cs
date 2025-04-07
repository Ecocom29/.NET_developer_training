namespace Interfaces_Middle_Level
{
    public class DispositivoElectronico: IVehiculo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DispositivoElectronico() { }

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
