using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displaying opening lines
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadLine();

            //Writing the student's name to the dB as a String Variable
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            //Writing the student's current course to the dB as a String Variable
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            //Writing the current course page number to the dB as a Integer Variable
            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(currentPage);

            //Writing reply for help to dB as a Boolean Variable
            Console.WriteLine("Do you neeed help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            bool helpStatus = Convert.ToBoolean(help);

            //Writing positive experiences response to dB as a String Variable
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            //Writing feedback response to dB as a String Variable
            Console.WriteLine("Is there any other you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Writing study hours to dB as a Integer Variable
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyTime = Convert.ToInt32(studyHours);

            //Displaying "Thank you" after all questions are answered
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
