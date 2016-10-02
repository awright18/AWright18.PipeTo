#r "Build/Fake/tools/FakeLib.dll" // include Fake lib
open Fake 
open Fake.AssemblyInfoFile
open Fake.Git
open Fake.GitVersionHelper
open System;


//Generator variables
let generatorProjectName = "AWright18.PipeTo.CodeGenerator"
let generatorProjectCsProj = sprintf "./source/%s/%s.csproj" generatorProjectName generatorProjectName
let generatorBuildDir = sprintf "artifacts/%s" generatorProjectName
let generatorExe =  sprintf "artifacts/%s/%s.exe" generatorProjectName generatorProjectName
let generatorExeArgs = "source\AWright18.PipeTo\AWright18.PipeTo.csproj"

//Pipe To Variables 
let projectName = "AWright18.PipeTo";
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

    CreateCSharpAssemblyInfo "./source/Properties/AssemblyInfo.cs"
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
    ==> "CreatePackage"
    

RunTargetOrDefault "BuildApp"