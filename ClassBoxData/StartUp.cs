using System;

namespace ClassBoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                double lentgh = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Box box = new Box(lentgh,width,height);
                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
