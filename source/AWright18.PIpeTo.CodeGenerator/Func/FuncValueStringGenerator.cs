using System.Text;

namespace AWright18.PipeTo.CodeGenerator.Func
{
    public class FuncValueStringGenerator : IGenericStringGenerator
    {
        private readonly string _valuePrefix;

        public FuncValueStringGenerator(string valuePrefix)
        {
            _valuePrefix = valuePrefix;
        }

        public string Generate(uint finish)
        {
            var valuesList = new StringBuilder();

            for (int number = 1; number <= finish; number++)
            {
                if (number == 1 || number == finish)
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
