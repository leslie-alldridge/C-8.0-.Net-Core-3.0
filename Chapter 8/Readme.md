This chapter covers the following topics:
- Working with numbers
- Working with text
- Pattern matching with regular expressions
- Storing multiple objects in collections
- Working with spans, indexes, and ranges
- Working with network resources
- Working with types and attributes
- Internationalizing your code

String members (static members are denoted by `string.` in the table below)

| Member | Description 
| :---: | :---: 
| Trim, TrimStart, and TrimEnd | These trim whitespace characters such as space, tab, and carriage-return from the beginning and/or end of the string variable.
| ToUpper and ToLower | These convert all the characters in the string variable into uppercase or lowercase.
| Insert and Remove | These insert or remove some text in the `string` variable.
| Replace | This replaces some text with other text.
| string.Concat | This concatenates two string variables. The + operator calls this method when used between `string` variables.
| string.Join | This concatenates one or more string variables with a character in between each one.
| string.IsNullOrEmpty | This checks whether a string variable is null or empty ("").
| string.IsNullOrWhitespace | This checks whether a string variable is null or whitespace; that is, a mix of any number of horizontal and vertical spacing characters, for example, tab, space, carriage return, line feed and so on.
| string.Empty | This can be used instead of allocating memory each time you use a literal string value using an empty pair of double quotes ("").
| string.Format | An older, alternative method to string interpolation to output formatted string variables, which uses positioned instead of named parameters.

It's best practice to use StringBuilder instead of + or concat when building strings in a loop. This will save on memory consumption.

Once escape characters are disabled with `@`, then they can be interpreted by a regular expression

Regular expression syntax:

| Symbol | Meaning | Symbol | Meaning 
| :---: | :---: | :---: | :---: 
| ^ |  Start of input | $ |  End of input
| \d |  A single digit | \D |  A single NON-digit
| \w |  Whitespace | \W |  NON-whitespace
| [A-Za-z0-9] |  Start of input | \\^ |  ^ (caret) character
| [aeiou] |  Set of characters | [^aeiou]  |  NOT in a set of characters
| . |  Any single character | \\. |  . (dot) character
| + |  One or more | ? |  One or none
| {3} |  Exactly three | {3, 5} |  Three to five
| {3, } |  At least three | { ,3} |  Up to three

#### Collections

##### Lists

Lists are a good choice when you want to manually control the order of items in a collection. Each item has a unique index.
Indexes can change after inserting or manipulating the items.

##### Dictionaries

Dictionaries are a good choice when each value (or object) has a unique sub value (or a made-up value) that can be used as a key to quickly find the value in the collection later. The key must be unique. 
For example, if you are storing a list of people, you could choose to use a government-issued identity number as the key.
Dictionaries must implement the interface `IDictionary<TKey, TValue>`.

##### Stacks

Stacks are a good choice when you want to implement the last-in, first-out (LIFO) behavior. With a stack, you can only directly access or remove the one item at the top of the stack, 
although you can enumerate to read through the whole stack of items. You cannot, for example, directly access the second item in a stack.

##### Queues

Queues are good when you want to implement the first-in, first-out (FIFO) behaviour. You can only access or remove one item at the front of the queue.

##### Sets

Sets are a good choice when you want to perform set operations between two collections. For example, you may have two collections of city names, 
and you want to know which names appear in both sets (known as the intersect between the sets). Items in a set must be unique.

up to page 306 pdf