namespace ClassDemoTemplate;

public interface IAbstractADT
{
    void Add(string item);
    void Clear();
    bool Remove(string item);
    int Count { get; }
}