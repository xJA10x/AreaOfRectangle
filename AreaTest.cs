/*************************************

AreaTest class

**************************************/

using System;

namespace MyProgram {

  class AreaTest {

    public static void Main(String[] args) {

      // Outputs empty line.
      Console.WriteLine("");
      // Outputs empty line.
      Console.WriteLine("##################### Running Program ###################");
      // Outputs empty line.
      Console.WriteLine("");

      // Builds object from
      // the AreaTwo class.
      // Constructor no parameters.
      AreaTwo aObj = new AreaTwo();

      // Declares variables.
      int x;
      int y;
      // Declares variable to store method call.
      int theArea;
      // Declares loop control variable.
      int control;
      // Initializes arrays.
      int[] width = {0};
      int[] length = {0};

      // Promtps user.
      Console.Write("Enter -1 to quit program: ");
      // Stores input in the variable control.
      control = Convert.ToInt32(Console.ReadLine());
      // Outputs empty line.
      Console.WriteLine("");

      // Builds sentinel while loop.
      while(control != -1) {

        // Prompts user.
        Console.Write("Enter width of rectangle: ");
        // Stores input in the array width.
        width[0] = Convert.ToInt32(Console.ReadLine());
        // Outputs empty line.
        Console.WriteLine("");

        // Prompts user.
        Console.Write("Enter length of rectangle: ");
        // Stores input in the array length.
        length[0] = Convert.ToInt32(Console.ReadLine());
        // Outputs empty line.
        Console.WriteLine("");

        // Prompts user.
        Console.Write("Enter integer: ");
        // Stores input in the variable x.
        x = Convert.ToInt32(Console.ReadLine());
        // Outputs empty line.
        Console.WriteLine("");

        // Builds sentinel while loop.
        while(x == 0) {

          // Prompts user.
          Console.Write("Please enter an integer greater than 0: ");
          // Stores input in the variablex.
          x = Convert.ToInt32(Console.ReadLine());
          // Outptus empty line.
          Console.WriteLine("");

        }

        // Prompts user.
        Console.Write("Enter second integer: ");
        // Stores input in the variable y.
        y = Convert.ToInt32(Console.ReadLine());
        // Outputs empty line.
        Console.WriteLine("");

        while(y == 0) {

          // Prompts user.
          Console.Write("Please enter an integer greater than 0: ");
          // Stores input in the variable y.
          y = Convert.ToInt32(Console.ReadLine());
          // Outputs empty line.
          Console.WriteLine("");

        }

        // Method call
        // using object name.
        // Takes two parameters,
        // stores output in the variable theArea.
        theArea = aObj.AreaOfRectangle(width, length);

        // Method call
        // using object name.
        // Takes two parameters.
        aObj.SetIntegers(x, y);

        // Outputs to the console
        // Method call
        // using object name.
        // Outputs to the console.
        Console.WriteLine("The division between " + x + " and " + y + " is " + aObj.GetIntegers());
        // Outputs to the console.
        Console.WriteLine("Rectangle with a width of " + width[0] + " and a length of " + length[0] + " has an area of " + theArea + " feet");

        // Promtps user.
        Console.Write("Enter -1 to quit program: ");
        // Stores input in the variable control.
        control = Convert.ToInt32(Console.ReadLine());
        // Outputs empty line.
        Console.WriteLine("");

        // Builds if statement.
        if(control == -1) {

          // Outputs to the console.
          Console.WriteLine("Thanks for using the program.");

        } else {

          // Outputs to the console.
          Console.WriteLine("Ok, let's do this again");

        }

      }

      // Outputs empty line.
      Console.WriteLine("");
      // Outputs to the console.
      Console.WriteLine("#################### Exiting Program ######################");
      // Outputs empty line.
      Console.WriteLine("");

      // Allows user
      // to press any key to exit program.
      Console.ReadKey();

    }

  }

}
