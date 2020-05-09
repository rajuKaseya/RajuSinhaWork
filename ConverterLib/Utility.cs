using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLib
{
   internal class Utility
    {

        private static string GetWordFromNumber(int number)
        {
            switch (number)
            {
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                case 10:
                    return "Ten";
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Nineteen";
                case 20:
                    return "Twenty";
                case 30:
                    return "Thirty";
                case 40:
                    return "Fourty";
                case 50:
                    return "Fifty";
                case 60:
                    return "Sixty";
                case 70:
                    return "Seventy";
                case 80:
                    return "Eighty";
                case 90:
                    return "Ninty";
                default:
                    return "";
            }
        }

        internal static string ParseNumber(int number)
        {
            if (number < 21 || number == 20 || number == 30 || number == 40 || number == 50 || number == 60 || number == 70 || number == 80 || number == 90)
            {
                return GetWordFromNumber(number);
            }
            else
            {
                string temp;
                int remainder = number / 10;

                temp = GetWordFromNumber(remainder * 10);
                int module = number % 10;

                temp = temp + " " + GetWordFromNumber(module);
                return temp;
            }
        }
    }
}
