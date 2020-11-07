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

page 223.