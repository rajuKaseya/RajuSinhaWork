using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLib
{
   public class Factory
    {
        public static IConverter GetConverter()
        {
            return new ConcreteConverter();
        }
    }
}
