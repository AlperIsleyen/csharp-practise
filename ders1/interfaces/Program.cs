namespace Interfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAnimal kedi = new Kedi();
            IAnimal kopek = new Kopek();

            kedi.SesCikar(); 
            kopek.SesCikar(); // Hav

        }
    }
    interface IAnimal
    {
        void SesCikar();
    }

    class Kedi : IAnimal
    {
        public void SesCikar()
        {
            Console.WriteLine("Miyav");
        }
    }

    class Kopek : IAnimal
    {
        public void SesCikar()
        {
            Console.WriteLine("Hav");
        }
    }
}