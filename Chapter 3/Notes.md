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