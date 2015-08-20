using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhones
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private float displaySize;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer, float price, string owner, Battery battery, float displaySize)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.PhoneOwner = owner;
            this.BatteryData = battery;
            this.DisplaySize = displaySize;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, 0.0f, null, null, 0.0f) { }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Model must be specified"); 
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Manufacturer must be specified");
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
                    throw new ArgumentOutOfRangeException("Price must be positive number or 0");
                }

                this.price = value;
            }
        }



        public float DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Display size can not be negative number");
                }

                displaySize = value;
            }
        }


        public string PhoneOwner { get; set; }

        public Battery BatteryData { get; set; }

        public override string ToString()
        {
            string phoneData = string.Format("{1} {0} {2}\" Price: {3:c}\tOwner: {4}\n{5}\n", this.model, this.manufacturer, this.DisplaySize, this.price, this.PhoneOwner, BatteryData.ToString());
            return phoneData;
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public float CalcCallsPrice(float pricePerMinute)
        {
            float result = 0.0f;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                result += pricePerMinute * this.callHistory[i].CallDuration / 60;
            }

            return result;
        }
    }
}
