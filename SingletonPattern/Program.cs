// See https://aka.ms/new-console-template for more information
var response = SingletonExample.Instance;
Console.WriteLine(response);


var response1 = SingletonExample.Instance;
Console.WriteLine(response1);

Console.WriteLine(Object.Equals(response1, response));

public class ThreadSafeSingleton
{
    private static readonly ThreadSafeSingleton _instance = new ThreadSafeSingleton();
    public static ThreadSafeSingleton Instance
    {
        get
        {
            return _instance;
        }
    }

    public ThreadSafeSingleton()
    {
    }
}

public class SingletonExample
{
    private static SingletonExample _instance;
    public static SingletonExample Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonExample();
            }
            return _instance;
        }
    }

    public SingletonExample()
    {
    }
}
