﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Interface_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);

            }

     //       List<Order> SortedList = objListOrder.OrderBy(o => o.OrderDate).ToList();
        }
    }

    class Hund : IComparable<Hund>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo([AllowNull] Hund h)
        {
            if (h.Alder > this.Alder)
                return -1;
            if (h.Alder < this.Alder)
                return 1;
            return 0;
        }
    }
}
