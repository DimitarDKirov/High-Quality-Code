using System;

namespace Abstraction
{
    public abstract class Figure
    {
        public Figure()
        {
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        protected static bool IsValid(double value)
        {
            return value >= 0;
        }
    }
}
