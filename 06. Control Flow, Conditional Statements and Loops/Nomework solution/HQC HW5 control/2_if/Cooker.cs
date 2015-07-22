namespace ControlFlow.t2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Potato
    {
        public Potato()
        {
            this.IsPeeled = false;
            this.IsRotten = false;
        }

        public bool IsPeeled { get; private set; }
        public bool IsRotten { get; private set; }
    }

    public class Cooker
    {
        public void Prepare()
        {
            Potato potato;
            //...
            if (potato != null && potato.IsPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }

        }

        private void Cook(Potato potato)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Cell
    {
        private const int MIN_X = 0;
        private const int MAX_X = 10;
        private const int MIN_Y = 0;
        private const int MAX_Y = 20;

        private bool shouldVisitCell;

        public Cell()
        {
        }

        public void GoToCell(int x, int y)
        {
            bool IsInBorderX = MIN_X <= x && x <= MAX_X;
            bool IsInBorderY = MIN_Y <= y && y <= MAX_Y;

            if (IsInBorderX && IsInBorderY && shouldVisitCell)
            {
                VisitCell();
            }

        }

        private void VisitCell()
        {
        }
    }
}
