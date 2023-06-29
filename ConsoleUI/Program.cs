using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            foreach (var item in carManager.GetById(1))
            {
                Console.WriteLine(item.ModelYear);
            }

        }
    }
}