using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julian
{
    public class Program
    {
        // if statement for  julian date
        public static int JulianDate(int month, int day)
        {
            
            int julianDay;

            if (month == 1)
            {
                julianDay = day;
            }
            else if (month == 2)
            {
                julianDay = 31 + day;
            }
            else if (month == 3)
            {
                julianDay = 59 + day;
            }
            else if (month == 4)
            {
                julianDay = 90 + day;
            }
            else if (month == 5)
            {
                julianDay = 120 + day;
            }
            else if (month == 6)
            {
                julianDay = 151 + day;
            }
            else if (month == 7)
            {
                julianDay = 181 + day;
            }
            else if (month == 8)
            {
                julianDay = 212 + day;
            }
            else if (month == 9)
            {
                julianDay = 243 + day;

            }
            else if (month == 10)
            {
                julianDay = 273 + day;

            }
            else if (month == 11)
            {
                julianDay = 304 + day;

            }
            else julianDay = 334 + day;
            return julianDay;
        }

        // switch case for julian date
        public static int CaseJulian(int m, int day)
        {


            int julianDate;
            int jan = 31, feb = jan + 28, march = feb + 30, april = march + 31, may = april + 31; 
            int jun = may + 30, jul = jun + 31, aug = jul + 31, sep = aug + 30;
            int oct = sep + 31, nov = oct + 30;

            julianDate = 0;
            switch (m)
            {
                case (1):
                    {
                        julianDate = day;
                        break;
                    }
                case (2):
                    {
                        julianDate = jan + day;
                        break;
                    }
                case (3):
                    {
                        julianDate = feb + day;
                        break;
                    }
                case (4):
                    {
                        julianDate = march + day;
                        break;
                    }
                case (5):
                    {
                        julianDate = april + day;
                        break;
                    }
                case (6):
                    {
                        julianDate = may+ day;
                        break;
                    }
                case (7):
                    {
                        julianDate = jun + day;
                        break;
                    }
                case (8):
                    {
                        julianDate = jul + day;
                        break;
                    }
                case (9):
                    {
                        julianDate = aug + day;
                        break;
                    }
                case (10):
                    {
                        julianDate = sep + day;
                        break;
                    }
                case (11):
                    {
                        julianDate = oct + day;
                        break;
                    }
                case (12):
                    {
                        julianDate = nov + day;
                        break;
                    }
            }
            return julianDate;
             
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{JulianDate(2, 3)}");
            Console.WriteLine($"{CaseJulian(12, 31)} case") ;

        }
    }
}
