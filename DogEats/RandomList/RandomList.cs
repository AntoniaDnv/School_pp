﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    internal class RandomList : List<string>
    {
        private Random random;
        private List<string> list;

        public RandomList()
        {
            random = new Random();
        }

        public string RandomString() 
        {
            int index = random.Next(0, Count);
            string element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
