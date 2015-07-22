using System;

public class Size
{
    public double width, height;

    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Size GetRotatedSize(Size size, double rotatedFigureAngel)
    {
        double angelCos = Math.Cos(rotatedFigureAngel);
        double angelSin = Math.Sin(rotatedFigureAngel);
        double rotatedFigureWidth = Math.Abs(angelCos) * size.width + Math.Abs(angelSin) * size.height;
        double rotatedFigureHeight = Math.Abs(angelSin) * size.width + Math.Abs(angelCos) * size.height;
        Size rotatedFigure = new Size(rotatedFigureWidth, rotatedFigureHeight);
        return rotatedFigure;
    }
}

