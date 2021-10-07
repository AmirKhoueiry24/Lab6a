using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
  
Console.WriteLine ("Celsius into fahrenheit arrays");

    Console.WriteLine("Enter number of days ");
    int days = Convert.ToInt32(Console.ReadLine());

    //get nbr of employees = 5
    //get employee salary as input
    //get bonus percent as input
    //calculate Bonus

    //int[] salary = new int[5];

    int[] celsius = new int[days];
    double[] fahrenheit = new double[days];    
  //Method 1 for iterating through an array
    for(int tem=0; tem < celsius.Length; tem++)
    {
        Console.WriteLine("Enter temperture in celsius");
        celsius[tem]=Convert.ToInt32(Console.ReadLine());

        fahrenheit[tem]=celsius[tem] * 1.8 + 32;
        //F = (C * 9/5) + 32
    }

    //Method 2 for iterating through an array   
    foreach (int item in celsius) 
    {
      Console.WriteLine("Temperture in Celsius is " + item);
    }


    foreach (int itemB in fahrenheit) 
    {
      Console.WriteLine("Temperture in Fahrenheit is " + itemB);
    }
    {
      double Sum = fahrenheit.Sum();
      Console.WriteLine("The sum for the temperture in fahrenheit is " + Sum/days);

    }

  
  }

    
    


    


}