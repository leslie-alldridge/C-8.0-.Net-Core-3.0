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