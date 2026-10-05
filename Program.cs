using ClassLibrary1;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar("Dell", "XPS 15", "123456", "Laptop");
            bilgisayar.Marka = "Dell";
            Telefon telefon = new Telefon("Samsung", "Galaxy S21", "987654", "Akıllı Telefon");
            Console.WriteLine(bilgisayar.CihazGetir());
            Console.WriteLine(telefon.CihazGetir());
        }
    }
}
