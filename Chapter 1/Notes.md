## .Net Framework

CLR - Common Language Runtime responsible for managing code execution

BCL - Base Class Library provides a rich library of classes to build applications from.

GAC - Global Assembly Cache contains cached .exe or .dll files.

## .Net Core

Contains cross platform implementations named CoreCLR and CoreFX (library of classes)

.Net Standard is just a standard the same way as HTML5 is.

## Intermediate Language

C# compiler is named Roslyn converts source code into intermediate language code and stores this in a .dll or .exe assembly file which then gets executed by .Net Core's virtual machine CoreCLR. Next the (JIT) Just In Time compiler compiles it into native CPU instructions.

.Net Native can be used for compiling code ahead of time.



