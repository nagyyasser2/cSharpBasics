# None-primitive Data Types

This document serves as a comprehensive guide to both primitive and non-primitive data types, covering key concepts, best practices, and practical examples.

---

## Table of Contents
- [Classes and Objects](#classes-and-objects)
  - [Declaring Classes](#declaring-classes)
  - [Declaring Objects](#declaring-objects)
  - [Static Modifiers](#static-modifiers)
- [Structs](#structs)
- [Arrays](#arrays)
- [Strings](#strings)
- [Enums](#enums)
- [Reference Type vs. Value Type](#reference-type-vs-value-type)

---

## Classes and Objects

### Classes:
Classes are the building blocks of object-oriented programming. They combine related variables (fields) and functions (methods) into a single unit. Classes define the blueprint for creating objects.

### Objects:
Objects are instances of classes. They represent concrete implementations of the class blueprint, with their own values for the class's fields.

#### Declaring Classes:
```csharp
public class Person {
    public string Name;

    public void Introduce() {
        Console.WriteLine("Hi! My name is {0}.", this.Name);
    }
}
```

#### Declaring Objects:
```csharp
Person person = new Person();
var person1 = new Person();

person.Name = "Nagy";
person.Introduce();
```

### Static Modifiers:
A `static` modifier allows you to access fields and methods directly from the class without creating an instance. Static members are shared across all instances of the class.

**Key Point:** In a C# application, the `Main` method serves as the single entry point and is always `static`.

#### Example:
```csharp
public class Program {
    public static void Main() {
        Console.WriteLine("Hello, World!");
    }
}
```

---

## Structs:
Structs are value types that are similar to classes but are more lightweight. They are ideal for representing small, simple objects.

#### Declaring a Struct:
```csharp
public struct RgbColor {
    public int Red;
    public int Green;
    public int Blue;
}
```

> **Tip:** Use structs when creating small, lightweight objects that do not require inheritance.

---

## Arrays:
Arrays are collections of items stored at contiguous memory locations. They allow you to store multiple values of the same type.

#### Declaring an Array:
```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
```

#### Accessing Elements:
```csharp
Console.WriteLine(numbers[0]); // Outputs: 1
```

>[!NOTE]
> Array elements will take the default type if you did't initialized it.
---

## Strings:
Strings are sequences of characters used to represent text. In C#, strings are immutable, meaning their values cannot be changed after they are created. However, you can create new strings based on operations performed on existing ones.

### Key Characteristics:
- **Immutable:** Modifying a string creates a new string in memory.
- **Flexible:** C# provides various methods and operators for string manipulation.

### Examples:

#### Basic Usage:
```csharp
string greeting = "Hello, World!";
Console.WriteLine(greeting);
```

#### Concatenation:
```csharp
string firstName = "NAGY";
string lastName = "YASSER";

// Using + Operator
string fullName = firstName + " " + lastName;

// Using String.Format
string formattedName = string.Format("{0} {1}", firstName, lastName);

// Using Interpolation (Preferred in Modern C#)
string interpolatedName = $"{firstName} {lastName}";

Console.WriteLine(fullName);
Console.WriteLine(formattedName);
Console.WriteLine(interpolatedName);
```

#### Joining Strings:
```csharp
var numbers = new int[] { 1, 2, 3 };

// Join elements with a comma separator
string list = string.Join(",", numbers);
Console.WriteLine(list); // Outputs: 1,2,3
```

#### Accessing Individual Characters:
```csharp
char firstChar = firstName[0];
Console.WriteLine(firstChar); // Outputs: N
```

#### Verbatim Strings:
Verbatim strings allow you to include backslashes and newlines without escaping them.
```csharp
// Escaped String
string path = "c:\\projects\\project1\\folder1";

// Verbatim String
string verbatimPath = @"c:\projects\project1\folder1";

Console.WriteLine(path);
Console.WriteLine(verbatimPath);
```

#### Common String Methods:
```csharp
string example = " Hello, World! ";

// Trim leading and trailing spaces
string trimmed = example.Trim();

// Convert to uppercase
string upperCase = example.ToUpper();

// Convert to lowercase
string lowerCase = example.ToLower();

// Check if it contains a substring
bool containsHello = example.Contains("Hello");

// Replace a substring
string replaced = example.Replace("World", "C#");

Console.WriteLine(trimmed);
Console.WriteLine(upperCase);
Console.WriteLine(lowerCase);
Console.WriteLine(containsHello);
Console.WriteLine(replaced);
```

---

Strings are versatile and crucial for any application. Use the built-in methods to manipulate them effectively and make your code more readable and maintainable.


#### Common String Methods:
- `Length`: Returns the length of the string.
- `ToUpper()`: Converts the string to uppercase.
- `ToLower()`: Converts the string to lowercase.
- `Substring()`: Extracts a substring from the string.

---

## Enums:
Enums are value types that define a set of named constants. They improve code readability and reduce the likelihood of errors by providing meaningful names for numeric values.

### Key Characteristics:
- **Type Safety:** Enums provide a way to define and work with sets of related constants in a type-safe manner.
- **Underlying Type:** By default, the underlying type of an enum is `int`, but you can specify a different integral type.

### Declaring an Enum:
```csharp
public enum DaysOfWeek {
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
```

### Using Enums:
```csharp
// Assigning an Enum Value
DaysOfWeek today = DaysOfWeek.Monday;
Console.WriteLine(today); // Outputs: Monday

// Converting Enum to Integer
int dayValue = (int)DaysOfWeek.Monday;
Console.WriteLine(dayValue); // Outputs: 1

// Converting Integer to Enum
int someDay = 4;
DaysOfWeek dayFromValue = (DaysOfWeek)someDay;
Console.WriteLine(dayFromValue); // Outputs: Thursday
```

### Practical Example:
Enums can also be used to represent methods of shipping or similar categorical data:
```csharp
public enum ShippingMethods {
    Standard = 0,
    Express = 1,
    Overnight = 2
}

class Program {
    static void Main(string[] args) {
        // Assigning an Enum Value
        var method = ShippingMethods.Express;
        Console.WriteLine(method); // Outputs: Express

        // Converting Enum to Integer
        Console.WriteLine((int)method); // Outputs: 1

        // Converting Integer to Enum
        var methodId = 1;
        Console.WriteLine((ShippingMethods)methodId); // Outputs: Express
    }
}
```

### Enum with Custom Underlying Type:
You can specify a different underlying type for an enum:
```csharp
public enum ErrorCode : byte {
    NotFound = 404,
    ServerError = 500,
    Unauthorized = 401
}

Console.WriteLine((int)ErrorCode.NotFound); // Outputs: 404
```

---

Enums are a powerful feature for creating readable, maintainable, and type-safe code. Use them to represent a collection of related constants effectively.



---

## Reference Type vs. Value Type

### Reference Types:
- Store references to the memory location of the data.
- Examples: Classes, strings, arrays.
- Modifying one reference affects all references to the object.
- You need to allocate memory your self using `new` operator.
- Memory allocated on **heap**

### Value Types:
- Store the actual data.
- Examples: Structs, enums, primitive types (e.g., `int`, `float`).
- Modifying one value does not affect others.
- Allocated on **stack**
- Memory allocation done automatically
- Immediately removed when out of scope

#### Example:
```csharp
// Value Type Example
int a = 5;
int b = a;
b = 10;
Console.WriteLine(a); // Outputs: 5

// Reference Type Example
Person person1 = new Person();
person1.Name = "John";
Person person2 = person1;
person2.Name = "Doe";
Console.WriteLine(person1.Name); // Outputs: Doe
```

---

## Conclusion
Understanding primitive and non-primitive data types is essential for writing efficient and maintainable C# applications. Use this guide as a reference to build solid and robust programs.

Happy coding! ??

