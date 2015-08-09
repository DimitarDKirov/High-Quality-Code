using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student
    {
        private const int MaxNumber = 99999;
        private static int serialNumber = 10000;
        private int number;
        private string name;

        public Student(string name)
        {
            this.Name = name;
            this.Number = serialNumber++;
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value > MaxNumber)
                {
                    throw new ArgumentOutOfRangeException("You can not add more students");
                }

                this.number = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Student name must be provided");
                }

                this.name = value;
            }
        }
    }
}
