// -----------------------------------------------------------------------
// <copyright file="OldSize.cs" company="Kirovi Home PC">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace HQC_HW4_Variables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class OldSize
    {
        public double wIdTh, Viso4ina;
        public OldSize(double w, double h)
        {
            this.wIdTh = w;
            this.Viso4ina = h;
        }

        public static OldSize GetRotatedSize(OldSize s, double angleOfTheFigureThatWillBeRotaed)
        {
            return new OldSize(Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh +
                    Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh +
                    Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
        }
    }
}
