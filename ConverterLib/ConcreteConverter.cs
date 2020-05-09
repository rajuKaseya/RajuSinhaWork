using System;

namespace ConverterLib
{
    public class ConcreteConverter: IConverter
    {
        public string Convert(int number)
        {
            string result = string.Empty;
            long temp = number; ;
            if (temp > 9999999)
            {
                result = result + Utility.ParseNumber(System.Convert.ToInt32(temp / 10000000)) + " Crore,";
                temp = temp - (temp / 10000000) * 10000000;
            }
            if (temp > 99999)
            {
                result = result + Utility.ParseNumber(System.Convert.ToInt32(temp / 100000)) + " Lac,";
                temp = temp - (temp / 100000) * 100000;
            }
            if (temp > 999)
            {
                result = result + Utility.ParseNumber(System.Convert.ToInt32(temp / 1000)) + " Thousand,";
                temp = temp - (temp / 1000) * 1000;
            }
            if (temp > 99)
            {
                result = result + Utility.ParseNumber(System.Convert.ToInt32(temp / 100)) + " Hundred,";
                temp = temp - (temp / 100) * 100;
            }
            if (temp > 0)
            {
                if (result.Length > 0 && result[result.Length - 1] == ',')
                {
                    result = result.Remove(result.Length - 1);
                }
                result = result + " And " + Utility.ParseNumber(System.Convert.ToInt32(temp));

            }
            if (result.Length > 0 && result.StartsWith(" And"))
            {
                result = result.Remove(0, 4);
            }
            if (result.Length > 0 && result.EndsWith(","))
            {
                result = result.Remove(result.Length - 1);
            }
            return result;
        }
    }
}
