namespace MobilePhones
{
    using System;
    using System.Collections.Generic;
    using log4net;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private float displaySize;
        private List<Call> callHistory;
        private static readonly ILog Log = LogManager.GetLogger(typeof(GSM));

        public GSM(string model, string manufacturer, float price, string owner, Battery battery, float displaySize)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.PhoneOwner = owner;
            this.BatteryData = battery;
            this.DisplaySize = displaySize;
            this.callHistory = new List<Call>();
            log4net.Config.XmlConfigurator.Configure();
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0.0f, null, null, 0.0f)
        {
        }

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
                    Log.Error("Null or whispace value for GSM model");
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
                    Log.Error("Null or whispace value for GSM manufacturer");
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
                    Log.Error("Negative value for GSM price");
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
                    Log.Error("Negative value for GSM display size");
                    throw new ArgumentOutOfRangeException("Display size can not be negative number");
                }

                this.displaySize = value;
            }
        }

        public string PhoneOwner { get; set; }

        public Battery BatteryData { get; set; }

        public override string ToString()
        {
            string phoneData = string.Format("{1} {0} {2}\" Price: {3:c}\tOwner: {4}\n{5}\n", this.model, this.manufacturer, this.DisplaySize, this.price, this.PhoneOwner, this.BatteryData.ToString());
            return phoneData;
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
            Log.Info("new call " + call.ToString());
        }

        public void ClearCallHistory()
        {
            Log.Info("Call history cleared");
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
