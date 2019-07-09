/**********************************************

Area class

***********************************************/

// Notes:
  // Methods in abstract classes
  // have to be overriden in sub classes,
  // they can only be implemented in the base class.

  // The following program uses
  // inheritance, encapsulation, abstraction.

namespace MyProgram {

  // Builds abstract class.
  // It can only be inherited,
  // you cannot create an instance(object) from an abstract class.
  abstract class Area {

    // Builds abstract method.
    // Takes two parameters,
    // arrays width and length
    // in the main class.
    // Abstract methods cannot
    // be implemented they can only be declared.
    public abstract int AreaOfRectangle(int[] width, int[] length);

  }

}
