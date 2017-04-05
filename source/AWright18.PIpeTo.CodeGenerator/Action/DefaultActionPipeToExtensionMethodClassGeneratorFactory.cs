namespace AWright18.PipeTo.CodeGenerator.Action
{
    public class DefaultActionPipeToExtensionMethodClassGeneratorFactory : IExtensionMethodClassGeneratorFactory
    {
        private readonly string _namespaceName;
        private readonly string _methodName;

        public DefaultActionPipeToExtensionMethodClassGeneratorFactory(string namespaceName, string methodName)
        {
            _namespaceName = namespaceName;
            _methodName = methodName;
        }

        public IStringGenerator Create()
        {
            var defaultValuePrefix = "value";
            uint numberOfGenerics = 17;
            return new ActionPipeToClassGenerator(
                _namespaceName,
                $"{_methodName}ActionExtensions",
                _methodName,
                numberOfGenerics,
                new TypeArgumentGenerator(),
                new ActionValuesGenerator(defaultValuePrefix),
                new ActionParametersGenerator(defaultValuePrefix),
                new VoidActionReturnValueGenerator()
                );
        }
    }
}