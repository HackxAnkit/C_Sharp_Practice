2. Verify Installation

After installation, close and reopen Terminal, then run:

dotnet --version

3. Create and Run a Project
mkdir csharp
cd csharp

dotnet new console -n MyApp
cd MyApp

dotnet run

dotnet run YourFileName.cs


Expected output:

Hello, World!
4. VS Code Extensions

Install:

C# Dev Kit
C# Extension

If dotnet --version still doesn't work after installation, send me the output of:

uname -m
which dotnet
echo $PATH

and I'll help you fix the PATH configuration.