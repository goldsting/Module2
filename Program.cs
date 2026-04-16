using Module.Models;
class Program {
    static void Main(){
        var floatnumber = new PrivateModel<float>();
        floatnumber.SetValue(2.44f);
        Console.WriteLine ($"Значение float: {floatnumber.GetValue()}");

        var boolHolder = new PrivateModel<bool>();
        boolHolder.SetValue(true);
        Console.WriteLine ($"Значение bool: {boolHolder.GetValue()}");
    }
}