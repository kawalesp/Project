using System;

namespace Count
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum = 0;
     
      Console.Write("Enter a number : ");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your no is: " + n);

      while (n>0 ||sum > 9)
      {
        if (n == 0 )
        {
          n = sum;
          sum = 0;
        }
        sum += n % 10;

        n /= 10;
        
       
      }
      Console.Write(sum);
    }
  }

}
