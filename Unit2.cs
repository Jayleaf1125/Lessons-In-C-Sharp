using System;

namespace UnitTwo
{
    class Unit_2_2
    {
        public void LoopingATriangle()
        {
            string output = "";

            for (int i = 1; i <= 7; i++)
            {
                output += '#';
                Console.WriteLine(output);
            }
        }

        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public void ChessBoard()
        {
            /* <Simple Implementation> */

            for (int i = 1; i <= 8; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(" # # # #");
                }
                else
                {
                    Console.WriteLine("# # # # ");
                }
            }

            /* 
            <Complex Implementation>

            for (int chess_line = 1; chess_line <= 8; chess_line++)
            {
                string output = "";

                if (chess_line % 2 == 0)
                {
                    for (int chess_digit = 1; chess_digit <= 8; chess_digit++)
                    {
                        if (chess_digit % 2 != 0)
                        {
                            output += '#';
                        }
                        else
                        {
                            output += ' ';
                        }
                    }
                }
                else
                {
                    for (int chess_digit = 1; chess_digit <= 8; chess_digit++)
                    {
                        if (chess_digit % 2 != 0)
                        {
                            output += ' ';
                        }
                        else
                        {
                            output += '#';
                        }
                    }
                }
                Console.WriteLine(output);
            }
            */
        }
    }

    class Unit_2_3
    {
        public string Greet(string name)
        {
            return $"Good morning, {name}";
        }

        public void LogOddNumbers()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public int Area(int length, int width)
        {
            return length * width;
        }

        public int OtherAngle(int FirstAngle, int SecondAngle)
        {
            int TotalAngle = 180;
            return TotalAngle - FirstAngle - SecondAngle;

        }

        public double DiameterFromArea(int area)
        {
            double pi = Math.PI;
            double squared = Math.Sqrt(area / pi);
            return 2 * squared;
        }

        public dynamic TotalPrice(int price, int percentage)
        {
            double percent = percentage / 100D;
            dynamic tax = price * percent;
            return price + tax;
        }

        public string ShortLongShort(string string1, string string2)
        {
            string output = "";

            int lengthOfString1 = Convert.ToInt32(string1.Length);
            int lengthOfString2 = Convert.ToInt32(string2.Length);

            if (lengthOfString1 > lengthOfString2)
            {
                output += string2;
                output += string1;
                output += string2;
            }
            else
            {
                output += string1;
                output += string2;
                output += string1;
            }
            return output;
        }

        public string DescribeAge(int age)
        {
            if (age <= 12) return "You're a kid";
            if (13 <= age && age <= 17) return "You're a teenager";
            if (18 <= age && age <= 64) return "You're an adult";

            return "You're an elderly";
        }

        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else if ((year % 4 == 0 && year % 100 == 0) && year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Mulisum(int number)
        {
            int output = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    output += i;
                }
            }
            return output;
        }

        public int AsciiValue(string sentence)
        {
            int output = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                char letter = sentence[i];
                // Internally, C# converts the character value to an ASCII value. 
                int ascii = letter;
                output += ascii;
            }

            return output;
        }

        public string Stringy(int number)
        {
            string output = "";

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    output += "1";
                }
                else
                {
                    output += "0";
                }
            }

            return output;
        }

    }

    class Unit_2_5
    {
        public void Shoutout(dynamic[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        public int Push(dynamic[] array, dynamic value)
        {
            
        }

        /*
                        public dynamic Pop(dynamic[] array)
                        {
                            // Needs to be implemented
                        }

                        public dynamic ReverseArray(dynamic[] array)
                        {
                            // Needs to be implemented
                        }

                        public dynamic IndexOf(dynamic[] array, dynamic value)
                        {
                            // Needs to be implemented
                        }

                        public dynamic Join(dynamic[] array, dynamic separator)
                        {
                            // Needs to be implemented
                        }

                        public dynamic Unshift(dynamic[] array, dynamic value)
                        {
                            // Needs to be implemented
                        }

                        public dynamic Shift(dynamic[] array)
                        {
                            // Needs to be implemented
                        }

                        public dynamic LastIndexOf(dynamic[] array, dynamic value)
                        {
                            // Needs to be implemented
                        }

                        public dynamic Slice(dynamic[] array, int startIndex = 0, int endIndex)
                        {
                            // Needs to be implemented
                        }

                        public dynamic Splice(dynamic[] array, int startIndex, int removedValues)
                        {
                            // Needs to be implemented
                        }

                        public dynamic Concat(dynamic[] array1, dynamic[] array2)
                        {
                            // Needs to be implemented
                        }

                        public dynamic ShallowCompare(dynamic[] array1, dynamic[] array2)
                        {
                            // Needs to be implemented
                        }

                        public dynamic DeepCompare(dynamic[] array1, dynamic[] array2)
                        {
                            // Needs to be implemented
                        }
                */


    }
    class Unit_2_6 { }
}