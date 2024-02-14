using System;

namespace ArithmeticQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates singles random number generator
            Random random = new Random();

            //random number of questions between 5 - 15
            int totalQuestions = random.Next(5,15);

            //initialize correctAnswers variable to 0
            int correctAnswers = 0;

            Console.WriteLine("Arithmetic Quiz!");

            for (int i = 1; i <= totalQuestions; i++)
            {
                int number1 = random.Next(0, 21);
                int number2 = random.Next(0, 21);
                char[] operators = { '+', '-', '*', '/' };
                char op = operators[random.Next(0, 4)];

                Console.Write($"\nQuestion {i}: What is {number1} {op} {number2}?\nYour Answer: ");
                double userAnswer = double.Parse(Console.ReadLine());

                double correctAnswer = 0;
                switch (op)
                {
                    case '+':
                        correctAnswer = number1 + number2;
                        break;
                    case '-':
                        correctAnswer = number1 - number2;
                        break;
                    case '*':
                        correctAnswer = number1 * number2;
                        break;
                    case '/':
                        correctAnswer = (int)number1 / number2;
                        break;
                }

                //use if-else statement to compare the userAnswer to correctAnswer
                if (userAnswer == correctAnswer)
                {
                    //displays this text if the userAnswer is equal to correctAnswer
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                {
                    //if not equal to correctAnswer, this text is displayed
                    Console.WriteLine($"Incorrect. The correct answer is {correctAnswer}");
                }
            }

            double percentageCorrect = (double)correctAnswers / totalQuestions * 100;
            Console.Write("\nResults:");
            Console.WriteLine($"\nTotal correct answers: {correctAnswers}");
            Console.WriteLine($"Percentage of Correct Answers: {percentageCorrect}%");
        }
    }
}
