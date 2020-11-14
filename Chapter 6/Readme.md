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

When instantiating an instance of a generic type `<T>`, the developer
must pass a type parameter. In this example, we pass int as the
type parameter for gt1 and string as the type parameter for gt2,
so wherever T appears in the GenericThing class, it is replaced with
int and string.

Thread culture defines how things display using the region and language of the machine it's running on.

**Memory**

There are two categories of memory: stack memory and heap memory

Stack memory is faster to work with (because it is managed directly by the CPU and because it uses a first-in, first-out mechanism, it is more likely to have the data
in its L1 or L2 cache) but limited in size, while heap memory is slower but much
more plentiful.

When you define a type using class, you are defining a reference type. This means that the memory for the object itself is allocated on the heap, and only the memory address of the object (and a little overhead) is stored on the stack.

When you define a type using struct, you are defining a value type. This means that the memory for the object itself is allocated on the stack.

These are the most common struct types:
• **Numbers**: byte, sbyte, short, ushort, int, uint, long, ulong, float, double, and decimal
• **Miscellaneous**: char and bool
• **System.Drawing**: Color, Point, and Rectangle

You cannot inherit from a struct.

Each type can have a single finalizer that will be called by the .NET runtime when the resources need to be released

```
public class Animal
{
 public Animal()
 {
 // allocate any unmanaged resources
 }
 ~Animal() // Finalizer aka destructor
 {
 // deallocate any unmanaged resources
 }
}
```

Rather than hiding a method, it is usually better to override it.

You can use the `sealed` keyword to a method to prevent anyone from further overriding a method. You can only `seal` an overridden method.

#### Polymorphism

You have now seen two ways to change the behavior of an inherited method. We can hide it using the new keyword (known as non-polymorphic inheritance), or we can override it (known as polymorphic inheritance).

Use the `is` and `as` keywords to avoid throwing exceptions when casting between derived types. If you don't do this, you must write try...catch statements for `InvalidCastException`.

### Exceptions

Unlike ordinary methods, constructors are not inherited so we must explicitly declare and call the base constructor implementations in `System.Exception` to make them available to programmers wanting to use them for custom exceptions. 

When defining your own exceptions, give them the same three constructors that explicitly call the built-in ones.