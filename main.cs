using System;

class InchesToCentimeters {
  public static void Main (string[] args) {
    const double CENTIMETERS_PER_INCH = 2.54;
    double z = 5;
    double y = 50;
    double x = -15;
    double w = 15994;

    Console.WriteLine("{0} inches is {1} centimeters",z, z * CENTIMETERS_PER_INCH);
    Console.WriteLine("{0} inches is {1} centimeters",y, y * CENTIMETERS_PER_INCH);
    Console.WriteLine("{0} inches is {1} centimeters",x, x * CENTIMETERS_PER_INCH);
    Console.WriteLine("{0} inches is {1} centimeters",w, w * CENTIMETERS_PER_INCH);
  }
}