# Primitive Data Types

This document serves as a comprehensive guide to primitive data types, covering key concepts and best practices.

---

## Table of Content
- [Variables & Constants](#variables--constants)
- [Overflowing](#overflowing)
- [Scope](#scope)
- [Type Conversion](#type-conversion)
- [Operators](#operators)
- [Comments](#comments)

---

## Variables & Constants

### **Variable**
A name given to a storage location in memory, used to hold data that can change during the execution of a program.

### **Constant**
An immutable value, meaning it cannot be changed after initialization.

### **Declaring a Variable**
```csharp
int number;
int number = 1;

const float Pi = 3.14f;
```

> **[!NOTE]**  
> You can't use a variable unless you initialize it.

### **Naming Conventions**
- **Camel Case**: Example: `firstName`  
  Typically used for local variables and method arguments.
- **Pascal Case**: Example: `FirstName`  
  Typically used for method names, properties, and constants.
- **Hungarian Notation**: Example: `strFirstName`  
  Prefixes represent the type (e.g., `str` for string).

> **[!TIP]**  
> For local variables, use **Camel Case**. For constants, use **Pascal Case**.

### **Primitive Types**
![Primitive Types](https://i.ytimg.com/vi/Yvq1gua8SC4/maxresdefault.jpg)

---

## Overflowing
Overflow occurs when a value exceeds the storage capacity of its data type.

### Example
```csharp
byte b = 255;
b += 1; // Overflow: b will now wrap around to 0.
```

### Handling Overflow
To handle overflow explicitly, use the `checked` keyword:
```csharp
checked
{
    byte b = 255;
    b += 1; // Will throw an exception.
}
```

---

## Scope
Scope defines the visibility and lifetime of a variable in your program.

### Types of Scope:
1. **Block Scope**: Variables declared inside `{}` are only accessible within those braces.
2. **Function Scope**: Variables declared inside a function are only accessible within that function.
3. **Global Scope**: Variables declared outside of functions or classes are accessible throughout the program.

### Example:
```csharp
{
    int x = 10; // Block-scoped
    Console.WriteLine(x); // Accessible here
}
// Console.WriteLine(x); // Not accessible here
```

---

## Type Conversion
Type conversion refers to converting a value from one type to another.

### Implicit Conversion
Performed automatically when there is no risk of data loss:
```csharp
int i = 42;
float f = i; // Implicit conversion
```

### Explicit Conversion (Casting)
Requires a cast operator:
```csharp
double d = 3.14;
int i = (int)d; // Explicit conversion
```

### Conversion Methods
- `Convert.ToInt32(value)`
- `int.Parse(value)`
- `TryParse` for safe conversion:
```csharp
int result;
bool success = int.TryParse("123", out result);
```

---

## Operators
Operators perform operations on variables and values.

### Arithmetic Operators
- `+` Addition
- `-` Subtraction
- `*` Multiplication
- `/` Division
- `%` Modulus

### Comparison Operators
- `==` Equal to
- `!=` Not equal to
- `>` Greater than
- `<` Less than
- `>=` Greater than or equal to
- `<=` Less than or equal to

### Logical Operators
- `&&` Logical AND
- `||` Logical OR
- `!` Logical NOT

### Assignment Operators
- `=` Assign
- `+=` Add and assign
- `-=` Subtract and assign
- `*=` Multiply and assign
- `/=` Divide and assign

### Example:
```csharp
int a = 10, b = 20;
int sum = a + b;
bool isGreater = a > b;
```

---

## Comments
Comments are used to improve code readability and explain logic. They are ignored by the compiler.

### Single-Line Comment
```csharp
// This is a single-line comment.
```

### Multi-Line Comment
```csharp
/*
 This is a
 multi-line comment.
*/
```

### XML Documentation Comments
Used to generate documentation for your code:
```csharp
/// <summary>
/// This method adds two numbers.
/// </summary>
public int Add(int a, int b)
{
    return a + b;
}
```

---

By following these principles and guidelines, you can write clear and efficient code using primitive data types.

