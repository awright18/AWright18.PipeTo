#r "Build/Fake/tools/FakeLib.dll" // include Fake lib
open Fake 
open Fake.AssemblyInfoFile
open Fake.Git
open Fake.GitVersionHelper

let projectName = "AWright18.PipeTo";
let authors = ["Adam Wright"]
let projectDecription = "Allows Piping of function results to other functions";
let projectSummary = "Pipe function results to other functions"
let tags = "C# Extensions Piping"

let buildDir = sprintf "artifacts/%s" projectName
let nugetOutputDir = "artifacts/nuget"
let nuspec = sprintf "%s.nuspec" projectName
let slnName = sprintf "%s.sln" projectName
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
    CleanDirs [buildDir;artifactsDir;]
)

Target "NugetRestore" (fun _-> 
    RestorePackages()
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

    !! slnName
    |> MSBuildRelease buildDir "Build" 
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
         nuspec
)

//Build order
"Clean"
    ==> "NugetRestore"
    ==> "SetVersions"
    ==> "BuildApp"
    ==> "CreatePackage"

RunTargetOrDefault "BuildApp"