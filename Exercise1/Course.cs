using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public abstract class Course
    {
        protected string name;
        protected int duration;
        protected int courseFee;

        public Course(string name, int duration, int courseFee)
        {
            this.name = name;
            this.duration = duration;
            this.courseFee = courseFee;
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(duration);
            Console.WriteLine(courseFee);
        }

        public abstract int GetTotalFee();
    }
    
 }

