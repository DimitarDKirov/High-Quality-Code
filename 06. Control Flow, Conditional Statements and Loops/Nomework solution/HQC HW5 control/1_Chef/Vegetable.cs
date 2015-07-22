using System;

public abstract class Vegetable : ICookable
{
    public Vegetable()
    {
        this.IsCutted = false;
        this.IsPeeled = false;
    }

    public bool IsPeeled { get; private set; }
    public bool IsCutted { get; private set; }

    public void Cut()
    {
        this.IsCutted = true;
    }

    public void Peel()
    {
        this.IsPeeled = true;
    }

    public override string ToString()
    {
        return string.Format("{0} - cutted: {1}, peeled: {2}", this.GetType(), this.IsCutted, this.IsPeeled);
    }
}