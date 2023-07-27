//Write a public method that accepts a number
    //Access Modifier 
    //Return Type
    //Method Name
    //Parameter
    //scope 
//------------------------------------------------------------------------//
using system;
{
    namespace FizzBuzzDemo
 {
    public class FizBuzz
    {
        public static void Main(string [] args)
        {
            int limit = 20;
            for (int i = 1; i <= limit; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if ( i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                    Console.WriteLine(i);
                

                
            }
        }
    }
  }
}