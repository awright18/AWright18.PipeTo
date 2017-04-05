using System.Text;

namespace AWright18.PipeTo.CodeGenerator
{
    public class TypeArgumentGenerator : IGenericStringGenerator
    {
        public string Generate(uint numberOfGenerics)
        {
            var typeListBuilder = new StringBuilder();

            for (int number = 1; number <= numberOfGenerics; number++)
            {
                if (number == 1)
                {
                    typeListBuilder.Append("T1");
                }
                else
                {
                    typeListBuilder.Append($",T{number}");
                }
            }

            return typeListBuilder.ToString();
        }
    }
}
