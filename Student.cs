

namespace cSharp_OOPBasics
{
    class Student
    {

        public string name;
        public long Id;
        public string grade;
        public string registerationnumber;

        public Student(string name, int Id, string registerationnumber) // Constructor its has to be same name as class name
        {
            this.name = name;
            this.Id = Id;   
            this.registerationnumber = registerationnumber;
        }

        public void status()
        {
            Console.WriteLine("Student " + name + " is studing.....");

        }

        public void studentDetails()
        {
            Console.WriteLine("Student Name: "+ this.name + ", Registeration Number: "+ this.registerationnumber);
        }

    }
}
