public interface ISingletonContainer
{
    int GetPopulation(string name);
}

public class SingletonDataContainer: ISingletonContainer
{
    private Dictionary<string, int> _capitals = new Dictionary<string, int>();
 
    public SingletonDataContainer()
    {
        Console.WriteLine("Initializing singleton object");
 
        var elements = File.ReadAllLines("capitals.txt");
        for (int i = 0; i < elements.Length; i+=2)
        {
            _capitals.Add(elements[i], int.Parse(elements[i + 1]));
        }
    }
 
    public int GetPopulation(string name)
    {
        return _capitals[name];
    }
}
// Singleton class -> contains private constructor(SingletonDataContainer),static methods 
public class SingletonDataContainer: ISingletonContainer
{
    private Dictionary<string, int> _capitals = new Dictionary<string, int>();
 
    private SingletonDataContainer()
    {
        Console.WriteLine("Initializing singleton object");
 
        var elements = File.ReadAllLines("capitals.txt");
        for (int i = 0; i < elements.Length; i+=2)
        {
            _capitals.Add(elements[i], int.Parse(elements[i + 1]));
        }
    }
 
    public int GetPopulation(string name)
    {
        return _capitals[name];
    }
 
    private static SingletonDataContainer instance = new SingletonDataContainer();
 
    public static SingletonDataContainer Instance => instance;
}

class Program
{
    static void Main(string[] args)
    {
        var db = SingletonDataContainer.Instance;
        var db2 = SingletonDataContainer.Instance;
        var db3 = SingletonDataContainer.Instance;
        var db4 = SingletonDataContainer.Instance;
    }
}
