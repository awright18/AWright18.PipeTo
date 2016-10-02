using System;
using System.IO;
using FubuCsProjFile;

namespace AWright18.PIpeTo.CodeGenerator
{
    public class CsProjFileFileAdder
    {
        public void AddFile(string codeFile, string csProjFile)
        {
            if(codeFile == null)
                throw new ArgumentNullException(nameof(codeFile));

            if (csProjFile == null)
                throw new ArgumentNullException(nameof(csProjFile));

            if(!File.Exists(csProjFile))
                throw new FileNotFoundException("couldn't fine csprojFile", csProjFile);

            if(!File.Exists(codeFile))
                throw new FileNotFoundException("couldn't codeFile codeFile to add", codeFile);

            var csProj = CsProjFile.LoadFrom(csProjFile);

            var relativeCodeFilePath = GetFileRelativePathToCsProj(codeFile, csProjFile);

            csProj.Add(new CodeFile(relativeCodeFilePath));

            csProj.Save();
        }

        public string GetFileRelativePathToCsProj(string codeFile, string csProjFile)
        {
            if (codeFile == null)
                throw new ArgumentNullException(nameof(codeFile));

            if (csProjFile == null)
                throw new ArgumentNullException(nameof(csProjFile));

            if (!File.Exists(csProjFile))
                throw new FileNotFoundException("couldn't fine csprojFile", csProjFile);

            if (!File.Exists(codeFile))
                throw new FileNotFoundException("couldn't codeFile codeFile to add", codeFile);

            var codeFileInfo = new FileInfo(codeFile);

            var codeFileName = codeFileInfo.Name;

            var csProjDir = new FileInfo(csProjFile).Directory.FullName;

            var codeFileDir = codeFileInfo.Directory.FullName;

            var csProjDirUri = new Uri(csProjDir);
            var codeFileDirUri = new Uri(codeFileDir);

            string relativePath = codeFileDirUri.MakeRelativeUri(csProjDirUri).ToString();

            return Path.Combine(relativePath, codeFileName);

        }
    }
}
