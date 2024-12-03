namespace Coding.Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Previously Provided Bugged Code
            //int num1 = 10;
            //int num2 = 20;
            //int num3 = 30;
            //int average = (num1 + num2 + num3) / 3
            //Console.WriteLn("The average is: " + average);

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            float average = ((num1 + num2 + num3) / 3);
            Console.WriteLine("The average is: " + average);
        }
    }
}
