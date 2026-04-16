namespace Module.Models;

public class ResultContainer<T>
{
    public bool IsSuccess { get; set; }
    public T? Value { get; set; }
    public string ErrorMessage { get; set; } = string.Empty;
}