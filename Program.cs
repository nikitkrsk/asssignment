using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Program:Person
    {
        static void Main(string[] args)
        {

            Person p = CreatingAPerson();

            string Fullname = p.ToString();
            Console.WriteLine(new string('*', 30));

            Console.WriteLine("Please Enter student's student number");
            string StudentNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(StudentNumber))
            {
                Console.WriteLine("please, put number");
                StudentNumber = "Error";
            }
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Please Enter the student's age");
            int age = settingAge();
            Console.WriteLine(new string('*', 30));
            Address addres = SettiingAnAddress();
            string FullAddress = addres.ToString();
            Console.WriteLine(new string('*', 30));
            List<int> marks = PuttingMarks();
            double average = marks.Average();
            Console.WriteLine(new string('*', 30));
            bool lookingforinformation = true;
            while (lookingforinformation)
            {

                Console.WriteLine("What information you want to know about student?");
                Console.WriteLine("student's average score - 1");
                Console.WriteLine("student's city - 2");
                Console.WriteLine("student's full Address - 3");
                Console.WriteLine("student's full information - 4");
                Console.WriteLine("exit - 5");

                try
                {
                    int choose = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choose)
                    {


                        case 1:
                            {
                                Console.WriteLine("Student {0} score is {1})", Fullname, average);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Student {0} is living in {1})", Fullname, addres.CitY);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Student {0} Address is {1})", Fullname, FullAddress);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Student {0})", Fullname);
                                Console.WriteLine("His age is {0}", age);
                                Console.WriteLine("His Student's number is {0}", StudentNumber);
                                Console.WriteLine("Address is {0}",FullAddress);
                                Console.WriteLine("Average score is is {0}", average);
                                break;
                            }
                        case 5:
                            {
                                lookingforinformation = false;
                                break;
                            }
                        default:
                            {
                                System.Console.WriteLine("incorrect number");
                                break;
                            }

                    }
                }
               catch
                {}
                Console.WriteLine("For new search press ENTER.....");
                Console.ReadKey();
                Console.Clear();
                                             
            }
            
            
        }

        
        private static int settingAge()
        {
            int age = 0;
            if (int.TryParse(Console.ReadLine(), out age))
            {

                if (age >= 100 || age <= 0)
                {
                    Console.WriteLine("incorrect age, it will count as 0");
                    age = 0;
                }

            }
            else
            {
                Console.WriteLine("Please, put numbers");
            }
            return age;
        }//HELPS TO SET AN AGE

        private static Person CreatingAPerson()// ENTER NAME AND SURNAME
        {
            Person p = new Person();
            Console.WriteLine("Please Enter the student first name");
            p.NAme = Console.ReadLine();

            Console.WriteLine("Please Enter the student second name: ");
            p.SecondNamE = Console.ReadLine();
            return p;
        }

        private static Address SettiingAnAddress()
        {
            Address addres = new Address();
            Console.WriteLine("Please Enter the student's address");
            addres.ADDREESS = Console.ReadLine();
            Console.WriteLine("Please Enter the student's street");
            addres.STREET = Console.ReadLine();
            Console.WriteLine("Please Enter the student's city");
            addres.CitY = Console.ReadLine();
            Console.WriteLine("Please Enter the student's country");
            addres.CountrY = Console.ReadLine();
            return addres;
        }// HELPS TO WRITE AN ADDRESS

        private static List<int> PuttingMarks()
        {
            List<int> marks = new List<int>();
            Console.WriteLine("Put the math score: 1-6");
            marks.Add(counting());
            Console.WriteLine("Put the biology score: 1- 6");
            marks.Add(counting());
            Console.WriteLine("Put the chemistry score: 1-6");
            marks.Add(counting());
            Console.WriteLine("Put the physics score: 1-6");
            marks.Add(counting());
            Console.WriteLine("Put the IT score: 1-6");
            marks.Add(counting());
            return marks;
        }// LIST OF MARKS

        private static int counting()
        {
            int mark = 0;

            if (int.TryParse(Console.ReadLine(), out mark))
            {
                
                if (mark >= 7 || mark <= 0)
                {
                    Console.WriteLine("incorrect mark, it will count as 0");
                    mark = 0;
                }
                return mark;
            }
            else
            {
                Console.WriteLine("Please, put numbers");
            }
            
            return mark;
        }// HELPER FOR MARKS
    }
}
