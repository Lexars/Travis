﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRomainConvert
{
    class Parser : IParser
    {

        public int ParseString(string s)
        {

            int number;

            try
            {
                number = int.Parse(s);
            }
            catch
            {
                throw new ArgumentException("Valus must be a number in the range 0 - 3,999 and not a string ");
               
            }

            if ( number < 0 || number > 3999)
                throw new ArgumentException("Valus must be int the range 0-3,999");

            return number;
        }
    }
}
