using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Practice
{

    public class RangeOfArray 
    {
        int[] array;

        public RangeOfArray() 
        {
            array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next();
            }
        }
        public int this[int index]
        {
            get
            {
                if(index > 0 && index <= array.Length)
                { 
                    return array[index-1];
                }
                
                else 
                {
                    throw new Exception();
                }
            }
        }


        public override string ToString()
        {
            string result = " ";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            Supermarket supermarket = new Supermarket();
            Console.WriteLine("Sum of all products: " + supermarket[1]);

            Console.ReadKey();
        }
    }
}
