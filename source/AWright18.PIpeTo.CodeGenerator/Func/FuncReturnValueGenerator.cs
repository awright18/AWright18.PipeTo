using AWright18.PIpeTo.CodeGenerator;

namespace AWright18.PipeTo.CodeGenerator
{
    public class FuncReturnValueGenerator : IGenericStringGenerator
    {
        public string Generate(uint finish)
        {
            return $"T{finish}";
        }
    }
}
