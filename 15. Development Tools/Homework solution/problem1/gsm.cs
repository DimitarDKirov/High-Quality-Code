using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhones
{
    class GSM
    {
        private static GSM iphone4S;    //problem 6 - статично поле

        private string model;
        private string manufacturer;
        private float price;
        private Display displayData;    //поле за класа на дисплея
        private List<Call> callHistory; //problem 9 - архив (списък от) разговори

        public GSM(string model, string manufacturer, float price, string owner, Battery bat, Display display)       //конструктор с всички данни
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.PhoneOwner = owner;
            this.BatteryData = bat;
            this.displayData = display;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, 0.0f, null, null, null) { }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model must be specified"); //задължителни данни -  problem 2
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer must be specified");//задължителни данни -  problem 2
                }

                this.manufacturer = value;
            }
        }

        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentOutOfRangeException("Price must be positive number or 0");//цената не може да е отрицателна
                }

                this.price = value;
            }
        }

        public string PhoneOwner { get; set; }

        public Battery BatteryData { get; set; }

        public static GSM IPhone4S
        {
            get { return GSM.iphone4S; }
            set { GSM.iphone4S = value; }
        }

        public override string ToString()
        {
            string phoneData = string.Format("{1} {0}\tPrice: {2:c}\tOwner: {3}\nBattery model: {4}; Battery talk time: {5}; Battery type: {6}\n", this.model, this.manufacturer, this.price, this.PhoneOwner, BatteryData.Model, BatteryData.HoursTalk, BatteryData.TypeOfBattery);
            if (this.displayData == null)
                return phoneData;
            else
            {
                string display = string.Format("Display size: {0}\" Display colors: {1}", this.displayData.Size, this.displayData.NumberOfColors);
                return phoneData + display + '\n';
            }
        }
        //problem 10 - добавяне и изтриване на разговор, изчистване на всички разговори
        public void AddCall(Call call)
        { this.callHistory.Add(call); }
        public void RemoveCall(Call call)
        { this.callHistory.Remove(call); }

        public void ClearCallHistory()
        { this.callHistory.Clear(); }

        //problem11 - изчисляване на цената на всички разговори при вход цена на минута
        public float CalcCallsPrice(float priceMinute)
        {
            float result = 0.0f;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                result += priceMinute * this.callHistory[i].CallDuration / 60;
            }
            return result;
        }
        //problem 12 - връща разговора с най-дълга продължителност 
        public Call LongestCall
        {
            get
            {
                Call longestDurationCall = new Call();
                foreach (Call call in this.callHistory)
                    if (call.CallDuration > longestDurationCall.CallDuration)
                        longestDurationCall = call;
                return longestDurationCall;
            }
        }
    }
}
