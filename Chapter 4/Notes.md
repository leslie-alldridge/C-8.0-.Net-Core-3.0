This chapter covers the following topics:
• Writing functions
• Debugging during development
• Logging during runtime
• Unit testing

Numbers that are used to count are called cardinal numbers, for example, 1, 2, and 3.

Whereas numbers that are used to order are ordinal numbers, for example, 1st, 2nd,
and 3rd.

Recursion is clever, but it can lead to problems, such as a stack overflow due to too many function calls because memory is used to store data on every function call and it eventually uses too much.

Add code throughout your application to log what is happening, and especially when exceptions occur, so that you can review the logs and use them to trace the issue and fix the problem.

Trace is used to add logging that gets written during both development and runtime.

Debug is used to add logging that gets written during development.

A trace listener is a type that can be configured to write output anywhere you like when the `Trace.WriteLine` method is called. There are several trace listeners provided by .NET Core, and you can even make your own by inheriting from the TraceListener type

Any type that represents a file usually implements a buffer to improve
performance. Instead of writing immediately to the file, data is written to
an in-memory buffer and only once the buffer is full will it be written in one
chunk to the file.

When running with the Release configuration, only the Trace output is shown.You can therefore use `Debug.WriteLine` calls liberally throughout your code, knowing they will be stripped out automatically when you build the release version of your application.


| Number | Word    | Description                                        |
| ------ | ------- | -------------------------------------------------- |
| 0      | Off     | This will output nothing                           |
| 1      | Error   | This will output only errors                       |
| 2      | Warning | This will output errors and warnings               |
| 3      | Info    | This will output errors, warnings, and information |
| 4      | Verbose | This will output all levels                        |

Microsoft has a proprietary unit testing framework known as MS Test; however, we will use the third-party framework xUnit.net.

page 171...