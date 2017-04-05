using System;

namespace AWright18.PipeTo.CodeGenerator.Action
{
    public class ActionPipeToClassGenerator : IStringGenerator,IHaveAGeneratedClassName
    {
        public string GeneratedClassName => _className;

        private readonly string _namespaceName;
        private readonly string _className;
        private readonly string _methodName;
        private readonly uint _numberOfGenerics;
        private readonly Func<uint, string> _types;
        private readonly Func<uint, string> _parameters;
        private readonly Func<uint, string> _values;
        private readonly Func<string> _returnValue;

        public ActionPipeToClassGenerator(string namespaceName, string className, string methodName,uint numberOfGenerics,
             IGenericStringGenerator typeGenerator, IGenericStringGenerator valuesGenerator, IGenericStringGenerator parametersGenerator, IStringGenerator returnValueGenerator)
        {
            _namespaceName = namespaceName;
            _className = className;
            _methodName = methodName;
            _numberOfGenerics = numberOfGenerics;
            _types = typeGenerator.Generate;
            _parameters = parametersGenerator.Generate;
            _values = valuesGenerator.Generate;
            _returnValue = returnValueGenerator.Generate;

        }

        public string Generate()
        {
            string template = $@"         
using System;
namespace {_namespaceName}
{{
    public static class {_className}
    {{      
        public static {_returnValue()} {_methodName}<T>(this T val1, Action<T> action)
        {{
            action(val1);
        }}";

            for (uint i = 2; i < _numberOfGenerics; i++)
            {

                template += $@"
        public static  {_returnValue()} {_methodName}<{_types(i)}> (this T1 val1, Action<{_types(i)}> action{_parameters(i)})
        {{
            action(val1{_values(i)});
        }}";
            }

            template += @"
    }
}";
            return template;
        }

       
    }
}
