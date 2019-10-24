using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
   
    class Student
    {
        private int rollNo;
        private string name;
        private string course;
        private int feePaid;
        private static float serviceTax = 0.123f;

       

        //constructor to take rollno,name,course
        public Student(int rollNo, string name, string course)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.course = course;

        }

        //method for payment
        public void Payment (int amount)
        {
            feePaid = feePaid + amount;
           
        }
        //print details about the student
        public void Print()
        {
            Console.WriteLine("Student named "+ 
                name+" with rollno "+
                rollNo+" attending "+
                course+" has paid "+
                feePaid+" this far.");
            
        }

        public int DueAmount
        {
            get
            {
                return TotalFee - feePaid;
            }
        }

        public int TotalFee
        {
            get
            {
                if(course == "c#")
                {
                    return (int)(2000+2000*serviceTax);
                }else
                {
                    return (int)(3000+3000*serviceTax);
                }
            }
        }

        public static float ServiceTax
        {
            get
            {
                return serviceTax;
            }
            set
            {
                serviceTax = value;
            }
        }
        
  }
}
