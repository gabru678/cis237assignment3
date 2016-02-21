using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UI
    {
        string input;
        Console.WriteLine("Welcome to the Droid Factory!");

        Console.WriteLine(" \nWe will be able to access all of your droid needs!"+
        "\n Please enter a 1 if you would like to create a new droid"+
        "\n or Please enter a 2 if you would like to print out the current droids");

        while(Console.ReadLine != "1" || Console.ReadLine != "2")
    {
        Console.WriteLine("Sorry that was not a correct input\n Please enter"+
        "1 to add a new droid"+
        "2 to print the current droids");
    }

    input = Console.ReadLine();

    if (input = "1")
        {
            Console.WriteLine("Thanks for adding a new droid! \n "+
            "enter the type of Droid you would like to make");
            
            Droid toAdd = New Droid;
            
            Console.WriteLine("Enter a number for your selection:"+
            "\n 1.For a Protocol Droid"+
            "\n 2. For a Utility Droid");
            
            //Ensure that the user enteres either a 1 or 2 here
            // or hell I could just ensure that they add a 1 and for anything else
            // I would send them to create a Utility droid that they deserve
            if( input = "1")
                {
                    int NumLang;
                    Console.WriteLine("OK! for your Protocol Droid there are some specific things that we need to add");
                    Console.WriteLine("\n We need to add the Number of languages that it could speak");
                    while(Console.ReadLine() ==  int)
                        {
                            Console.ReadLine = NumLang;
                        }
                }
            else
                {
                    Console.WriteLine("Here in Utility we have two choices"+
                    "\n 1. for Astromech"+
                    "\n 2. for Janitor");
                    
                    input = Console.ReadLine();
                    
                    Console.WriteLine("But all Utility Droids");
                    if(input = "1")
                    {
                        Console.WriteLine("The Astromech will need some extra things!"+
                        "\n ")
                    }
                }
        }

        
    }
}
