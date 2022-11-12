using System;
using UnitTwo;
namespace Program
{
    class Program
    {
        static void Main()
        {
            Unit_2_5 TestAnswer = new Unit_2_5();

            dynamic[] randoArray = {true, "41", "steph"};

            Console.WriteLine(TestAnswer.Push(randoArray, "hello"));

        }

    }
}
