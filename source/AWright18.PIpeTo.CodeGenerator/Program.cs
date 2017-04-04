using System;
using System.IO;
using AWright18.PipeTo.CodeGenerator.Action;
using AWright18.PipeTo.CodeGenerator.Func;

namespace AWright18.PipeTo.CodeGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            if (args[0] == null)
                throw new ArgumentException("csProjFilePath is required as the first argument to this program.");

            var csProjFile = args[0];

            if (!File.Exists(csProjFile))
                throw new FileNotFoundException("csprojFile was not found", csProjFile);

            var namespaceName = "AWright18.PipeTo";

            var methodName = "PipeTo";

            var csProjFileDirectory = new FileInfo(csProjFile).Directory.FullName;

            var generators = new IStringGenerator[]
            {
                new DefaultActionPipeToExtensionMethodClassGeneratorFactory(namespaceName, methodName).Create(),
                new DefaultFuncPipeToExtensionMethodClassGeneratorFactory(namespaceName, methodName).Create()
            };

            foreach (var generator in generators)
            {
                var code = generator.Generate();

                var className = ((IHaveAGeneratedClassName) generator).GeneratedClassName;

                var classFile = Path.Combine(csProjFileDirectory, $"{className}.cs");

                new CSharpClassFileWriter().WriteToClassFile(code, classFile);

                new CsProjFileFileAdder().AddFile(classFile, csProjFile);
            }
        }
    }
}
