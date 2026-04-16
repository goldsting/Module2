using Module.Models;

namespace Module.Controllers;

public static class Factory
{
    public static ResultContainer<T> CreateSuccess<T>(T value)
    {
        return new ResultContainer<T>
        {
            IsSuccess = true,
            Value = value,
            ErrorMessage = string.Empty
        };
    }
        public static ResultContainer<T> CreateFailure<T>(string error)
    {
        return new ResultContainer<T>
        {
            IsSuccess = false,
            Value = default,
            ErrorMessage = error
        };
    }
}