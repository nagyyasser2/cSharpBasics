# Working with Files in C#

This guide provides an overview of handling files, directories, and paths in C#. Learn to manage file operations and navigate the file system efficiently.

---

## Table of Contents
- [File Operations](#file-operations)
  - [Reading Files](#reading-files)
  - [Writing Files](#writing-files)
  - [Appending to Files](#appending-to-files)
  - [Checking File Existence](#checking-file-existence)
- [Directory Operations](#directory-operations)
  - [Creating Directories](#creating-directories)
  - [Listing Files and Directories](#listing-files-and-directories)
  - [Deleting Directories](#deleting-directories)
- [Working with Paths](#working-with-paths)
  - [Combining Paths](#combining-paths)
  - [Getting File Information](#getting-file-information)
  - [Handling Relative and Absolute Paths](#handling-relative-and-absolute-paths)

---

## File Operations

### Reading Files
```csharp
string content = File.ReadAllText("example.txt");
Console.WriteLine(content);

// Reading lines
string[] lines = File.ReadAllLines("example.txt");
foreach (var line in lines) {
    Console.WriteLine(line);
}
```

### Writing Files
```csharp
string content = "Hello, World!";
File.WriteAllText("example.txt", content);
```

### Appending to Files
```csharp
string additionalContent = "Append this text.";
File.AppendAllText("example.txt", additionalContent);
```

### Checking File Existence
```csharp
if (File.Exists("example.txt")) {
    Console.WriteLine("File exists.");
} else {
    Console.WriteLine("File does not exist.");
}
```

---

## Directory Operations

### Creating Directories
```csharp
string directoryPath = "exampleDirectory";
if (!Directory.Exists(directoryPath)) {
    Directory.CreateDirectory(directoryPath);
}
```

### Listing Files and Directories
```csharp
string[] files = Directory.GetFiles("exampleDirectory");
string[] directories = Directory.GetDirectories("exampleDirectory");

foreach (var file in files) {
    Console.WriteLine(file);
}

foreach (var directory in directories) {
    Console.WriteLine(directory);
}
```

### Deleting Directories
```csharp
if (Directory.Exists("exampleDirectory")) {
    Directory.Delete("exampleDirectory", true); // true for recursive deletion
}
```

---

## Working with Paths

### Combining Paths
```csharp
string basePath = "C:\\Users\\Example";
string fileName = "document.txt";
string fullPath = Path.Combine(basePath, fileName);
Console.WriteLine(fullPath);
```

### Getting File Information
```csharp
string filePath = "example.txt";
string directoryName = Path.GetDirectoryName(filePath);
string fileName = Path.GetFileName(filePath);
string extension = Path.GetExtension(filePath);

Console.WriteLine($"Directory: {directoryName}");
Console.WriteLine($"File Name: {fileName}");
Console.WriteLine($"Extension: {extension}");
```

### Handling Relative and Absolute Paths
```csharp
string relativePath = "..\\example\\file.txt";
string absolutePath = Path.GetFullPath(relativePath);
Console.WriteLine($"Absolute Path: {absolutePath}");
```

---

By leveraging these features, you can efficiently handle files, directories, and paths in your C# applications.

