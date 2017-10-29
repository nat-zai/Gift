using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gift.Factory;

namespace Gift
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new CandyCreator();
            creators[1] = new ChocolateCreator();

            IGift gift = new Gift();

            foreach (Creator cr in creators)
            {
                if (cr is CandyCreator)
                {
                    gift.Add(cr.FactoryMethod("Райская пенка", 45, 60, TypeOfCandy.ChocolateCandies));
                    gift.Add(cr.FactoryMethod("Марсианка", 30, 120, TypeOfCandy.ChocolateCandies));
                    gift.Add(cr.FactoryMethod("Барбарис", 50, 5, TypeOfCandy.Lollipop));
                    gift.Add(cr.FactoryMethod("ДЮШЕС", 12, 7, TypeOfCandy.Lollipop));
                }
                if (cr is ChocolateCreator)
                {
                    gift.Add(cr.FactoryMethod("Аленка", 150, 330, TypeOfChocolate.Lactic));
                    gift.Add(cr.FactoryMethod("Генеральский", 250, 150, TypeOfChocolate.Dark));
                    gift.Add(cr.FactoryMethod("Белый", 125, 400, TypeOfChocolate.White));
                    gift.Add(cr.FactoryMethod("СПАРТАК", 115, 200, TypeOfChocolate.Bitter));
                }
            }
            gift.Sort();
            gift.ShowItems();

            SortMinMax(0, 10);

            void SortMinMax(int minSort, int maxSort)
            {
                string mydocpath =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string name = "Sort";
                int i = 0;
                // Write the string array to a new file named "dataListGift.txt".
                using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\dataList" + name + "Gift.txt"))
                {
                    foreach (var items in gift.FindCandyByCalories(minSort, maxSort))
                    {
                        Console.WriteLine("\n Сортировка произведена. \n Минималькое количество калорий: {0}\n"
                            + "Максимальное количество калорий: {1}\n", minSort, maxSort);
                        Console.WriteLine("Название: {0};\n Вес: {1};\n Калорий: {2};\n",
                            items._name, items._weight, items._calories);

                        string _stringMinSort = Convert.ToString(minSort);
                        string _stringMaxSort = Convert.ToString(maxSort);
                        string _stringWeightSort = Convert.ToString(items._weight);
                        string _stringCaloriesSort = Convert.ToString(items._calories);

                        while (i != 1)
                        {
                            String[] strSort = { "Сортировка произведена." + "\r\n" + "Минималькое количество калорий: " +
                            _stringMinSort + ".\r\n" + "Максимальное количество калорий: " + _stringMaxSort +
                            ". \r\n" };
                            foreach (string list in strSort)
                            {
                                outputFile.WriteLine(list.ToString());
                            }
                            i++;
                        }

                        String[] strItemsSort = { "Название: " + items._name + "; Вес: " + _stringWeightSort + "; Калорий: " + _stringCaloriesSort + ";" };
                        foreach (string list in strItemsSort)
                        {
                            outputFile.WriteLine(list.ToString());
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
                Console.WriteLine("Калорий итого: {0}", gift.GiftCalories());

                string _stringGiftWeight = Convert.ToString(gift.GiftWeight());
                string _stringGiftCalories = Convert.ToString(gift.GiftCalories());

                String[] strGift = { "Вес подарка: " + _stringGiftWeight + "\r\n" + "Калорий итого: " + _stringGiftCalories };

                WriteToFile(strGift, "TotalGift");

                Console.ReadKey();
            }
        }
        public static void WriteToFile(String[] str, string name)
        {
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "dataListGift.txt".
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\dataList" + name + "Gift.txt"))
            {
                foreach (string list in str)
                {
                    outputFile.WriteLine(list.ToString());
                }
            }
        }
    }
}
