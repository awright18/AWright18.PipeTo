#r "Build/Fake/tools/FakeLib.dll" // include Fake lib
open Fake 
open Fake.AssemblyInfoFile
open Fake.Git
open Fake.GitVersionHelper
open Fake.Testing.XUnit2
open System;

//Generator Project variables
let generatorProjectName = "AWright18.PipeTo.CodeGenerator"
let generatorProjectCsProj = sprintf "./source/%s/%s.csproj" generatorProjectName generatorProjectName
let generatorBuildDir = sprintf "artifacts/%s" generatorProjectName
let generatorExe =  sprintf "artifacts/%s/%s.exe" generatorProjectName generatorProjectName
let generatorExeArgs = "source\AWright18.PipeTo\AWright18.PipeTo.csproj"

//Test Project Variables
let testProjectName = "AWright18.PipeTo.Tests"
let testProjectCsProj = sprintf "./tests/%s/%s.csproj" testProjectName testProjectName
let testProjectDll = sprintf "artifacts/%s/%s.dll" testProjectName testProjectName
let testBuildDir = sprintf "artifacts/%s" testProjectName
let xUnitExeName = "xunit.console"
let xUnitExe =  sprintf "build/%s/%s.exe" "xunit.runner.console/tools" xUnitExeName
let xUnitExeArgs = testProjectDll
let xUnitHtmlOutput = sprintf "artifacts/%s/%s.html" testProjectName testProjectName

//Pipe To Variables 
let projectName = "AWright18.PipeTo";
let propertiesFile = sprintf "./source/%s/Properties/AssemblyInfo.cs" projectName
let authors = ["Adam Wright"]
let projectDecription = "Allows Piping of function results to other functions";
let projectSummary = "Pipe function results to other functions"
let tags = "C# Extensions Piping"

let buildDir = sprintf "artifacts/%s" projectName
let nugetOutputDir = "artifacts/nuget"
let nuspec = sprintf "%s.nuspec" projectName
let projectFileName = sprintf "./source/%s/%s.csproj" projectName projectName
let artifactsDir = "artifacts"
let projectGuid = "E8C6B039-E310-41FE-9B83-1E163739CD9A"
let copyright =  "2016"
let mutable assemblyVersion = ""
let mutable nugetVersion = ""
let mutable informationalVersion = ""
let mutable commitHash = ""
let mutable majorMinorVersion = ""


//Targets 
Target "Clean" (fun _ -> 
    CleanDirs []
)

Target "NugetRestore" (fun _-> 
    RestorePackages()
)

Target "BuildGenerator" (fun _-> 

    !! generatorProjectCsProj
    |> MSBuildRelease generatorBuildDir "build"
    |> Log "GeneratorBuild-Output: " 
)

Target "RunGenerator" (fun _-> 
    
     ExecProcess (fun info ->  
        info.FileName <- generatorExe
        info.WorkingDirectory <- "."
        info.Arguments <- generatorExeArgs ) (TimeSpan.FromMinutes 5.0)
        |> ignore
)

Target "SetVersions" (fun _-> 
    
    let result = GitVersion (fun p -> { p with ToolPath = @"Build\GitVersion.CommandLine\tools\GitVersion.exe" })

    assemblyVersion <- result.AssemblySemVer
    nugetVersion <- result.NuGetVersion
    informationalVersion <- result.InformationalVersion
    commitHash <- result.Sha
    majorMinorVersion <- result.MajorMinorPatch + ".0"
)


Target "BuildApp" (fun _ -> 

    trace "updateing"
    CreateCSharpAssemblyInfo propertiesFile
        [Attribute.Title projectName
         Attribute.Description projectDecription
         Attribute.Guid projectGuid
         Attribute.Product projectName
         Attribute.Copyright copyright
         Attribute.Version assemblyVersion
         Attribute.FileVersion majorMinorVersion
         Attribute.InformationalVersion informationalVersion
         Attribute.Metadata("githash", commitHash)]

    !! projectFileName
    |> MSBuildRelease buildDir "build" 
    |> Log "ReleaseBuild-Output: " 
)

Target "RunTests" (fun _-> 
    trace "Running Tests"

    !! testProjectCsProj
    |> MSBuildRelease testBuildDir "build" 
    |> Log "ReleaseBuild-Output: " 

    !! testProjectDll
    |> xUnit2 (fun p -> { p with 
                           ToolPath = xUnitExe
                           WorkingDir = Some "."
                           HtmlOutputPath = Some xUnitHtmlOutput
        })
)

Target "CreatePackage" (fun _ ->
    CreateDir nugetOutputDir
    NuGet (fun p -> 
        {p with
              Authors = authors
              Project = projectName
              Description = projectDecription
              Summary = projectSummary
              Version = nugetVersion
              Tags = tags
              Copyright = copyright
              OutputPath = nugetOutputDir
              WorkingDir = "."
         }) 
         "AWright18.PipeTo.nuspec"
)

//Build order
"Clean"
    ==> "NugetRestore"
    ==> "BuildGenerator"
    ==> "RunGenerator"
    ==> "SetVersions"
    ==> "BuildApp"
    ==> "RunTests"
    ==> "CreatePackage"
    

RunTargetOrDefault "RunTests"