using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSuperbowlNamer
{
    public class NumberTranslator
    {
        public string Translate(int numberToTranslate)
        {

            return numberToTranslate switch
            {
                1 => "I",
                3 => "III",
                4 => "IV",
                _ => ""
            };

            //switch (numberToTranslate)
            //{
            //    case 1:
            //        return "I";
            //    case 3:
            //        return "III";
            //    case 4:
            //        return "IV";
            //    default:
            //        return "";
            //}

            //if (numberToTranslate == 1)
            //    return "I";
            //if (numberToTranslate == 3)
            //    return "III";
            //if (numberToTranslate == 4)
            //    return "IV";

            //return "";
        }

    }
}
