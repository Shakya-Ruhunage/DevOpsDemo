using System;
using System.Threading.Tasks;
using DevOpsTestApplication.Enums;

namespace DevOpsTestApplication.Services.CalculatorService
{
    public class CalculatorService<T> : ICalculatorService<T> 
    {
        public async Task<T> Calculate(T number1, T number2, Operation operation)
        {
            T result;
            dynamic param1 = number1;
            dynamic param2 = number2;

           switch(operation)
            {
                case Operation.Addition:
                    result = param1 + param2;
                    break;
                case Operation.Substraction:
                    result = param1 - param2;
                    break;
                case Operation.Multiply:
                    result = param1 * param2;
                    break;
                case Operation.Devide:
                    result = param1 / param2;
                    break;
                case Operation.Module:
                    result = param1 % param2;
                    break;
                default:
                    result = default;
                    break;
            }

            return await Task.FromResult(result);
        }
    }
}
