using Module.Controllers;
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


        static ResultContainer<Person> CreatePerson(string name, int age)
        {
            if (age < 0)
                return Factory.CreateFailure<Person>("Возраст не может быть меньше 0");

            var person = new Person { Name = name, Age = age };
            return Factory.CreateSuccess(person);
        }

        var per1 = CreatePerson("Александра", 21);
        var per2 = CreatePerson("Илья", -21);

        PrintResult(per1);
        PrintResult(per2);

        static void PrintResult<T>(ResultContainer<T> result)
        {
            if (result.IsSuccess)
                System.Console.WriteLine($"{result.Value}");
            else 
            System.Console.WriteLine($"Ошибка: {result.ErrorMessage}");
        }
    }
}