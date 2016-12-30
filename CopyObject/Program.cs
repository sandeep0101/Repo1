using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopyObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1.IdInfo = new IdInfo(6565);


            Person p4;
            p4 = p1;
            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();


            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();

            Console.ReadLine();

        }


        
    }


    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }
    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public void displaydata()
        {

            Console.WriteLine("Hello sandy");
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = String.Copy(Name);
            return other;
        }
    }


  

}
