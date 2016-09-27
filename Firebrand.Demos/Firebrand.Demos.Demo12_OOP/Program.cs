using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    class Program  
    {
        static void Main(string[] args)
        {
            Product[] productList = 
            {
                new Product(15, "Cheese", "Snack", "Cheddar"),
                new Product(10, "Cake", "Dessert", "Chocolate"),
                new Product(20, "Beer", "Drink", "Fruity")
            };

            Product[] orderedProductlist = BubbleSort<Product>(productList);

            //Array.Sort(productList);
            Console.WriteLine("Generic Bubble Sort");
            foreach (var product in orderedProductlist) 
            {
                Console.WriteLine("Product Name: {0}, Product Price: {1}", product.Name, product.Price);
            }

            Console.WriteLine("Int Bubble Sort");
            int[] intArray = new[] { 1, 34, 3, 54, 3, 456, 432, 564, 4, 34, 2 };

            int[] orderedArray = BubbleSort(intArray);

            foreach (var item in orderedArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        
        public static int[] BubbleSort(int[] array)
        {
            int temp;
            for (int outer = array.Length; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer - 1; inner++)
                {
                    if (array[inner] > array[inner + 1])
                    {
                        temp = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static T[] BubbleSort<T>(T[] array) where T : IComparable
        {
            T temp;
            for (int outer = array.Length; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer - 1; inner++)
                {
                    if (array[inner].CompareTo(array[inner + 1]) > 0)
                    {
                        temp = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
