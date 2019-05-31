using System;
using System.Threading.Tasks;

namespace DevOpsTestApplication.Services.ValidatorSerivice
{
    public class ValidatorService:IValidatorService
    {
    
        public Task<bool> IsNumber(string value)
        {
            var isNumber = int.TryParse(value, out int number);
            return Task.FromResult(isNumber);
        }
    }
}
