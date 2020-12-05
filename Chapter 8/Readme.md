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

<hr/>

Using Immutable collections: `using System.Collections.Immutable;`

To safely allow multiple threads to work with those objects knowing they won't change, you should make them immutable.

<b>Reflection</b> is a programming feature that allows code to understand and manipulate itself. An assembly is made up of up to four parts:
- Assembly metadata and manifest: Name, assembly, and file version, referenced assemblies, and so on.
- Type metadata: Information about the types, their members, and so on.
- IL code: Implementation of methods, properties, constructors, and so on.
- Embedded Resources (optional): Images, strings, JavaScript, and so on.

When updating a NuGet package, you should specify an optional flag to make sure that you only upgrade to the highest minor to avoid breaking changes, or to the highest patch if you are extra cautious and only want to receive bug fixes, as shown in the following commands:

- Major: Breaking changes.
- Minor: Non-breaking changes, including new features and bug fixes.
- Patch: Non-breaking bug fixes.

`Update-Package Newtonsoft.Json -ToHighestMinor`
`Update-Package EPiServer.Cms -ToHighestPatch`

Internationalization is the process of enabling your code to run correctly all over the world. It has two parts: globalization and localization.

#### Exercise 8.1

1. What is the maximum number of characters that can be stored in a string variable? Several billion, but it depends on the .NET CLR memory limit and the machine hosting the code.
2. When and why should you use a SecureString class? Represents text that should be kept confidential, such as by deleting it from computer memory when no longer needed.
3. When is it appropriate to use a StringBuilder type? Instead of using `+` or `concat()` you can use a `StringBuilder`
4. When should you use a `LinkedList<T>` class? It's a doubly linked class, great for adding or removing many items from the start / end of the list.
5. When should you use a `SortedDictionary<T>` class rather than a `SortedList<T>` class? SortedList can retrieve items by index and uses less memory. SortedDictionary retrieves item by key and has faster insertion and removal operations - but uses more memory.
6. What is the ISO culture code for Welsh? `cy-GB`
7. What is the difference between localization, globalization, and internationalization? Localization is more about the language so that button labels make sense. Globalization is about writing code in a way that it can accommodate multiples languages and regions. Internationalization is the process of enabling code to run correctly all over the world.
8. In a regular expression, what does $ mean? End of input
9. In a regular expression, how could you represent digits? `[0-9]`
10. Why should you not use the official standard for email addresses to create a regular expression to validate a user's email address? You can use `System.Net.Mail.MailAddress` to do that for you. E.g. `MailAddress m = new MailAddress(emailaddress);`

page 324... exercise 8.2 regex