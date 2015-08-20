namespace MobilePhones
{
    using System;

    public class Battery
    {
        private int hoursIdle;
        private int capacity;

        public Battery() : this(null, 0, 0, 0)
        { 
        }

        public Battery(string model, int hoursIdleTime, int capacity, BatteryType batType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdleTime;
            this.Capacity = capacity;
            this.TypeOfBattery = batType;
        }

        public string Model { get; set; }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle time must be positive number");
                }

                this.hoursIdle = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity must be positive number");
                }

                this.capacity = value;
            }
        }

        public BatteryType TypeOfBattery { get; set; }

        public override string ToString()
        {
            return string.Format("Battery {0} {1} {2}mAh {3}h", this.Model, this.TypeOfBattery, this.Capacity, this.HoursIdle);
        }
    }
}
