/* 
 * Creator: Shawn Tyson
 * Class: IGME 201.01
 * Instructor: Nick
 * Due date: October 13, 2024 
 */
namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            string studentName = "Shawn";
            int average = 0;
            int[] grades = [100, 92, 87, 200, -20, 52, 82, 75, 67, 88];

            Console.WriteLine("Welcome to class " + studentName);
            Console.WriteLine("\nHere are your grades: ");

            //Loop Trhough Grade Array
            for (int i = 0; i < grades.Length; i++)
            {
                if (90 <= grades[i] && grades[i] <= 100)
                {
                    Console.WriteLine("This grade is an A!");
                    //Nested Statement
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WoAh! A Perfect Score");
                    }
                }
                else if (80 <= grades[i] && grades[i] <= 89)
                {
                    Console.WriteLine("This grade is a B.");
                }
                else if (70 <= grades[i] && grades[i] <= 79)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (65 <= grades[i] && grades[i] <= 69)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (0 <= grades[i] && grades[i] <= 64)
                {
                    Console.WriteLine("This grade is an F... :(");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade!?");
                }
                average += grades[i]; //Storing the sum of values in average 

                //Loop Ends Here
            }

            //Dividing the length of the grades array by the sum of its values
            //then displaying the grade average.
            average = average / grades.Length;
            Console.WriteLine("\nYour grade average is: " + average);
            Console.WriteLine("We have displayed all grades for " + studentName);
        }
    }
}
