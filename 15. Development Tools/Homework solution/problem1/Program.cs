﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhones
    {
    //problem 3 - enum
    public enum BatteryType
    { LiIon, NiMH, NiCd, LiPol }
       
    public class GSMbegin
        {
        static void Main()
            {
            Battery bl5c = new Battery("BL-5C", 300, 33, BatteryType.NiMH);
            Display bwDisplay = new Display(1.3f, 2);
            GSM nokia1100 = new GSM("1100", "NOKIA", 100, "Ivan Ivanov", bl5c, bwDisplay);
            Console.WriteLine(nokia1100);

            //GSM galayA5 = new GSM("Galaxy A5", "Samsung", 779.90f, "Penka Petkova", new Battery("2300mAh integrated", 68, 15, BatteryType.LiIon), new Display(5f, 16000000));
            //string galaxyA5Str = galayA5.ToString();
            //Console.WriteLine(galaxyA5Str);

            //инициализация на статичното поле iPhone4S
            Battery iPhoneBat = new Battery("iPhone bat", 200, 8, BatteryType.LiIon);
            Display iPhoneDisplay = new Display(3.5f, 16000000);
            GSM iPhone = new GSM("iPhone4S", "Apple", 1000f, "Happy Iphone Owner", iPhoneBat, iPhoneDisplay);
            GSM.IPhone4S = iPhone;

            //Console.WriteLine(GSM.IPhone4S.Manufacturer + " " + GSM.IPhone4S.Model);
            //GSM lgA390 = new GSM("A390-Dual SIM", "LG", 115, "Kirov", new Battery("1700 mAh", 800, 15, BatteryType.LiIon), null);
            //Call call1 = new Call("10.10.14","10:05", "088812346", 18);
            //Call cal2 = new Call(DateTime.Now, "0899999999", 150);
            //Call cal3 = new Call();
            //lgA390.AddCall(call1);
            //lgA390.AddCall(cal2);
            //lgA390.AddCall(cal3);

            //използване на GSMTest - problem7

            GSMTest gsmTestCase1 = new GSMTest();
            Console.WriteLine("GSM test");
            Console.WriteLine(gsmTestCase1.GSMinfo());

            //изпозлване на GSMCallHistoryTest - problem 12
            GSMCallHistoryTest testCalls = new GSMCallHistoryTest();
            testCalls.TestCallHistory();


            
            }
        }
    }
        