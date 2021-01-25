using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            float Weight;
            float Height;

            Console.WriteLine("Please enter your weight in kilograms (kg).");
            Weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height in meters (m).");
            Height = float.Parse(Console.ReadLine());

            if (Weight > 0) { }
            else {Console.WriteLine("Please re-enter your weight in Kilograms (kg), your previous value was out of bounds.");
                  Weight = float.Parse(Console.ReadLine());       //recheck?
                 }

            if (Height > 0) {}
            else {Console.WriteLine("Please re-enter your height in meters (m), your previous value was out of bounds.");
                Height = float.Parse(Console.ReadLine());
                 }

            float BMI = Weight / ((float)Math.Pow(Height, 2F));

            Console.WriteLine(BMI);

            if ((BMI >= 18.5) && (BMI <= 25))
            { Console.WriteLine("You are of healthy weight, your BMI is "+BMI+"."); }
            else
            {
                if (BMI < 18.5)
                { Console.WriteLine("You are underweight, your BMI is "+BMI.ToString("0.00")+", which is below the threshold of 18.5."); }
                else
                { Console.WriteLine("You are overweight, your BMI is "+BMI.ToString("0.00")+" , which is above the threshold of 25."); }

            }

            


                Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();


                     



            //Console.WriteLine(Weight);
            //System.Threading.Thread.Sleep(5000);
        }
    }
}