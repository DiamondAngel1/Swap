using System;
using System.Text;
namespace SwapProject{
    internal class Program{
        static void Main(string[] args){
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Random r = new Random();
            int a = r.Next(1,101), b = r.Next(1,101);
            Console.WriteLine("Початкові значення: a = {0}, b = {1}",a,b);
            SwapMethod.Swap(ref a, ref b);
            Console.WriteLine("Значення після заміни: a = {0}, b = {1}",a,b);


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\nПочатковий масив:");
            foreach (int i in arr){
                Console.Write(i + " ");
            }
            SwapMethod.Swap(ref arr[1], ref arr[7]);
            Console.WriteLine("\nМасив після зміни:");
            foreach (int i in arr){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            string x = "Hello", y = "World!"; 
            Console.WriteLine("\nПочаткові значення: x = {0}, y = {1}",x,y); 
            SwapMethod.Swap(ref x, ref y);
            Console.WriteLine("Значення після заміни: x = {0}, y = {1}",x,y);

        }
    }
}
