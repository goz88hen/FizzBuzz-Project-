//Write a public method that accepts a number
    //Access Modifier 
    //Return Type
    //Method Name
    //Parameter
    //scope 
//------------------------------------------------------------------------//
namespace FizzBuzz
{
    public class FizBuzz
    {
        public void FizzBuzz(int number)
        {
            for (int i = 1; i <= until; i++)
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
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}