# Building AWright18.PipeTo

### PreRequisites

* MSBUILD 15

### Tools Used
* Paket - Paket is used to manage and restore the packages required to build the solution.
* FAKE - Fake is the build tool.  build.fsx is the build script
* GitVersion - This is used to help with SemVer versioning
* Xunit - The unit tests are built and ran using XUnit
* FubuCsProj - used to add classes to the AWright18.PipeTo.csproj

### Basic Project Structure

* AWright18.PipeTo - The library that gets built and packaged up. 
* AWright18.PipeTo.CodeGenerator  - This library generates the extension methods that are added to AWright18.PipeTo. It just uses C# to create the classes used in AWright18.PipeTo to ensure the correct PipeTo extension methods get created.
* AWright18.PipeTo.Tests - This is the unit test library that verifies all the of the PipeTo methods work as expected. 

### Running a Build

You can simply execute the ci_build.bat.  This will do a number of things.

1. build the AWright18.PipeTo.CodeGenerator.
2. execute the AWright18.PipTo.CodeGenerator which creates the necessary files for AWright18.PipeTo
3. build AWright18.PipeTo
4. build AWright18.PipeTo.Tests
5. Run unit Tests
6. Create the Nuget Package


All the artifacts for the build including the nuget packages are ouptut to the artifacts directory.

