﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public static class ExtDecimal
    {
        public static string RoundOut(this decimal? dec, int numDec)
        {
            string ceros = "0.";
            Enumerable.Range(1, numDec > 0 ? numDec : 1).ToList().ForEach(x => { ceros += "#"; });
            return Math.Round((decimal)dec, numDec).ToString(ceros);
        }

        public static string RoundOut(this decimal dec, int numDec)
        {
            string ceros = "0.";
            Enumerable.Range(1, numDec > 0 ? numDec : 1).ToList().ForEach(x => { ceros += "#"; });
            return Math.Round(dec, numDec).ToString(ceros);
        }

        public static string RemoveTrailingZeros(this decimal? dec)
        {
            decimal num = (decimal)dec;
            return num.ToString("0.########");
        }

        public static string RemoveTrailingZeros(this decimal dec)
        {
            return dec.ToString("0.########");
        }
    }
}
