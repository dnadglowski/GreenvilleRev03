using System;

class Program {
  public static void Main (string[] args) {

    while(true){
      Console.WriteLine("************************************");
      Console.WriteLine("*  The stars shine in Greenville.  *");
      Console.WriteLine("************************************");

      Console.WriteLine("Please Enter the following number below from the following menu:");

      Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
      Console.WriteLine("2. Exit");
      int.TryParse(Console.ReadLine(), out int ans);
      if(ans == 2){
        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
         break;
      }
      else if (ans == 1)
      while(true){
        Console.WriteLine("How many contestants in previous year?");
          int.TryParse(Console.ReadLine(), out int prev_year);
          Console.WriteLine("How many this year?");
          int.TryParse(Console.ReadLine(), out int cur_year);
        if (0<= cur_year && cur_year <=30){
          if (cur_year >= prev_year){
            if (cur_year >= prev_year*2){
              Console.Write("The competition is more than twice as big this year!");
              break;
            }
            else
            Console.Write(" The competition is bigger than ever!");
            break;
            }
          else if(cur_year<prev_year)
          Console.Write("A tighter race this year! Come out and cast your vote!");
          break;
        }else if (0> cur_year || cur_year>30){
          Console.WriteLine("Invalid Number");
          continue;
          
        }
      }
    }

        } 

      }