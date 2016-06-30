using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_atm
{
    class program
        {
        static void Main(string[] args)
        {
            
            bool incorrectPin = true;

            while(incorrectPin)
            {
                Console.WriteLine("please input a pin number");
                string pinHolder = Console.ReadLine();

                if (pinHolder == "1234")
                {
                    Console.WriteLine("Welcome to your account");
                    Console.ReadLine();

                    Console.WriteLine("Please Select an Option");
                        
                           
                    
                }
                else 
                {

                    Console.WriteLine("Please try another pin");
                    Console.ReadLine();
                }
                
                    
            }
           

                  

         }

        }

    }

