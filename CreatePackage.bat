@echo off
cls
"build\FAKE\tools\Fake.exe" build.fsx target="CreatePackage"

pause