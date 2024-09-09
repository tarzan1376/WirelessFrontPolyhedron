using System;

class InchesToCentimeters {
  public static void Main (string[] args) {
    const double CENTIMETERS_PER_INCH = 2.54;
    int z = 5;
    int y = 50;
    int x = -15;
    int w = 15994;

    Console.WriteLine("{0} inches is {1} centimeters",z, z * CENTIMETERS_PER_INCH);
    Console.WriteLine("{0} inches is {1} centimeters",y, y * CENTIMETERS_PER_INCH);
    Console.WriteLine("{0} inches is {1} centimeters",x, x * CENTIMETERS_PER_INCH);
    Console.WriteLine("{0} inches is {1} centimeters",w, w * CENTIMETERS_PER_INCH);
  }
}