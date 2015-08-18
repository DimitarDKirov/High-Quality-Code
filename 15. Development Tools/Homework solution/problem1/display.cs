using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhones
{
    public class Display
    {
        private float size;
        private int numberOfColors;

        public Display(float sizeInches, int numberColors)   //пълен конструктор 
        {
            this.Size = sizeInches;
            this.NumberOfColors = numberColors;
        }

        public float Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException("Display size must be positive");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colors must be postitive number");
                }

                this.numberOfColors = value;
            }
        }
    }
}
