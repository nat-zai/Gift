using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    class Gift : IGift
    {
        private ICollection<Sweet> items;

        public Gift()
        {
            //Инициализирует новый экземпляр класса, который
            //является пустым и имеет начальную емкость по умолчанию
            items = new List<Sweet>();
        }

        public IEnumerable<Sweet> Items { get => this.items; }

        //добавление элемента в коллекцию
        void IGift.Add(Sweet sweet)
        {
            items.Add(sweet);
        }

        //сумма калорий
        decimal IGift.GiftCalories()
        {
            return items.Sum(x => x._calories);
        }

        //вес подарка
        int IGift.GiftWeight()
        {
            return items.Sum(x => x._weight);
        }

        void IGift.Sort()
        {
            var temp = items.OrderBy(x => x._weight).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        IEnumerable<Sweet> IGift.FindCandyByCalories(int min,
            int max)
        {
            return items.Where(x => (x._calories >= min) && (x._calories <= max)).ToList();
        }

        IEnumerable<Sweet> IGift.items
        {
            get { return this.items; }
        }
    }
}
