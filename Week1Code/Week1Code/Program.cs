using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Code
{
    /// <summary>
    /// I need an object for my sentence to see if a word attach with a punctuation.
    /// </summary>
    class PunctuationAt
    {
        private int pos;
        private char punctuation;
        private int i;
        private char tempChar;

        /// <summary>
        /// this object takes 2 arguments
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="punctuation"></param>
        PunctuationAt(int pos, char punctuation)
        {
            this.pos = pos;
            this.punctuation = punctuation;
        }

        public PunctuationAt(int i, char tempChar)
        {
            // TODO: Complete member initialization
            this.i = i;
            this.tempChar = tempChar;
        }

        public int getPos()
        {
            return pos;
        }

        public string getPunctuation()
        {
            return punctuation.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = "n";

            while (input != "y")
            {
                Console.WriteLine("Hello, this is week 1 code challenge,\nPlease select from the menu below:");
                Console.WriteLine("1. FizzBuzz\n2. TextStats\n3. Yodaizer\n4. IsPrime\n5. DashInsert\nQuit? y/n");
                input = Console.ReadLine();

                if (input == "1") Console.WriteLine(FizzBuzz(33));
                if (input == "2") TextStats();
                if (input == "3") Yodaizer();
                if (input == "4") IsPrime(5);
                if (input == "5") DashInsert("123451223");
            }
            

        }

        /// <summary>
        /// See a number that is divisible by 3, 5, or both.
        /// </summary>
        static string FizzBuzz(int number)
        {
            string BuzzOrNot = "";

            if (number % 3 == 0)
            {
                BuzzOrNot = "Buzz";
                if (number % 5 == 0)
                {
                    BuzzOrNot = "FizzBuzz";
                }
            }
            else if (number % 5 == 0)
            {
                BuzzOrNot = "Fizz";
            }
            else
            {
                BuzzOrNot = number.ToString();
            }

            /*Console.WriteLine("Any key to continue...");
            Console.ReadKey();*/

            return BuzzOrNot;
        }

        /// <summary>
        /// Calculates how many constants and vowels within a string
        /// </summary>
        static void TextStats()
        {
            string someString2Calculate = "Superman";
            int numberOConstants = 0;
            int numberOVowels = 0;

            for (int i = 0; i < someString2Calculate.Length; i++)
            {
                char tempLetter = someString2Calculate[i];

                if (tempLetter == 'a' || tempLetter == 'e' || tempLetter == 'i' || tempLetter == 'o' || tempLetter == 'u')
                {
                    numberOVowels++;
                }
                else
                {
                    numberOConstants++;
                }
            }

            // for this purpose right now print out a lovely sentence.
            Console.WriteLine("{0} has {1} constants and {2} vowels.", someString2Calculate, numberOConstants, numberOVowels);

            Console.WriteLine("Any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Reverse the words in a sentence. I want to split the sentence into a more useable object like an array or 
        /// list.  The first element or word needs to lower case; if I make the sentence lower, I may miss a name or 
        /// some kind of miss place lettering. I am going to treat the array like an array. I am going to compare 
        /// each letter of each element of the array and see if it's a letter or not.  The only exception is a 
        /// single quote. Where the punctuation is I need a word count, I was thinking of having a list for the word 
        /// count because it could have more than one punctuation within the sentence. When, I find the punctuation,
        /// I need to remove from the word and store it as well. To reverse it, I need to uppercase the first letter
        /// of the beginning of the sentence. With a word count, I can place the store punctuation with the new word.
        /// </summary>
        static void Yodaizer()
        {
            string someKindOLongString = "This is the first time I have done this.";
            string[] sentenceArray = someKindOLongString.Split(' ');
            string[] reverseArray = new string[someKindOLongString.Length];
            // using a list b/c we don't know how many punctuation in the string
            List<PunctuationAt> placePunctuationAt = new List<PunctuationAt>();

            // this is to find the punctuation and taking
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                string tempString = sentenceArray[i];   // pulling the word and putting temp variable
                // get the punctuation a word and removing from the word.
                for (int x = 0; x < tempString.Length; x++)
                {
                    char tempChar = Convert.ToChar(tempString[x]);
                    string stringTemp = "";
                    if (!(Char.IsLetter(tempChar))){
                        placePunctuationAt.Add(new PunctuationAt(i, tempChar));
                    }
                    else
                    {
                        stringTemp += tempChar;
                    }
                    tempString = stringTemp;
                    sentenceArray[i] = tempString;
                }
            }
        }

        /// <summary>
        /// find a number that is prime
        /// </summary>
        /// <param name="number">a number to find</param>
        /// <returns>if is prime true or false</returns>
        static bool IsPrime(int number)
        {
            int[] exceptNumbers = { 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < exceptNumbers.Length; i++)
            {
                if (number % exceptNumbers[i] == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// take a string of numbers and find the two odd numbers that are next to eachother and place a dash.
        /// </summary>
        /// <param name="numbers">String of numbers</param>
        /// <returns>the new string of numbers with a dash between 2 odd numbers</returns>
        static string DashInsert(string numbers)
        {
            string retString = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) % 3 == 0)
                {
                    retString += Convert.ToInt32(numbers[i]).ToString();
                    // we look at the next element if that odd as well
                    if (Convert.ToInt32(numbers[i + 1]) % 3 == 0)
                    {
                        retString += "-" + numbers[i+1].ToString();
                    }
                }
                else
                {
                    // else it is even
                    retString += numbers[i].ToString();
                }
            }
            return retString;
        }
    }
}
