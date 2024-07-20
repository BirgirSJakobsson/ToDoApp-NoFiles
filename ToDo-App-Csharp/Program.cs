// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ToDoList
{
    public class Program
    {
        //FUNCTIONS

        // -------END OF FUNCTIONS--------
        static void Main( string[] args )
        {
            Console.WriteLine( "Welcome to the ToDo-App" );
            //Creates empty tasks list
            List<String> taskList = new List<String>();
            string? option = "";
            int toDelete;

            while (option != "e")
            {
                // How to clear the console properly.
                Console.WriteLine( "Please select an option!" );
                Console.WriteLine( "1 - Add an item to the list." );
                Console.WriteLine( "2 - Remove an item from the list." );
                Console.WriteLine( "3 - List the items in the list." );

                Console.WriteLine("========");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine( "Please enter a name for the task : " );
                    string? task = Console.ReadLine();
                    if (String.IsNullOrEmpty(task))
                    { Console.WriteLine( "Name can not be empty" ); }
                    else
                    {
                        taskList.Add( task );
                        Console.WriteLine( "Task added to the list." );
                    }
                }
                else if (option == "2")
                {
                    if (taskList.Count > 0)
                    {
                        Console.WriteLine( "Please select the tast to be removed from the list: " );
                        for (int i = 0 ; i < taskList.Count ; i++)
                        {
                            Console.WriteLine( i + " : " + taskList[i] );
                        }
                        string? input = Console.ReadLine();
                        try
                        {
                            toDelete = Convert.ToInt32(input);
                            if (taskList.Count > toDelete && toDelete != null && toDelete >=0)
                            {
                                taskList.RemoveAt( toDelete );
                            }
                            else
                            {
                                Console.WriteLine( "Selected task does not exist, try again." );
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not an integer!", input);
                        }
                        
                    }
                    else
                    { Console.WriteLine("List is currently empty");
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine( "The list currently contains the following tasks : " );
                    for (int i = 0 ; i < taskList.Count ; i++)
                    {
                        Console.WriteLine( i + " : " + taskList[i] );
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine( "Thank you for using the application!" );
                    Console.Clear();
                }
                else
                { 
                    Console.WriteLine("Please enter a valid input"); 
                }
                //Creates a partition for easier reading.
                Console.WriteLine( "=====" );
            }
        }
    }
}
