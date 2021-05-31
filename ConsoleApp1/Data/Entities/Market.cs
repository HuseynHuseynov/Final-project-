using ConsoleApp1.Data.Common;
using OneOf.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Data.Entities
{
    public class Market
    {
        private static int _count = 0;

        public string Fullname { get; set; }

        public double Pricepersession { get; set; }

        public DateTime Date { get; set; }

        public string Result { get; set; }
    }
}


 