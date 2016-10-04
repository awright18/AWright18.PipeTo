@echo off
cls
REM remove Fake dir
IF EXIST %~dp0Build\FAKE (
    rmdir %~dp0Build\FAKE /s /q
)
REM remove GitVersion dir
IF EXIST %~dp0Build\GitVersion.CommandLine (
    rmdir %~dp0Build\GitVersion.CommandLine /s /q
)

REM remove xunit runner dir
IF EXIST %~dp0Build\xunit.runner.console (
    rmdir %~dp0Build\xunit.runner.console /s /q
)

"build\nuget\NuGet.exe" "Install" "FAKE" "-OutputDirectory" "build" "-ExcludeVersion"
"build\nuget\NuGet.exe" "Install" "GitVersion.CommandLine" "-OutputDirectory" "build" "-ExcludeVersion"
"build\nuget\NuGet.exe" "Install" "xunit.runner.console" "-OutputDirectory" "build" "-ExcludeVersion"
"build\FAKE\tools\Fake.exe" build.fsx
pause