namespace AWright18.PipeTo.CodeGenerator.Func
{
    public class FuncReturnValueGenerator : IGenericStringGenerator
    {
        public string Generate(uint finish)
        {
            return $"T{finish}";
        }
    }
}
