using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAY_OF_WEEK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay());
        }
        static string GetDay (int DayNum){
            string DayName;
             
switch (DayNum)
{
    
    case 0:
    DayName = "SUNDAY";
    break;
    case 1:
    DayName = "MONDAY";
    break;
    case 2:
    DayName = "TUESDAY";
    break;
    case 3:
    DayName = "WEDNESDAY";
    break;
    case 4:
    DayName = "THURSDAY";
    break;
    case 5:
    DayName = "FRIDAY";
    break;
    case 6:
    DayName = "SATURDAY";
    break;
    default:
DayName = "Invalid Day Number";
break;


}
             return DayName;

        }

    }
}
