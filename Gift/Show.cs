using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public static class Show
    {
        public static void ShowItems(this IGift gift)
        {
            Console.WriteLine("Список конфет: ");

            var count = 0;//Подсчет количества элементов подарка
                          // Set a variable to the My Documents path.
            string mydocpath =
                     Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "dataListGift.txt".
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\dataListGift.txt"))
            {
                foreach (var i in gift.items)
                {
                    Console.WriteLine("\n" + "Название конфеты: {0};\n" + "Вес в граммах: {1};\n" + "Калории: {2}" +
                                "\n", i._name, i._weight, i._calories);
                    string stringWeight = Convert.ToString(i._weight);
                    string stringCalories = Convert.ToString(i._calories);

                    count++;
                    string stringCount = Convert.ToString(count);

                    String[] stringListArray = {stringCount + " Название: " + i._name + "; Вес в граммах: " +
                        stringWeight + "; Калории: " + stringCalories + ";\n" };

                    foreach (string list in stringListArray)
                    {
                        outputFile.WriteLine(list.ToString());
                    }
                }
            }
            Console.WriteLine("Всего в подарке: {0} сладостей.", count);
        }
    }
}
