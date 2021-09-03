using System;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employee = new Employee();

            Person student = new Student();

            employee.Say();

            student.Say();

            Console.ReadKey();
        }
    }

    abstract class Person

    {
        protected string _name;

        protected DateTime _birthDate;

        public virtual void Say()

        {
 
            Console.WriteLine("Person is saying....");

        }

        public abstract void Work();

    }

    class Employee : Person

    {

        private float _salary;

        public override void Say()

        {

            Console.WriteLine("Employee is saying....");

        }

        public override void Work()

        {

            Console.WriteLine("Employee is work....");

        }

    }

    class Student : Person

    {

        private float _mark;



        public override void Work()

        {

            Console.WriteLine("Student is work....");

        }

    }
}
