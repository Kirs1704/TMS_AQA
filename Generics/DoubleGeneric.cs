namespace Generics;

public class DoubleGeneric<T,K>
{
    public T Id { get; set; }
    public K Code { get; set; }
    public string Name { get; set; }

    public DoubleGeneric(T id, K code, string name)
    {
        Id = id;
        Code = code;
        Name = name;
    }
}