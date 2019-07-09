/**************************************

AreaTwo class

***************************************/

using System;

namespace MyProgram {

  // Builds class.
  // Inherits from the Area class
  // in order to have access to variables and methods.
  class AreaTwo : Area {

    // Declares private variables.
    private int x;
    private int y;

    // Builds method.
    // Takes two parameters,
    // private global variables x and y.
    // Set() method.
    public void SetIntegers(int x, int y) {

      // Stores input in the
      // variable x.
      this.x = x;
      // Stores input in the
      // variable y.
      this.y = y;

    }

    // Builds method.
    // Takes no parameters.
    // Get() method.
    public int GetIntegers() {

      // Returns division.
      return x / y;

    }

    // Overrides abstract method.
    // Takes two parameters.
    public override int AreaOfRectangle(int[] width, int[] length) {

      // Returns area of rectangle.
      return width[0] * length[0];

    }

  }

}
