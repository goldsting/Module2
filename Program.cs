using Module.Models;
class Program {
    static void Main(){
        var floatnumber = new PrivateModel<float>();
        floatnumber.SetValue(2.44f);
        Console.WriteLine ($"Значение float: {floatnumber.GetValue()}");

        var boolHolder = new PrivateModel<bool>();
        boolHolder.SetValue(true);
        Console.WriteLine ($"Значение bool: {boolHolder.GetValue()}");

        int x = 10, y = 15;
        Swapper.Swap(ref x, ref y);
        Console.WriteLine ($"x={x}, y={y}");

        var words = new List<string>{"яблоко","киви"};
        Swapper.PrintCollections(words);

        int Maximum = Calculator.Max(20, 42);
        Console.WriteLine ($"Максимум: {Maximum}");

        string MaxString = Calculator.Max ("Апельсин", "Гуава");
        Console.WriteLine($"Максимум:{MaxString}");

        double Minimum = Calculator.Min(3.22, 1.337);
        Console.WriteLine($"Минимум: {Minimum}");
    }
}