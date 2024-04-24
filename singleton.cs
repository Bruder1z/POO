class  SingletonClass
{
    private static SingletonClass singletonObject;

    public int numero = 10;

    private SingletonClass()
    {

    }

    public static SingletonClass GetInstance
    {
        get
        {
            if (singletonObject == null)
            {
                singletonObject = new SingletonClass();
            }
            return singletonObject;
        }
    }

    static void Main(string[] args)
    {
        SingletonClass singleton = SingletonClass.GetInstance;

        Console.WriteLine(singleton.numero);

        singleton.numero = 20;

        SingletonClass singleton2 = SingletonClass.GetInstance;

        Console.WriteLine(singleton2.numero);

        singleton2.numero += 50;

        Console.WriteLine(singleton.numero);

        Console.Read();
    }

}