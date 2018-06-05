﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling
{

    public class Accumul
    {
        public static String Accum( string input )
        {
            string output = string.Empty;

            for( int i = 0; i < input.Length; i++ )
            {
                output += ( i > 0 ) ? "-" : string.Empty;

                output += Char.ToUpper( input[ i ] ) + new string( Char.ToLower( input[ i ] ) , i );
            }

            return output;
        }
    }
}
