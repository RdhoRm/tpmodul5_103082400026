using System;

namespace tpmodul5_103082400026
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();

            halo.SapaUser<String>("Ridho Ramadhan");

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}