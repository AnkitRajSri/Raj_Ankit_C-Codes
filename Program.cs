using System;
using System.Collections.Generic;

namespace Raj_Ankit_Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine() has been used after each method call to ensure a line break between two method outputs.
            //PrintPattern method is called by passing an int variable n as the parameter.
            int n = 5;
            Console.WriteLine("Output of Program 1: PrintPattern");
            Console.WriteLine("<----------------------------------->");
            PrintPattern(n);
            Console.WriteLine();

            //PrintSeries method is called by passing an int variable n2 as the parameter.
            int n2 = 6;
            Console.WriteLine("Output of Program 2: PrintSeries");
            Console.WriteLine("<----------------------------------->");
            PrintSeries(n2);
            Console.WriteLine();

            //UsfTime method is called by passing a string variable s as the parameter that contains an earth time in string format.
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine("Output of Program 3: UsfTime");
            Console.WriteLine("<----------------------------------->");
            Console.WriteLine(t);
            Console.WriteLine();

            //UsfNumbers method is called by passing int variables n3 and k as the parameters.
            int n3 = 110; 
            int k = 11;
            Console.WriteLine("Output of Program 4: UsfNumbers");
            Console.WriteLine("<----------------------------------->");
            UsfNumbers(n3, k);
            Console.WriteLine();

            //PalindromPairs method is called by passing a string array variable "words" as the parameter.
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            Console.WriteLine("Output of Program 5: PalindromeWords");
            Console.WriteLine("<----------------------------------->");
            PalindromePairs(words);
            Console.WriteLine();

            //Stones method is called by passing an int variable n4 as the parameter.
            int n4 = 9;
            Console.WriteLine("Output of Program 6: Stones");
            Console.WriteLine("<----------------------------------->");
            Stones(n4);
            Console.WriteLine();
        }


        private static void PrintPattern(int n)
        {
            try
            {
                //Write your code here .!
                //For loop is used inside a while loop to print all the numbers from n to 1, n times on a separate line.
                while(n > 0)
                {
                    for (int i = n; i > 0; i--)
                    {
                        Console.Write(i);
                    }
                    // Console.WriteLine() is used after the for loop to ensure a line break after each for loop iteration.
                     Console.WriteLine();
                    n = n - 1;
                }
                //The main challenge with this program was to make it work with a simple logic of nested iteration.
                //This method helped to understand the effective use of while and for loops and the role of Console.Write() and Console.WriteLine() commands.
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                //Write your code here .!!
                //Sum variable has been used inside a for loop to print a triangular number series till n terms.
                int sum = 0;
                for(int i = 1; i <= n2; i++)
                {
                    //IF condition has been used to check if the iteration has reached the final number in the series and separate the output values by a comma if it isn't the final value.
                    if (i < n2)
                    {
                        sum += i;
                        Console.Write(sum + ", ");
                    }
                    else
                    {
                        sum += i;
                        Console.Write(sum);
                    }
                }
                //The main challenge with this program was to handle the case of separating the values in the series by a comma.
                //The method helped to understand the effective use of IF Else statements to tackle the corner case of printing the output as a comma separated series.
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
            //Console.WriteLine() to make sure there is a line break after the final output.
            Console.WriteLine();
        }


        public static string UsfTime(string s)
        {
            //usfTime is defined on top of try-catch block as a string output has to be returned by this method. 
            String usfTime = "";
            try
            {
                //Write your code here .!!
                //The input string is split into a string array, and the hours, minutes, seconds and AM/PM values are stored in their respective separate variables.
                String [] earthTime = s.Split(":");
                int earthHrs = int.Parse(earthTime[0]);
                int earthMin = int.Parse(earthTime[1]);
                int earthSec = int.Parse(earthTime[2].Substring(0, 2));
                String dayNight = earthTime[2].Substring(2, 2);

                //New variables are instantiated to store the time values of UsfTime.
                int totalSec = 0;
                int usfSec = 0;
                int usfMin = 0;
                int usfHrs = 0;

                //IF Else statements have been used to check for AM/PM before converting the 12-hour earth time into 36-hour usf time format.
                //usfHrs, usfMin & usfSec store the hours, minutes and seconds values for usfTime respectively.
                //usfHrs, usfMin & usfSec are concatenated separated by ":" in the usfTime string variable
                if (dayNight == "PM")
                {
                    totalSec = (earthHrs + 12) * 60 * 60 + earthMin * 60 + earthSec;
                    usfHrs = totalSec / 2700;
                    usfMin = (totalSec - (usfHrs * 2700)) / 45;
                    usfSec = totalSec - (usfHrs * 2700) - (usfMin * 45);

                    usfTime = usfHrs + ":" + usfMin + ":" + usfSec;
                }
                else
                {
                    totalSec = earthHrs * 60 * 60 + earthMin * 60 + earthSec;
                    usfHrs = totalSec / 2700;
                    usfMin = (totalSec - (usfHrs * 2700)) / 45;
                    usfSec = totalSec - (usfHrs * 2700) - (usfMin * 45);

                    usfTime = usfHrs + ":" + usfMin + ":" + usfSec;
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return usfTime;

            //This program was challenging as it required me to understand the maths behind the time format conversion.
            //This program helped me understand the concepts and effective use of substring method and type casting.
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                // Write your code here
                //Number of lines in which the output needs to printed is stored in the variable m.
                int m = n3 / k;
                int j = 1;
                //IF condition to check if the total numbers is greater than the numbers on each line.
                if (n3 > k)
                {
                    //IF condition to check if the total numbers is divisible by numbers on each line, so that equal numbers can be printed on each line.
                    if (n3 % k == 0)
                    {
                        //For loop is used inside a while loop to print all the numbers 1 to n3, on m lines, with k numbers on each line.
                        while (m > 0)
                        {
                            //Numbers to be printed on each line are concatenated and stored in the string str.
                            String str = "";
                            for (int i = j; i <= k; i++)
                            {
                                //IF else conditions to substitute values divisible by 3, 5, 7 with their respective alphabets as mentioned in the question.
                                if (i % 3 == 0 && i % 5 != 0 && i != 7)
                                {
                                    str = str + "U" + " ";
                                }
                                else if (i % 3 == 0 && i % 5 == 0 && i % 7 != 0)
                                {
                                    str = str + "US" + " ";
                                }
                                else if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                                {
                                    str = str + "USF" + " ";
                                }
                                else if (i % 3 != 0 && i % 5 == 0 && i % 7 != 0)
                                {
                                    str = str + "S" + " ";
                                }
                                else if (i % 3 != 0 && i % 5 != 0 && i % 7 == 0)
                                {
                                    str = str + "F" + " ";
                                }
                                else if (i % 3 == 0 && i % 5 != 0 && i % 7 == 0)
                                {
                                    str = str + "UF" + " ";
                                }
                                else
                                {
                                    str = str + i + " ";
                                }

                            }
                            //The numbers stored in str are printed after each for loop.
                            Console.WriteLine(str);

                            //Values of j, k and m are updated for the next line to be printed using for loop.
                            j = j + 11;
                            k = k + 11;
                            m = m - 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Add a few more numbers for equal numbers on each line.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry! There should be at least " + k + " numbers on each line.");
                }
                
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
            //This program was challenging as it required handling all the corner cases like updating the multiples of 3, 5 and 7 according to the logic.
            //This program helped me to understand the effective use of multiple conditions inside an IF statement.
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Write your code here
                //An array list is defined to add the different palindrom pairs in a single list.
                List<String> palinPairs = new List<String> { };

                //A nested for loop is used to compare and perform operations between the elements within the string array.
                for(int i = 0; i < words.Length; i++)
                {
                    for(int j = 0; j < words.Length; j++)
                    {
                        //IF condition to make sure we aren't comparing any array element with itself.
                        if(i != j)
                        {
                            //The string reverse is used to store the elements of the reverse char array chArray as a string.
                            String reverse = "";
                            char[] chArray = (words[i] + words[j]).ToCharArray();
                            Array.Reverse(chArray);
                            reverse = new string(chArray);

                            //IF condition to compare if two elements together form a palindrome pair.
                            if (words[i] + words[j] == reverse)
                            {
                                //The elements are concatenated as a string and added to the dynamic array list.
                                String pair = "";
                                pair = "[" + i + ", " + j + "]";
                                palinPairs.Add(pair);
                            }
                        }
                    }
                }
                //If else condition to check if the palinPairs array list is blank.
                if (palinPairs.Count == 0)
                {
                    Console.WriteLine("Sorry! No palindrome pairs found.");
                }
                else
                {
                    //Each string element of the array list palinPairs is printed using an advanced for loop separated by a comma.
                    foreach (String s in palinPairs)
                    {
                        //If else condition to check there is no comma after the last element of the array list.
                        if(s == palinPairs[palinPairs.Count - 1])
                        {
                            Console.Write(s);
                        }
                        else
                        {
                            Console.Write(s+", ");
                        }
                            
                    }
                }
                //Console.WriteLine() to make sure there is a line break after the final output.
                Console.WriteLine();
            }
            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
            //The major challenge was printing the elements of the array list in the desired format, so that it is easily understood by everyone.
            //This program helped me to understand the effective use of the reverse function of a charArray.
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
                //If else conditions are used to check if the number n4 is a multiple of 4 and if it is greater than 4.
                if(n4%4 == 0)
                {
                    Console.WriteLine(false);
                }
                else if(n4 < 4)
                {
                    Console.WriteLine(n4);
                }
                else
                {
                    //A dynamic array list with an element "1" that I have used for my case has been instantiated to store other possible values of the draw.
                    List<int> list = new List<int>(new int[] {1});

                    //The value of n4 is decreased by 1 as we have already stored the first draw value 1 in the array list.
                    n4 = n4 - 1;

                    //While loop is used till the value of n4 > 0, to add the corrsponding values from the next draws.
                    while(n4 > 0)
                    {
                        //If n4 is greater than 3, then 3 is the next draw value, else the value of n4 is added in the array list.
                        if(n4 - 3 > 0)
                        {
                            list.Add(3);
                            n4 = n4 - 3;
                        }
                        else
                        {
                            list.Add(n4);
                            n4 = 0;
                        }
                    }

                    //For loop is used to print the elements stored in the arrayList list in the desired output format.
                    for(int i = 0; i < list.Count; i++) {
                        if(i == 0)
                        {
                            Console.Write("["+list[i]+", ");
                        }
                        else if(i == list.Count - 1)
                        {
                            Console.Write(list[i] + "]");
                        }
                        else
                        {
                            Console.Write(list[i] + ", ");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }

            //This program was really challenging as it took me quiet a while to understand what exactly is the question asking for.
            //As per my understanding, the program asked to print any one of the possible combination of draws in which I would win, so I chose the condition when I would always draw 1 in the first draw.
            //I really think this program needs a little bit more elaboration, as it isn't that easy to figure out the desired output.
            //This program helped me to challenge myself to come up with a logic of my own that could satisfy one of the possible output for any number.
        }


    }
}
