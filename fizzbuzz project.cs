//Write a public method that accepts a number
    //Access Modifier 
    //Return Type
    //Method Name
    //Parameter
    //scope 
//------------------------------------------------------------------------//
public string FizzBuzz(int number)
{
    var answer = "";
    //when the number is divisible by 3 return the word fizz
    if (number % 3 == 0)
    {
      answer = "fizz";  
    }

//when the number is divisible by 5 return the word buzz
 if(number % 5 == 0)
    {
        answer += "buzz"; //NOTE: We can write it as answer = answer + buzz
    }
//when the number is divisible by both, return the word fizzbuzz 

    if (number % 3 == 0 && number % 5 == 0)
    {
        answer = "fizzbuzz";

    }
    return answer; 
}