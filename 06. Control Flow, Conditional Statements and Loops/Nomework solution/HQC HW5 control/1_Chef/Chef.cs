public class Chef
{
    public void Cook()
    {
        Potato potato = GetPotato();
        Peel(potato);
        Cut(potato);

        Carrot carrot = GetCarrot();
        Peel(carrot);
        Cut(carrot);

        Bowl bowl = GetBowl();
        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private Potato GetPotato()
    {
        return new Potato();
    }


    private Carrot GetCarrot()
    {
        return new Carrot();
    }

    private void Peel(Vegetable vegetable)
    {
        vegetable.Peel();
    }

    private void Cut(Vegetable vegetable)
    {
        vegetable.Cut();
    }

    private Bowl GetBowl()
    {
        return new Bowl();
    }
}
