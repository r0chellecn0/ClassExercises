using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnums
{
    class Program
    {//
        enum Month
        {
            Jan, Feb, Mar, Apr, May, Jun,
            Jul, Aug, Sep, Oct, Nov, Dec
        }
        struct Date
        {
            private int year;
            private Month month;
            private int day;
            public Date (int ccyy, Month mm, int dd)
            {
                this.year = ccyy - 1900;
                this.month = mm;
                this.day = dd - 1;
            }
            public override string ToString()
            {
                string data = $"{this.month} {this.day + 1} {this.year + 1900}";
                return data;
            }
            public void AdvanceMonth()
            {
                this.month++;
                if (this.month == Month.Dec +1)
                {
                    this.month = Month.Jan;
                    this.year++;
                }
            }
        }

        static void doWork()
        {
            Month first = Month.Dec;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            Date defaultDate = new Date(2017, Month.Dec, 25);
            Console.WriteLine(defaultDate);

            Date weddingAnniversay = new Date();
            Console.WriteLine(weddingAnniversay);

            Date weddingAnniversaryCopy = weddingAnniversay;
            Console.WriteLine($"value of copy is {weddingAnniversaryCopy}");
            weddingAnniversay.AdvanceMonth();
            Console.WriteLine($"new value of weddingAnniversary is {weddingAnniversay}");
            Console.WriteLine($"value of copy is still {weddingAnniversaryCopy}");
        }
        static void Main(string[] args)
        {
            doWork();
        }
    }
}
