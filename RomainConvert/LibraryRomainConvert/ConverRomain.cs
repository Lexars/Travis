using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRomainConvert
{
    public class ConverRomain : IConverter
    {
        int[] tabInt = new int[] {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string[] tabNum = new string[] {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};

        IParser parser = new Parser();

        public String Convert(String s)
        {
            var number = parser.ParseString(s);

            if ( number == 0)
            {
                return "N";
            }

            StringBuilder result = new StringBuilder();
            for(int i = 0; i < 13; i++)
            {
                while ( number >= tabInt[i])
                {
                    number -= tabInt[i];
                    result.Append(tabNum[i]);
                }
                
            }
            return result.ToString();
        }

    }
}
