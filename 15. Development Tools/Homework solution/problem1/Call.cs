using System;


namespace MobilePhones
{
    class Call
    {
        private DateTime callDateTime;

        public Call()
            : this(DateTime.MinValue, string.Empty, 0)
        { }

        public Call(DateTime callDateTime, string number, ushort callDuration)
        {
            this.callDateTime = callDateTime;
            this.PhoneNumber = number;
            this.CallDuration = callDuration;
        }

        public Call(string callDate, string callTime, string number, ushort callDuration)
        {
            this.CallDate = callDate;
            this.CallTime = callTime;
            this.PhoneNumber = number;
            this.CallDuration = callDuration;
        }

        public string CallDate
        {
            get
            {
                return callDateTime.ToShortDateString();
            }
            set
            {
                try
                {
                    callDateTime = DateTime.Parse(value, System.Globalization.DateTimeFormatInfo.InvariantInfo);
                }
                catch (Exception ex)
                {
                    throw new FormatException("Date is not in correct format");
                }
            }
        }

        public string CallTime
        {
            get
            {
                return callDateTime.ToLongTimeString();
            }
            set
            {
                TimeSpan time;
                try
                {
                    time = TimeSpan.Parse(value);
                }

                catch (Exception ex)
                {
                    throw new ArgumentException("Time format is not correct");
                }

                callDateTime = callDateTime.Add(time);
            }
        }

        public string PhoneNumber { get; set; }

        public ushort CallDuration { get; set; }

        public override string ToString()
        {
            return string.Format("Call date: {0} time: {1} number: {2} duration {3}:{4:00} min:sec", this.CallDate, this.CallTime, this.PhoneNumber, this.CallDuration / 60, this.CallDuration % 60);
        }
    }
}
