This chapter covers the following topics:

• Operating on variables

• Understanding selection statements

• Understanding iteration statements

• Casting and converting between types

• Handling exceptions

• Checking for overflow

Examples of unary operators include incrementors and retrieving a type or its size in
bytes, as shown in the following code:

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

CPUs can perform a bit-shift faster

#### Miscellaneous operators

`.` is called the member access operator

`()` is called the invocation operator

The two selection statements in C# are `if` and `switch`. 