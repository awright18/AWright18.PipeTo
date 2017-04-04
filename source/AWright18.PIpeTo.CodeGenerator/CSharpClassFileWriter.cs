using System;
using System.IO;

namespace AWright18.PipeTo.CodeGenerator
{
    public class CSharpClassFileWriter
    {
        public void WriteToClassFile(string classCode,string classFile)
        {
            if (classCode == null)
                throw new ArgumentNullException(nameof(classCode));

            if(classFile == null)
                throw new ArgumentNullException(nameof(classFile));

            try
            {
                using (var writer = new StreamWriter(classFile))
                {
                    writer.Write(classCode);
                    writer.Flush();
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Could not write class file {classFile}",ex);
            }
        }
    }
}
