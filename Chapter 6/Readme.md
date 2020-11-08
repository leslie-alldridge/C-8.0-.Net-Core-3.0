This chapter covers the following topics:

• Setting up a class library and console application

• Simplifying methods

• Raising and handling events

• Implementing interfaces

• Making types more reusable with generics

• Managing memory with reference and value types

• Inheriting from classes

• Casting within inheritance hierarchies

• Inheriting and extending .NET types



We might want two instances of Person to be able to procreate. We can implement this by writing methods. Instance methods are actions that an object does to itself; static methods are actions the type does. 

A method that creates a new object, or modifies an existing object, should return a reference to that object so that the caller can see the results.

Local functions are sometimes called nested or inner functions.

Methods are often described as actions that an object can perform, either on itself or to related objects. e.g. .Add .ToString

Events are often described as actions that happen to an object. .OnClick Button press etc.

If you have used languages that support function pointers, then think of a `delegate` as being a typesafe method pointer.

Microsoft's convention for method names that handle events is `ObjectName_EventName`.

For event delegate fields you'll want to use `public event EventHandler Shout` as the event keyword will enforce `+=` and `-=` operations for events. Using `=` will replace all methods.

**Common Interfaces**

| Interface       | Method                                          | Description                                                                                                     |
| --------------- | ----------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| IComparable     | CompareTo(other)                                | This defines a comparison method that a type implements to order or sort its instances.                         |
| IComparer       | Compare(first, second)                          | This defines a comparison method that a secondary type implements to order or sort instances of a primary type. |
| IDisposable     | Dispose()                                       | This defines a disposal method to release unmanaged resources more efficiently than waiting for a finalizer.    |
| IFormattable    | ToString(format, culture)                       | This defines a culture-aware method to format the value of an object into a string representation.              |
| IFormatter      | Serialize(stream, object) & Deserialize(stream) | This defines methods to convert an object to and from a stream of bytes for storage or transfer.                |
| IFormatProvider | GetFormat(type)                                 | This defines a method to format inputs based on a language and region.                                          |
<hr/>

If anyone will want to sort an array or collection of instances of your type, then implement the `IComparable` interface.