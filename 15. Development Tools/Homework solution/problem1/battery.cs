using System;

namespace MobilePhones
{
    public class Battery
    {
        private int hoursIdle;
        private int hoursTalk;

        public Battery() : this(null, 0, 0, 0) { }

        public Battery(string model, int hoursIdleTime, int hoursTalkTime, BatteryType batType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdleTime;
            this.HoursTalk = hoursTalkTime;
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

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Talk time must be positive number");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType TypeOfBattery { get; set; }
    }
}
