Keywords such as **string** that look like types are aliases, which represent types provided by the platform on which C# runs.

Casing:
- camelCase for local variables and private fields
- TitleCase for non-private fields and methods

• Literal string: Characters enclosed in double-quote characters. They can use
escape characters like \t for tab.

• Verbatim string: A literal string prefixed with @ to disable escape characters
so that a backslash is a backslash.

• Interpolated string: A literal string prefixed with $ to enable embedded
formatted variables. You will learn more about this later in this chapter.

#### Numbers

Humans use base 10 numbering system whereas computers use base 2 (zero and one) numbering system. 

C# has an operator named `sizeof()` that returns the number of bytes that a type uses in memory.

Doubles are not guaranteed to be accurate because some numbers cannot be literally represented as floating-point values. 0.1 + 0.2 doesn't equal 0.3.

Never compare doubles using `==`

The decimal type is accurate because it stores the number as a large integer and
shifts the decimal point. For example, 0.1 is stored as 1, with a note to shift the
decimal point one place to the left. 12.75 is stored as 1275, with a note to shift the
decimal point two places to the left.

Use `int` for whole numbers, `double` for real numbers that won't be compared and `decimal` for money, engineering, and other places requiring accuracy. 

double also has some special values like `double.NaN` `Epsilon` and `Infinity`

#### Dyanmic types

There is another special type named dynamic that can also store any type of data, but
even more than object, its flexibility comes at the cost of performance.

Local variables only exist during execution of a method while reference types must wait for a garbage collection.

`var` keyword is good to use when the type is obvious

#### Default values

Most of the primitive types except `string` are `value types`, which means that they must have a value. A default value can be set using `default()`. 

Null is the default for all reference types. String is a reference type.

To enable the feature at the project level, add the following to your project file:

```
<PropertyGroup>
    <Nullable>enable</Nullable>
</PropertyGroup>
```

Checking whether a nullable reference type or nullable value type variable currently
contains null is important because if you do not, a NullReferenceException can be
thrown, which results in an error. You should check for a null value before using a
nullable variable.

null-coalescing operator ?? can be used to assign a new value if the variable is currently `null`.

#### Format strings

The full syntax of a format item is:
{ index [, alignment ] [ : formatString ] }

Alignment values are integers. Positive integers are right-aligned and
negative integers are left-aligned.

C format string means currency.

page 98 key input from users...