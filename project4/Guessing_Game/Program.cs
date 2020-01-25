using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string SecretWord = "Dancer";
            string guess ="";
            int guessCount =0;
            int guessLimit =3;
            bool outOfGuesses= false;
            while (guess != SecretWord && !outOfGuesses )
            {
                if(guessCount<guessLimit)
                {
                      Console.Write("Enter A guess: ");
                guess = Console.ReadLine();
                guessCount++;

                }else
                {
                    outOfGuesses= true;
                }
                if(outOfGuesses)
                {
                   Console.WriteLine("you Lose");
                }else
                {
                    Console.WriteLine("You win")
                }
                   ;
                
              
            }
           
        }
    }
}
