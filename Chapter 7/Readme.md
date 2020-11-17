This chapter covers the following topics:
- Introducing .NET Core 3.0
- Understanding .NET Core components
- Publishing your applications for deployment
- Decompiling assemblies
- Packaging your libraries for NuGet distribution
- Porting from .NET Framework to .NET Core

Some of the more important packages
- System.Runtime (Object, string, Int32, Array)
- System.Collections (List<t>, Dictionary<TKey, TValue>)
- System.Net.Http (HttpClient, HttpResponseMessage)
- System.IO.Filesystem (File, Directory)
- System.Reflection (Assembly, TypeInfo, MethodInfo)

![Type Keywords](typekeywords.PNG)

Press F12 to go to definition. You may notice the namespace and assembly names differ.

There are three ways to publish and deploy a .Net Core application. There are:
- Framework-dependent deployment (FDD)
- Framework-dependent executables (FDEs)
- Self-contained (includes .Net Core)

You can use the RID (Runtime IDentifier) catalog to identify currently supported values.

To build and release code as a `nupkg` file do the following:
- `dotnet build -c Release`
- `dotnet pack -c Release`

![Differences](differences.PNG)