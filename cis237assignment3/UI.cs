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
                    int Langs;
                    Console.WriteLine("OK! for your Protocol Droid there are some specific things that we need to add");
                    Console.WriteLine("\n We need to add the Number of languages that it could speak");
                    while(Console.ReadLine() ==  int)
                        {
                            Console.ReadLine = NumLang;
                            // Add this new information to the toAdd Droid constructor
                            toAdd += toAdd.NumLang(Langs);
                        }
                }
            else
                {
                    Bool choice1;
                    Bool choice2;
                    Bool choice3;
                    Console.WriteLine("Here in Utility we have two choices"+
                    "\n 1. for Astromech"+
                    "\n 2. for Janitor");
                    
                    input = Console.ReadLine();
                    
                    Console.WriteLine("But first all Utility Droids may have a tool box."+
                    "  Would you like your droid to have one?"+
                    "Enter Y for yes\n Enter N for no");
                    string readIn;
                    readIn = Console.ReadLine();
                    if( readIn == "y" || readIn =="Y")
                        {
                            choice1 = true;   
                        }
                    else
                        choice1 = false;
                    
                    Console.WriteLine("Some droide may have a Computer Connection"+
                    "  Would you like your droid to have one?"+
                    "Enter Y for yes\n Enter N for no");
                    readIn = Console.ReadLine();
                    if( readIn == "y" || readIn =="Y")
                        {
                            choice2 = true;   
                        }
                    else
                        choice2 = false;

                    Console.WriteLine("Finally please choose weaterh or not this droid will have an Arm"+
                    "  Would you like your droid to have one?"+
                    "Enter Y for yes\n Enter N for no");
                    readIn = Console.ReadLine();
                    if( readIn == "y" || readIn =="Y")
                        {
                            choice3 = true;   
                        }
                    else
                        choice3 = false;
                    
                    // append the toAdd Droid with these Features
                    toAdd.Toolbox = choice1;
                    toAdd.Compconnect = choice2;
                    toAdd.arm = choice3;

                    if(input = "1")
                    {
                        Console.WriteLine("The Astromech will need some extra things!"+
                        "\n Some may have Fire Extinguishers"+
                        "  Would you like your droid to have one?"+
                         "Enter Y for yes\n Enter N for no");
                           readIn = Console.ReadLine();
                              if( readIn == "y" || readIn =="Y")
                                  {
                                     choice1 = true;   
                                   }
                                else
                               choice1 = false;
                        // append this decision to the toAdd Droid
                        // I feel that we can reuse choice 1 because the results of that
                        // have already been added to the droid, and the new reflection of choice will matter now
                        toAdd.FireExting = choice1;
                        
                        Console.WriteLine("Aditionally it may have other ships to help"+
                        "  Would you like your droid to have some?"+
                        "Enter a number of how many you would like to add below:");
                         readIn = Console.ToInt32(Console.ReadLine());
                         toAdd.numShips = readIn;
                }
        }
        
        else
            //Print Droid
            // Prolly gonnna have another clas do this one

        
    }
}
