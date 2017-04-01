using System;
using AWright18.PIpeTo.CodeGenerator;

namespace AWright18.PipeTo.CodeGenerator.Func
{
    public class FuncPipeToClassGenerator : IStringGenerator, IHaveAGeneratedClassName
    {
        public string GeneratedClassName => _className;

        private readonly string _namespaceName;
        private readonly string _className;
        private readonly string _methodName;
        private readonly uint _numberOfGenerics;
        private readonly Func<uint,string> _types;
        private readonly Func<uint,string> _parameters;
        private readonly Func<uint,string> _values;
        private readonly Func<uint,string> _tReturnValue; 
    

        public FuncPipeToClassGenerator(string namespaceName, string className, string methodName, uint numberOfGenerics,
            IGenericStringGenerator typeGenerator, IGenericStringGenerator valuesGenerator, IGenericStringGenerator parametersGenerator, IGenericStringGenerator returnValueGenerator)
        {
            _namespaceName = namespaceName;
            _className = className;
            _methodName = methodName;
            _numberOfGenerics = numberOfGenerics;
            _types = typeGenerator.Generate;
            _parameters = parametersGenerator.Generate;
             _values = valuesGenerator.Generate;
            _tReturnValue = returnValueGenerator.Generate;

        }

        public string Generate()
        {
            string template = $@"
            
using System;
namespace {_namespaceName}
{{
    public static class {_className}
    {{                  
";
            for (uint i = 2; i < _numberOfGenerics; i++)
            { 

                template += $@"
        public static {_tReturnValue(i)} {_methodName}<{_types(i)}> (this T1 val1, Func<{_types(i)}> func {_parameters(i)} )
        {{
            return func(val1 {_values(i)});
        }}
                ";
            }

            template += @"
    }
}             
            ";

            return template;
        }

      
    }
}
