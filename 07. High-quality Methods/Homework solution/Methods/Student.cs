using System;

namespace Methods
{
    class Student
    {
        private const int BirthPartStart = 10;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.GetBirthDate();
            DateTime secondDate = other.GetBirthDate();
            return firstDate > secondDate;
        }

        private DateTime GetBirthDate()
        {
            string birthSubpart = this.OtherInfo.Substring(this.OtherInfo.Length - BirthPartStart);
            DateTime birthDate = DateTime.Parse(birthSubpart);
            return birthDate;
        }
    }
}
