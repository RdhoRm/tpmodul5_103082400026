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

    public class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            this.Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.Data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser<String>("Ridho Ramadhan");

            DataGeneric<String> dataNIM = new DataGeneric<String>("103082400026");
            dataNIM.PrintData();

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}