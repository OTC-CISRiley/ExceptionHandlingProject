using System;
using static System.Console;

namespace ExceptionHandlingApp
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScores;
            try
            {
                Write("How many scores will you enter? ");
                inValue = ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];
                for (int i = 0; i < countOfScores; i++)
                {
                    Write("Enter score {0}: ", i + 1);
                    inValue = ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];
                }
                averageTestScores = totalScores / countOfScores;
                WriteLine("Average is {0}", averageTestScores);
            }
            catch (FormatException e)
            {
                Error.WriteLine("Problem with one of " +
                            "the operands - Cannot compute average!");
                Error.WriteLine("Exception type: {0} ", e.Message);
            }
            catch (DivideByZeroException e)
            {
                Error.WriteLine("No scores were entered - Cannot compute average!");
                Error.WriteLine("Exception type: {0} ", e.Message);
            }
            catch (ArithmeticException e)
            {
                Error.WriteLine("Error in your arithmetic or casting. ");
                Error.WriteLine("Exception type {0} ", e.Message);
            }
            catch (Exception e)
            {
                Error.WriteLine("Any other problem" +
                    "Cannot compute average!");
                Error.WriteLine("Exception type: {0} ", e.Message);
            }
            finally
            {
                WriteLine("...\n...\n...\n" +
                    "Terminated Normally with no System Exception!!!");
            }
            ReadKey();
        }
    }
}
