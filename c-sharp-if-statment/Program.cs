using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        // if statment 
        //Less than: a < b
        //Less than: a < b
        //Less than or equal to: a <= b
        //Greater than: a > b
        //Greater than or equal to: a >= b
        //Equal to a == b
        //Not Equal to: a != b

        int a = 0, b = 1;
            bool c;
        if(a == 0)
        {
            WriteLine("condition met");
        }

        else if(a == 1)
        {
            WriteLine("condition not met");
        }
        else
        {
            WriteLine("na");
        }

        //Multiple condition
        ///  ||>>OR 
        ///  &&>>AND
        int x = 5;
        if(a < 1 && b > 0)
        {
            WriteLine("condition met");

        }
        else if (b > 0 || x < 6)
        {
            WriteLine("condition met");

        }

        else
        { WriteLine("condition not met"); }

        // with user interaction  

        int firstNumber;
        int secondNumber;
        WriteLine("Enet a first Number:  ");
        firstNumber = int.Parse(ReadLine());
        WriteLine("Enet an second Number:  ");
        secondNumber = int.Parse(ReadLine());

        if(firstNumber == secondNumber)
        {
            WriteLine("numbers are equals ");
        }
        else if(firstNumber>0 && secondNumber > 0)
        {
            WriteLine("both numbers are bigger than 0");
        }
        else
        {
            WriteLine("one of the numbers or booth are less than 0");
        }
        //  Nested Loops(loop within loop)
        //*can be any number of loops
        //*no restriction on type of loop

        //  Outer - Loop
        //      {
        //          body of outer-loop
        //            Inner - Loop

        //            {
        //                body of inner-loop
        //            }
        //            ... ... ...
        //      }

        for(int i=0;i<5; i++)
        {
            WriteLine("this is outer loop");
            for (int j = 0; j < 5; j++)
            {
                WriteLine("this is inner loop");
            }
        }

               



    }
}