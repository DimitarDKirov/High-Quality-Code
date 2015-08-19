using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhones
    {
    //problem 7
    class GSMTest
        {
        private const int maxNumber = 10; //максимален брой тестови GSM
        static string[,] gsmBase ={ { "Mokia", "1100" }, { "Nokia", "Lumia 930" }, { "LG", "Optimus" }, { "Samsung", "Galaxy 4" }, { "HTC", "Desire" } };     //матрица с примерни телефони
        private GSM[] gsmArray;
        private Random rand;

        //конструктор - създава масив от тестови телефони със случайни данни
        public GSMTest()
            {
            rand = new Random();
            this.gsmArray = new GSM[rand.Next(1, maxNumber)];    //случаен борй тестови телефони
            for (int i = 0; i < gsmArray.Length; i++)
                {
                string name = new string((char)rand.Next(65, 122), rand.Next(1, 30));  //име на собственика - от 1 до 30 повторения на случаен символ 
                Battery battery = new Battery(new string('t', rand.Next(10)), rand.Next(1000), rand.Next(50), (BatteryType)rand.Next(3)); //батерия за тестовия случай - случайни данни
                int row = rand.Next(gsmBase.GetLength(0)); //модел и марка на телефона - случаен ред от матрицата
                gsmArray[i] = new GSM(gsmBase[row, 1], gsmBase[row, 0], (float)rand.NextDouble() * 1000, name, battery, rand.Next(10, 50) / 10.0f);
                }
            }

        public string GSMinfo()
            {
            //връща информация за всички създадени тестови телефони като се използва ToString() на класа GSM
            StringBuilder result = new StringBuilder();
            foreach (GSM gsmPhone in gsmArray)
                result.Append(gsmPhone.ToString());
            result.Append("\n Static iPhone\n");
            return result.ToString();
            }
        }
    }
