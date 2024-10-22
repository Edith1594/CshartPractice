
using System;
class Program {
  static void Main() 
  {
      int[] ListNum = {10, 30, 50, 70, 90};
      int Sum = 0;
      
      foreach (int i in ListNum) {
          Sum = Sum + i;
      }
      Console.WriteLine("the sum of all elements is equal "+ Sum);
  }
}