This chapter covers the following topics:

• Operating on variables
• Understanding selection statements
• Understanding iteration statements
• Casting and converting between types
• Handling exceptions
• Checking for overflow

Examples of unary operators include incrementors and retrieving a type or its size in bytes, as shown in the following code:

```
int x = 5;
int incrementedByOne = x++;
int incrementedByOneAgain = ++x;
Type theTypeOfAnInteger = typeof(int);
int howManyBytesInAnInteger = sizeof(int);
```

A ternary operator works on three operands, as shown in the following pseudocode:
```
var resultOfOperation = firstOperand firstOperator
secondOperand second Operator thirdOperand;
```

#### Logical Operators

For the AND `&` logical operator, both operands must be true for the result to be true.

For the OR `|` logical operator, either operand can be true for the result to be true.

For the XOR `^` logical operator, either operand can be true (but not both!) for the result to be true.

CPUs can perform a bit-shift faster than multiplication

#### Miscellaneous operators

`.` is called the member access operator

`()` is called the invocation operator

The two selection statements in C# are `if` and `switch`. 

Just because you can leave out the curly braces in if statements, doesn't mean you should. Your code is not "more efficient" without them; instead, it is less maintainable and potentially more dangerous.

**Pattern Matching**:

Tests whether an expression can be converted to a specified type and, if it can be, casts it to a variable of that type

Additionally, case statements can include a when keyword to perform more specific pattern matching

#### For statement

The for statement is like while, except that it is more succinct. It combines:

• An initializer expression, which executes once at the start of the loop.
• A conditional expression, which that executes on every iteration at the start
of the loop to check whether the looping should continue.
• An iterator expression, which that executes on every loop at the bottom of
the statement.

#### How foreach works behind the scenes

Technically, the foreach statement will work on any type that follows these rules:
1. The type must have a method named GetEnumerator that returns an object.
2. The returned object must have a property named Current and a method
named MoveNext.
3. The MoveNext method must return true if there are more items to enumerate
through or false if there are no more items.

There are interfaces named `IEnumerable` and `IEnumerable<T>` that formally define these rules but technically the compiler does not require the type to implement these
interfaces.

Current value available during iteration is read only.

#### Cast and Convert

You cannot implicitly cast a double variable into an int variable because it is potentially unsafe and could lose data.

One difference between casting and converting (using System.Convert) is that converting rounds the double value 9.8 up to 10 instead of trimming the part after the decimal point.

We have shown that the rule for rounding in C# is subtly different from the primary school rule:

• It always rounds down if the decimal part is less than the midpoint .5.
• It always rounds up if the decimal part is more than the midpoint .5.
• It will round up if the decimal part is the midpoint .5 and the non-decimal part is odd, but it will round down if the non-decimal part is even.

This rule is known as `Banker's Rounding`, and it is preferred because it reduces bias by alternating when it rounds up or down.

You can take control of rounding rules using the Math.Round method.

MidpointRounding.AwayFromZero is the primary school rule.

#### Converting to String

The `ToString` method converts the current value of any variable into a textual
representation. Some types can't be sensibly represented as text, so they return their namespace and type name.

Transporting images or video: The safest thing to do is to convert the binary object into a string of safe characters. Programmers call this `Base64` encoding.

Parsing from string to numbers or dates and times:
- Only a few types have a Parse method, including all the number types and DateTime.
- You can use format codes such as `D` to output only the date part using long date format
- Problem with parsing is that when unsuccessful it errors

Avoid writing code that will throw an exception whenever possible, perhaps by performing if statement checks, but sometimes you can't. In those scenarios, you could catch the exception and handle it in a better way than the default behavior.

page 134..