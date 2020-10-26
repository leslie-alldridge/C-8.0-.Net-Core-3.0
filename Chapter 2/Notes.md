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

page 83...