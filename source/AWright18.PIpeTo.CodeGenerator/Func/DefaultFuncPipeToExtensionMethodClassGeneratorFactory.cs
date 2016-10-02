using AWright18.PipeTo.CodeGenerator.Action;

namespace AWright18.PipeTo.CodeGenerator.Func
{
    public class DefaultFuncPipeToExtensionMethodClassGeneratorFactory : IExtensionMethodClassGeneratorFactory
    {
        private readonly string _namespaceName;
        private readonly string _methodName;

        public DefaultFuncPipeToExtensionMethodClassGeneratorFactory(string namespaceName, string methodName)
        {
            _namespaceName = namespaceName;
            _methodName = methodName;
        }

        public IStringGenerator Create()
        {
            var defaultValuePrefix = "value";

            return new FuncPipeToClassGenerator(
                _namespaceName,
                $"{_methodName}FuncExtensions",
                _methodName,
                16,
                new TypeArgumentGenerator(),
                new FuncValueStringGenerator(defaultValuePrefix),
                new FuncParametersGenerator(defaultValuePrefix),
                new FuncReturnValueGenerator()
                );
        }
    }
}
