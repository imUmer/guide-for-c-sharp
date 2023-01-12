# guide-for-c-sharp
# Let start the journey in building the knowledge with C# and .NET framework technologies

## Short Introduction

C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft. It is a statically-typed language, which means that variables must be declared with a specific data type (such as int, string, or bool) before they can be used. C# is commonly used for building Windows desktop applications, mobile apps, web applications, games and more.

One of the key features of C# is its use of the Common Language Runtime (CLR) which is responsible for managing the execution of C# programs. The CLR provides services such as memory management, exception handling, and security.

C# code is written using an Integrated Development Environment (IDE) such as Visual Studio, which provides a wide range of tools to help with development, including a code editor, a debugger, and a visual designer for building user interfaces.

C# also supports a variety of programming paradigms such as Object-Oriented Programming (OOP), Functional Programming and Event-driven programming. It has a large and active community, and a wide range of third-party libraries and frameworks are available to help developers with tasks such as data access, networking, and user interface development.

Overall, C# is a versatile and powerful programming language, and it's widely used in a variety of fields, such as enterprise software development, game development, and web development.

## Numbers in c#

In C#, there are several built-in data types for representing numbers:

int: Represents a 32-bit signed integer. It can hold values between -2,147,483,648 and 2,147,483,647.
long: Represents a 64-bit signed integer. It can hold values between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807.
float: Represents a single-precision floating-point number. It can hold values with up to 7 decimal digits of precision.
double: Represents a double-precision floating-point number. It can hold values with up to 15 decimal digits of precision.
decimal: Represents a high-precision decimal number. It can hold values with up to 28 decimal digits of precision.
In addition to these data types, C# also provides several other numeric data types such as byte, short, uint, ulong, sbyte and ushort.

C# also provides a System.Numerics namespace that includes additional types for working with large numbers and complex numbers, such as BigInteger and Complex.

You can perform arithmetic operations on numbers using the standard operators such as +, -, *, / and %. C# also provides many built-in mathematical functions such as Math.Abs(), Math.Round() and Math.Pow() to perform mathematical operations on numbers.

It's important to keep in mind that while C# provides several built-in data types for representing numbers, you should choose the data type that best fits the range of values you expect your numbers to have and the precision you need for your specific use case.

# Branching 

In C#, branching statements are used to control the flow of a program's execution. There are several branching statements available in C#, including:

if: The if statement is used to test a condition, and if that condition is true, the code block following the condition is executed.

```
if (condition) {
    // code to execute if condition is true
}

```
