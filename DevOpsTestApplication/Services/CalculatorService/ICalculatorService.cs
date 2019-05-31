using System;
using System.Threading.Tasks;
using DevOpsTestApplication.Enums;

namespace DevOpsTestApplication.Services.CalculatorService
{
    public interface ICalculatorService<T>
    {
        Task<T> Calculate(T number1, T number2, Operation operation);
    }
}
