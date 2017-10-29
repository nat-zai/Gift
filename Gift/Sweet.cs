using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public abstract class Sweet
    {
        public string _name { get; private set; }
        public int _weight { get; private set; }
        public decimal _calories { get; private set; }

        public Sweet(string sweetName, int sweetWeight,
            decimal sweetCalories)
        {
            this._name = sweetName;
            this._weight = sweetWeight;
            this._calories = sweetCalories;
        }

        public abstract void TypeOfSweet();
    }
}
