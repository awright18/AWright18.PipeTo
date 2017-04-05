using System;
using System.Text;

namespace AWright18.PipeTo.CodeGenerator.Action
{
    public class ActionParametersGenerator : IGenericStringGenerator
    {

        private readonly string _valuePrefix;

        public ActionParametersGenerator(string valuePrefix)
        {
            if(valuePrefix == null)
                throw new ArgumentException(nameof(valuePrefix));

            _valuePrefix = valuePrefix;
        }

        public string Generate(uint finish)
        {
            var parameterListBuilder = new StringBuilder();

            for (int number = 1; number <= finish; number++)
            {
                if ((number == 1))
                {
                    continue;
                }
                else
                {
                    parameterListBuilder.Append($", T{number} {_valuePrefix}{number}");
                }
            }
            return parameterListBuilder.ToString();
        }

        
    }
}
