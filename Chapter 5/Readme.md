This chapter will cover the following topics:
• Talking about OOP
• Building class libraries
• Storing data with fields
• Writing and calling methods
• Controlling access with properties and indexers

**Encapsulation**

Encapsulation is the combination of the data and actions that are related to an object. For example, a BankAccount type might have data, such as Balance and AccountName, as well as actions, such as Deposit and Withdraw. When encapsulating, you often want to control what can access those actions and the data, for example, restricting how the internal state of an object can be accessed or modified from the outside.

**Composition**

Composition is about what an object is made of. For example, a car is composed of different parts, such as four wheels, several seats, and an engine.

**Aggregation**

Aggregation is about what can be combined with an object. For example, a person is not part of a car object, but they could sit in the driver's seat and then becomes the car's driver. Two separate objects that are aggregated together to form a new component.

**Inheritance**

Inheritance is about reusing code by having a subclass derive from a base or super class. All functionality in the base class is inherited by and becomes available in the derived class. For example, the base or super `Exception` class has some members that have the same implementation across all exceptions, and the sub or derived `SqlException` class inherits those members and has extra members only relevant to when an SQL database exception occurs like a property for the database connection.

**Abstraction**

Abstraction is about capturing the core idea of an object and ignoring the details or specifics. C# has an abstract keyword which formalizes the concept. If a class is not explicitly abstract then it can be described as being concrete. Base or super classes are often abstract, for example, the super class Stream is abstract and its sub classes like `FileStream` and `MemoryStream` are concrete. Abstraction is a tricky balance. If you make a class more abstract, more classes would be able to inherit from it, but at the same time there will be less functionality to share.

**Polymorphism**

Polymorphism is about allowing a derived class to override an inherited action to provide custom behavior.

Note that the C# keyword public is applied before class. This keyword is called an `access modifier`, and it allows for all the other code to access this class. 

**Members**

`Fields` are used to store data. There are also three specialized categories
of field, as shown in the following bullets:

° **Constant**: The data never changes. The compiler literally copies the data into any code that reads it.

° **Read-only**: The data cannot change after the class is instantiated, but the data can be calculated or loaded from an external source at the time of instantiation.

° **Event**: The data references one or more methods that you want to execute when something happens, such as clicking on a button, or responding to a request from other code.

<hr/>

`Methods` are used to execute statements. There are also four specialized categories of method:

° **Constructor**: The statements execute when you use the new keyword to allocate memory and instantiate a class.

° **Property**: The statements execute when you get or set data. The data is commonly stored in a field, but could be stored externally, or calculated at runtime. Properties are the preferred way to encapsulate fields unless the memory address of the field needs to be exposed.

° **Indexer**: The statements execute when you get or set data using array syntax [].

° **Operator**: The statements execute when you use an operator like + and / on operands of your type.

When class B inherits from class A, we say that A is the base or super class and B is the derived or subclass. In this case, `System.Object` is the base or super class and `Person` is the derived or subclass.

Assume other programmers know that if inheritance is not specified, the class will inherit from System.Object.

| Access Modifier    | Description                                                                                                                                                                                 |
| ------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| private            | Member is accessible inside the type only. This is the default.                                                                                                                             |
| internal           | Member is accessible inside the type and any type in the same assembly.                                                                                                                     |
| protected          | Member is accessible inside the type and any type that inherits from the type.                                                                                                              |
| public             | Member is accessible everywhere.                                                                                                                                                            |
| internal protected | Member is accessible inside the type, any type in the same assembly, and any type that inherits from the type. Equivalent to a fictional access modifier named `internal_or_protected`.     |
| private protected  | Member is accessible inside the type, or any type that inherits from        the type and is in the same assembly. Equivalent to a fictional access modifier named `internal_and_protected`. |

Explicitly apply one of the access modifiers to all type members, even if you want to use the implicit access modifier for members, which is private. Additionally, fields should usually be private or protected, and you should then create public properties to get or set the field values. This is because it controls access.

An enum type is a very efficient way of storing one or more choices because, internally, it uses integer values in combination with a lookup table of string descriptions.

Use the enum values to store combinations of discreet options. Derive an enum type from `byte` if there are up to eight options, from `short` if there are up to 16 options, from `int` if there are up to 32 options, and from `long` if there are up to 64 options.

When using a List<T> the T is part of a feature called `generics` and creates a strongly typed array. The term `generics` means we can use a more specific static type (instead of system.object).

Sometimes, you want to define a field that only has one value that is shared across all instances. These are called `static` members.

When using constants you need to rebuild all assemblies that rely on them in order to get the latest value. A better choice for these fields (ones that shouldn't change) is to mark them as `read only`.

Use read-only fields over the const fields for two important reasons: the value can be calculated or loaded at runtime and can be expressed using any executable statement. So, a readonly field can be set using a constructor or a field assignment. Every reference to the field is a live reference, so any future changes will be correctly reflected by calling code

When a parameter is passed into a method, it can be passed in one of three ways:
• `By value` (this is the default): Think of these as being in-only.
• `By reference` as a ref parameter: Think of these as being in-and-out.
• `As an out parameter`: Think of these as being out-only.