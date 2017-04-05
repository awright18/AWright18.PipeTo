using System;
using System.Text;

namespace AWright18.PipeTo.CodeGenerator.Func
{
    public class FuncParametersGenerator : IGenericStringGenerator
    {
        private readonly string _valuePrefix;

        public FuncParametersGenerator(string valuePrefix)
        {
            if(valuePrefix == null)
                throw new ArgumentException(nameof(valuePrefix));

            _valuePrefix = valuePrefix;
           
        }

        public string Generate(uint numberOfGenerics)
        {
            var parameterListBuilder = new StringBuilder();

            for (int number = 1; number <= numberOfGenerics; number++)
            {
                if ((number == 1 || number == numberOfGenerics))
                {
                    continue;
                }
                else
                {
                    parameterListBuilder.Append($",T{number} {_valuePrefix}{number}");
                }
            }
            return parameterListBuilder.ToString();
        }
    }
}
