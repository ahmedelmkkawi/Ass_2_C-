using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ass_2_C_


{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-	Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter a number ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The num is " + num);

            #endregion

            #region 2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string name = ("Ahmed");
            //int num = Convert.ToInt32(name);

            //It will not be excuted and will give run time error because
            //we are trying to convert  non-numeric characters to intger data type

            #endregion

            #region 3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float num1 = 5.5f;
            //float num2 = 2.2f;
            //float result = num1 + num2;
            //Console.WriteLine(result);
            // It will be excuted and give output: 7.7

            #endregion

            #region 4-	Write C# program that Extract a substring from a given string.
            // string name = "Ahmed";
            // string output = name.Substring(2, 3);
            // Console.WriteLine(output);
            #endregion

            #region 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int num1 = 5;
            //int num2 = num1;
            //num1 = 10;
            //Console.WriteLine(num1); // 10
            //Console.WriteLine(num2); // 5
            #endregion

            #region 6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            #endregion

            #region 7-	Write C# program that take two string variables and print them as one variable
            //string Fname = "Ahmed";
            //string Lname = "Mofreh";
            //Console.WriteLine($"{Fname} {Lname}");
            //Console.WriteLine(Fname + " " + Lname);
            #endregion

            #region 8-	Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            //b)	A value 1 will be assigned to d.

            #endregion

            #region 9-	Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //d)	6 1
            #endregion

            #region -What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0)) //if (num <= 0) true it will be false
              //  Console.WriteLine(++num + z++ + " " + ++z); //(2 +5) then 'z' will be 7
            //else
              //  Console.WriteLine(--num + z-- + " " + --z); // (0+ 5) + 3

            //d)	7 7


            #endregion



        }
    }
}
