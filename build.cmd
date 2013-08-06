REM To enable auto package restore
set EnableNuGetPackageRestore=true

@REM For cryptic syntax %~dp0 refer to http://stackoverflow.com/questions/5034076/what-does-dp0-mean-and-how-does-it-work
@set thisPath=%~dp0

@%thisPath%\build\tools\nant-0.92\bin\NAnt.exe -buildfile:%thisPath%\build\build.build %*
@if not %errorlevel% equ 0 pause


