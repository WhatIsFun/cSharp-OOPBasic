namespace cSharp_OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Mohammed", 1, "IC-240");
            Student std2 = new Student("John", 3, "IC-321");
            //std1.name = "Mohammed";
            //std1.Id = 1;
            //std1.grade = "A";

            //std2.name = "Umran";
            //std2.Id = 2;
            //std2.grade = "A+";

            Console.WriteLine("std1 details: ");
            Console.WriteLine("Student Name: " + std1.name);
            Console.WriteLine("Student ID: " + std1.Id);
            Console.WriteLine("Student Grade: " + std1.grade);
            std1.status();

            Console.WriteLine("*************");
            Console.WriteLine("std2 details: ");
            Console.WriteLine("Student Name: " + std2.name);
            Console.WriteLine("Student ID: " + std2.Id);
            Console.WriteLine("Student Grade: " + std2.grade);
            std2.status();


            std1.studentDetails();


            Teacher tch1 = new Teacher();

            tch1.name = "Mohand";
            tch1.Id = 13;
            tch1.module = "Math";
            Console.WriteLine("*************");
            Console.WriteLine("tch details: ");
            Console.WriteLine("Teacher Name: " + tch1.name);
            Console.WriteLine("Teacher ID: " + tch1.Id);
            Console.WriteLine("Teacher Module: " + tch1.module);
            tch1.teaching();





        }
    }
}