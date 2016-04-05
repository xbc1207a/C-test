﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fizz
    {
        private Queue<int> q = new Queue<int>();

        public int GetOneNumber()
        {
            return this.q.Dequeue();
        }
        public void AddANumber(int number)
        {
            this.q.Enqueue(number);
        }
    }
}
