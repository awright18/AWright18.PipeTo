@echo off
cls
"build\nuget\NuGet.exe" "Install" "FAKE" "-OutputDirectory" "build" "-ExcludeVersion"
"build\nuget\NuGet.exe" "Install" "GitVersion.CommandLine" "-OutputDirectory" "build" "-ExcludeVersion"
"build\FAKE\tools\Fake.exe" build.fsx
pause