using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortings
{
    internal abstract class Sorting
    {
        protected int iterCount;
        protected string steps;
        protected ArrayProvider arrayProvider;

        public Sorting(ArrayProvider arrayProvider)
        {
            this.arrayProvider = arrayProvider;
        }

        public abstract void Sort(int[] array);
        public abstract string toString(double milliseconds);

        public string GetSteps()
        {
            return steps;
        }
    }
}
