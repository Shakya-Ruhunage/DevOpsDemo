using System;
using System.Threading.Tasks;
using DevOpsTestApplication.Enums;

namespace DevOpsTestApplication.Services.CalculatorService
{
    public class CalculatorService<T> : ICalculatorService<T> 
    {
        public async Task<int> Calculate(int number1, int number2, Operation operation)
        {
            int result = 0;

           switch(operation)
            {
                case Operation.Addition:
                    result = number1 + number2;
                    break;
                case Operation.Substraction:
                    result = number1 - number2;
                    break;
                case Operation.Multiply:
                    result = number1 * number2;
                    break;
                case Operation.Devide:
                    result = number1 / number2;
                    break;
                case Operation.Module:
                    result = number1 % number2;
                    break;
                default:
                    break;
            }

            return await Task.FromResult(result);
        }
    }
}
