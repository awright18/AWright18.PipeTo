using System;
using System.Text;

namespace AWright18.PipeTo.CodeGenerator.Action
{
    public class ActionValuesGenerator : IGenericStringGenerator
    {
        private readonly string _valuePrefix;

        public ActionValuesGenerator(string valuePrefix)
        {
            if (valuePrefix == null)
                throw new ArgumentException(nameof(valuePrefix));

            _valuePrefix = valuePrefix;
        }

        public string Generate(uint finish)
        {
            if(finish == default(uint))
                throw new ArgumentException(nameof(finish));
            var valuesList = new StringBuilder();

            for (int number = 1; number <= finish; number++)
            {
                if (number == 1)
                {
                    continue;
                }
                else
                {
                    valuesList.Append($", {_valuePrefix}{number}");
                }
            }

            return valuesList.ToString();


        }
    }
}
