using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArray_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Classroom netClass = new Classroom();

            Console.WriteLine("Welcomw to our .NET Class. ");
            

            string doItAgain="";
            int studentList=0;
            do
            {
                Student currentStudent=null;

                    do
                    {
                        Console.WriteLine(" Which Student Would you like to learn about? (Enter a number 1-8):");

                        try
                        {
                            studentList = int.Parse(Console.ReadLine());
                            currentStudent = netClass.studentNETC[studentList];
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    } while (currentStudent == null);
              

                Console.WriteLine($"Student {studentList} is {currentStudent.name}");
                Console.WriteLine($"What would you like to know more about {currentStudent.name}?\n(Enter \"Home Town\" or \"Favorite Food\")");
                string moreAboutStud = Console.ReadLine();
                if (moreAboutStud == "hometown")
                {
                    Console.WriteLine($"{currentStudent.name} is from {currentStudent.homeTown} .");
                }
                else if (moreAboutStud == "favoritefood")
                {
                    Console.WriteLine($"{currentStudent.name} favorite food is {currentStudent.favouriteFood} .");
                }
                else
                {
                    Console.WriteLine("That data does not exist");
                }

                Console.WriteLine("Would you like to know more?(enter \"yes\" or \"no\")");
                doItAgain = Console.ReadLine();
           
           // }
            } while (doItAgain == "yes");

            
        }
    }
}
