using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class PartTimeCourse : Course
    {
        private int timings;

        public PartTimeCourse(string name, int duration, int courseFee,int timings)
            :base(name, duration, courseFee)
        {
            this.timings = timings;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(timings);
        }

        public override int GetTotalFee()
        {
            int fee = (int)(courseFee * 0.9);
            return fee;
        }
    }
}
