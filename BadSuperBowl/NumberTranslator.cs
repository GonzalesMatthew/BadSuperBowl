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

            //return numberToTranslate switch
            //{
            //    1 => "I",
            //    3 => "III",
            //    4 => "IV",
            //    _ => ""
            //};

            var numeral = "";

            numeral += new string('L', numberToTranslate / 50);
            numberToTranslate %= 50;

            numeral += numberToTranslate == 40 ? "XL" : "";
            numberToTranslate %= 40;

            numeral += new string('X', numberToTranslate / 10);
            numberToTranslate %= 10;

            numeral += numberToTranslate == 9 ? "IX" : "";
            numberToTranslate %= 9;

            numeral += new string('V', numberToTranslate / 5);
            numberToTranslate %= 5;

            numeral += numberToTranslate == 4 ? "IV" : "";
            numberToTranslate %= 4;

            numeral += new string('I', numberToTranslate);

            return numeral;


            //switch (numberToTranslate)
            //{
            //    case 1:
            //        return "I";
            //    case 3:
            //        return "III";
            //    case 4:
            //        return "IV";
            //    case 5:
            //        return "V";
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
