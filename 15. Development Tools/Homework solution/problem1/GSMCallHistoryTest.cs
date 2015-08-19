using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhones
    {
    //problem 12
    class GSMCallHistoryTest
        {
        private const int MinCalls = 5;     //най-малък брой тестови разговори
        private const int MaxCalls = 50;      //най-голям брой тестови разговори
        private const float priceMinute = 0.37f;    //цена на минута
        private const string testManuf = "NOKIA";   //марка и модел на тестовия GSM
        private const string testModel = "Lumia 630";
        private GSM testPhone;      //тестов GSM
        Random rand;

        //конструктор - създава тестовия телефон
        public GSMCallHistoryTest()
            {
            testPhone = new GSM(testModel, testManuf);
            rand = new Random();
            }
        //тестващ метод - създава случаен брoй разговори между min и max и ги добавя към тестовия GSM
        public void TestCallHistory()
            {
            for (int i = 0; i < rand.Next(MinCalls, MaxCalls); i++)
                {//случайно време на разговора - добавя се случаен брой дни, часове, минути, секунди към днешна дата
                TimeSpan timeOffset = new TimeSpan(rand.Next(100), rand.Next(23), rand.Next(59));
                int randomNum = rand.Next(11111111, 99999999);      //случаен номер
                string randomNumber = string.Concat("0", randomNum);
                Call tempCall = new Call(DateTime.Now.Add(timeOffset), randomNumber, (ushort)rand.Next(3600));
                this.testPhone.AddCall(tempCall);
                Console.WriteLine(tempCall.ToString());  //показва информация на новия случаен разовор
                }
            //изчислява общата цена на всички раговори
            Console.WriteLine("Total price of all calls at {0:c}/min: {1:c}", priceMinute, this.testPhone.CalcCallsPrice(priceMinute));
            //премахва най-длъгия разговор
            //изчислява отново цената
            Console.WriteLine("Price of calls except the longest at {0:c}/min: {1:c}", priceMinute, this.testPhone.CalcCallsPrice(priceMinute));
            //изчиства списъка с разговори
            this.testPhone.ClearCallHistory();
            }
        }
    }
