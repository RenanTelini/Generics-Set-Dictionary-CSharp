using System.Globalization;
using RestrictionsForGenerics.Entities;
using RestrictionsForGenerics.Services;

namespace RestrictionsForGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of Products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(",");
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list);

            Console.WriteLine("Most expensive:");
            Console.WriteLine(p);
        }
    }
}