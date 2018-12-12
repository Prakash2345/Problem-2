using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            double temp;
            Console.WriteLine("Enter the temperature");
            temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an Option");
            
            Console.WriteLine("1.Celcius To Farenheit\n2.Farenheit To Celcius");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {
                        Console.WriteLine("The Temperatue is : " + obj.celciustofarenheit(temp)+"F");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Temperatue is : " + obj.farenheittocelcius(temp) + "C");
                        break;
                    }
            }
            Console.Read();
        }
    }
}
