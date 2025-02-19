namespace Generics;

public class Company<T>
{
    public T CEO { get; set; }

    public Company(T ceo)
    {
        CEO = ceo;
    }
}