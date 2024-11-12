namespace Methods.Models;

public class Cat
{
    public string name;
    public int age;
    public int maxFoodCount;


    public bool Eaten(int foodCount)
    {
        
        if (foodCount >= maxFoodCount)
        {

            return true;
        }
        else
        {
            return false;
        }
    }
}