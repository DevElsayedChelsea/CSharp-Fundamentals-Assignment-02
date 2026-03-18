namespace CSharp_Fundamentals_Assignment_02
{
    internal class Program
    {
        // static field for variable lifetime demonstration
        static int test;

        // Class-level field for scope demonstrations
        static int classField = 100;

        static int shadowingVariable = 5; // This variable will be used to demonstrate variable shadowing
        static void Main(string[] args)
        {
            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example

            // The following code demonstrates the use of #region and #endregion directives to organize code into collapsible sections.
            #region Region Example

            /*
              #region and #endregion are preprocessor directives in C# used to group
               a block of code into a collapsible section inside the code editor
               such as Visual Studio.

               They help developers organize large code files by allowing them to
               hide or expand specific parts of the code. This makes the code easier
               to read, navigate, and maintain, especially in large projects.   

             */

            // Console.WriteLine("\n" + new string('-', 70) + "\n");


            #endregion


            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════


            // EXPLICIT DECLARATION 
            //string Name = "Chelsea"; // Explicitly declaring a variable of type string and assigning it the value "Chelsea"
            //int Age = 25; // Explicitly declaring a variable of type int and assigning it the value 25


            //Console.WriteLine($"My Name Is: {Name.GetType()} And My Age Is: {Age.GetType()}");



            // IMPLICIT DECLARATION 
            //var City = " Mansoura"; // Implicitly declaring a variable using the 'var' keyword, where the type is inferred from the assigned value
            //Console.WriteLine(City.GetType());

            #endregion

            #region Question 3: Constants

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════



            // Constant examples
            // A constant is a variable whose value cannot be changed after it has been assigned.
            // const double Pi = 3.14159;
            // Console.WriteLine($"The value of Pi is: {Pi}");
            // Pi = 3.14; // This will cause a compile-time error because Pi is a constant and cannot be reassigned.
            // Constants are used to represent fixed values that should not change throughout the program, improving code readability and maintainability.

            #endregion

            #region Question 4: Class-level vs Method-level Scope

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════

            /*
                Class-Level Scope:
                A variable declared at the class level (inside the class but outside any method).
                It can be accessed by all methods inside the same class.

                Method-Level Scope:
                A variable declared inside a method.
                It can only be accessed within that method and cannot be used outside it.
            */

            // classField = 100; // This variable has class-level scope and can be accessed by any method in the class
            // 
            // Console.WriteLine(classField); // Accessing the class-level variable from the Main method
            // 
            // // Method-level variable example
            // int MethodVariable = 200; // This variable has method-level scope and can only be accessed within the Main method


            #endregion

            #region Question 5: Block-level Scope

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════

            // Block-level scope refers to the visibility and accessibility of variables within a specific block of code, such as within curly braces {}. Variables declared within a block are only accessible within that block and cannot be accessed outside of it.

            // {
            // 
            //     // This variable is only accessible within this block
            //     int blockVariable = 50;
            //     Console.WriteLine(blockVariable);
            // 
            // 
            // }
            // 
            //  Console.WriteLine(blockVariable); // This will cause a compile-time error because blockVariable is not accessible outside the block

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════

            // Variable lifetime refers to the duration for which a variable exists in memory during the execution of a program.
            // test = 10;
            // Console.WriteLine(test);

            // Local variables are created when a method is called and destroyed when the method exits. They are only accessible within the method they are declared in.

            #endregion

            #region #region Question 7: Garbage Collector

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════

            // The Garbage Collector (GC) in C# is an automatic memory management system that handles the allocation and deallocation of memory for objects. It periodically checks for objects that are no longer referenced by the program and frees up the memory they occupy. This means that developers do not need to manually manage memory, reducing the risk of memory leaks and other related issues. The GC affects the lifetime of objects by determining when they are eligible for collection based on their references, allowing for efficient memory usage in C# applications.
            // In C#, the GC runs on a separate thread and uses a generational approach to optimize performance, categorizing objects into generations based on their lifespan. Objects that survive multiple GC cycles are promoted to older generations, which are collected less frequently, improving overall efficiency.
            // The GC also provides features like finalization and the IDisposable interface for managing resources that require explicit cleanup, such as file handles or database connections, ensuring that resources are released properly even if exceptions occur.
            // Overall, the Garbage Collector is a crucial component of C# that simplifies memory management and helps maintain application performance and stability by automatically handling the lifecycle of objects in memory.
            // The GC operates in three main phases: marking, where it identifies which objects are still in use; sweeping, where it frees the memory of unreferenced objects; and compacting, where it rearranges the remaining objects to reduce fragmentation and optimize memory usage. This process allows C# applications to manage memory efficiently without requiring developers to manually allocate and deallocate memory, thus reducing the likelihood of memory-related errors and improving application performance.
            // Additionally, the GC in C# is non-deterministic, meaning that it runs at unpredictable times based on the application's memory usage and system resources. Developers can trigger garbage collection manually using the GC.Collect() method, but it is generally recommended to let the GC manage memory automatically for optimal performance.
            // In summary, the Garbage Collector in C# is an essential feature that automates memory management, allowing developers to focus on writing code without worrying about memory leaks or manual cleanup. It ensures that memory is used efficiently and helps maintain the stability and performance of C# applications by automatically handling the lifecycle of objects in memory.



            /*

             The Garbage Collector (GC) in C# is responsible for automatic memory management. 
             It removes objects that are no longer referenced by the program.

             The lifetime of an object depends on its references. As long as an object is referenced, 
             it remains in memory. When it is no longer referenced, 
             it becomes eligible for garbage collection, 
             and the GC removes it at an unspecified time.


             */


            #endregion

            #region #region Question 8: Variable Shadowing

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════


            /*

             Variable shadowing occurs when a variable declared within a certain scope (e.g., a method or block) has the same name as a variable declared in an outer scope In C#,
             variable shadowing is allowed, and it can occur in nested blocks within the same method. When this happens, the inner variable "shadows" the outer variable, 
             meaning that within the inner block, references to that variable name will refer to the inner variable rather than the outer one.

             */

            //int shadowingVariable = 10; // This variable shadows the class-level variable with the same name

            //// The following line will access the local variable, not the class-level variable, because of variable shadowing
            //Console.WriteLine(shadowingVariable); // 10

            //// To access the class-level variable, we can use the class name to qualify it
            //Console.WriteLine(Program.shadowingVariable); // 5


            #endregion

            #region Question 9: C# Naming Rules

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════



            //int myVariable; // 1. Variable names must start with a letter or an underscore.

            //string _myVariable; // 2. Variable names can contain letters, digits, and underscores.

            //string[] MyVariables; // 3. Variable names cannot contain spaces or special characters.

            #endregion

            #region Question 10: Naming Conventions

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════



            // (a)local variables; 
            // Local variables should be named using camelCase, where the first letter is lowercase and subsequent words are capitalized. For example: int myVariable;


            // (b) class names; 
            // Class names should be named using PascalCase, where the first letter of each word is capitalized. For example: public class MyClass { }

            // (c) constants; // using PascalCase


            #endregion

            #region Question 11: Error Types

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════


            // Syntax Errors: These occur when the code violates the rules of the C# language. They are detected at compile time and prevent the program from running. Example: Missing a semicolon at the end of a statement.
            // int x = 10 // Syntax error: missing semicolon
            // Console.WriteLine(x); // This line will not compile due to the syntax error above.


            // Runtime Errors: These occur during the execution of the program and can cause it to crash. They are often caused by invalid operations, such as dividing by zero or accessing an array out of bounds. Example: int y = 10 / 0; // This will cause a runtime error (divide by zero).
            // int y = 10;
            // int z = 0;
            // int result = y / z; // This will cause a runtime error (divide by zero).
            // Console.WriteLine(result); // This line will not execute due to the runtime error above.

            // Logical Errors: These occur when the program runs without crashing but produces incorrect results. They are often caused by mistakes in the logic of the code. Example: Using the wrong operator in a calculation.
            // int a = 5;
            // int b = 10;
            // Console.WriteLine(a - b); // This will produce an incorrect result (should be a + b) due to a logical error in the code.



            #endregion

            #region Question 12: Exception Handling Importance

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════


            /*
             Exception handling is important because it prevents program crashes and allows handling errors in a controlled way.
             Without it, the program may crash, stop execution, and show unclear error messages to the user.
             */

            #endregion

            #region Question 13: try-catch-finally

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════


            //try // The try block contains code that may throw an exception. If an exception occurs, the control is transferred to the catch block.
            //{
            //    int x = 10;
            //    int y = 0;
            //    int result = x / y; // Runtime Error
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex) // The catch block handles the specific exception (DivideByZeroException) that may occur in the try block. It allows you to respond to the error gracefully, such as by logging it or showing a user-friendly message.
            //{
            //    Console.WriteLine("Cannot divide by zero!");
            //}
            //finally // The finally block executes regardless of whether an exception was thrown or caught. It is typically used for cleanup code, such as closing files or releasing resources, ensuring that necessary actions are performed even if an error occurs.
            //{
            //    Console.WriteLine("This block always executes.");
            //}


            #endregion

            #region Question 14: Common Built-in Exceptions

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ═════════════════════════════════════════════════════════════════════

            // 1. NullReferenceException: This exception occurs when you try to access a member of an object that is null. For example, if you have a string variable that is null and you try to call a method on it, you will get a NullReferenceException.
            // 2. IndexOutOfRangeException: This exception occurs when you try to access an index that is outside the bounds of an array or collection. For example, if you have an array of size 5 and you try to access the element at index 10, you will get an IndexOutOfRangeException.
            // 3. DivideByZeroException: This exception occurs when you try to divide a number by zero. For example, if you have an integer variable and you try to divide it by zero, you will get a DivideByZeroException.
            // 4. FormatException: This exception occurs when you try to convert a string to a different data type and the format of the string is invalid. For example, if you try to convert the string "abc" to an integer, you will get a FormatException.
            // 5. InvalidOperationException: This exception occurs when a method call is invalid for the object's current state. For example, if you try to read from a closed file stream, you will get an InvalidOperationException.



            #endregion

            #region Question 15: Multiple catch Blocks

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════


            // Example of incorrect order 
            // try
            // {
            //     int x = 10 / 0; // This will throw a DivideByZeroException
            // }
            // catch (Exception ex) // This catch block will catch all exceptions, including DivideByZeroException, which means that the specific catch block for DivideByZeroException will never be reached.
            // {
            //     Console.WriteLine("General error");
            // }
            // catch (DivideByZeroException ex) // This catch block will never be reached because the general Exception catch block will handle all exceptions, including DivideByZeroException.
            // {
            //     Console.WriteLine("Divide by zero");
            // }

            // Example of correct order
            //try
            //{
            //    int x = 10 / 0; // This will throw a DivideByZeroException, which will be caught by the specific catch block for DivideByZeroException.
            //}
            //catch (DivideByZeroException ex) // This catch block will catch the specific DivideByZeroException first, allowing for more specific error handling.
            //{
            //    Console.WriteLine("Divide by zero");
            //}
            //catch (Exception ex) // This catch block will catch any other exceptions that are not caught by the previous catch block, providing a general error handling mechanism.
            //{
            //    Console.WriteLine("General error");
            //}


            /*
             The order of catch blocks is important because C# checks them from top to bottom. Specific exceptions must come before general ones, 
             otherwise the specific catch blocks will never be reached.

             */

            #endregion

            #region Question 16: throw Keyword

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════

            // Trhow: This keyword is used to re-throw the current exception while preserving the original stack trace. It allows
            //try
            //{
            //    int x = 10 / 0;
            //}
            //catch (Exception ex)
            //{
            //    throw;  // This will re-throw the exception while preserving the original stack trace, allowing for better debugging and error tracking.
            //}


            //// Throw ex: This syntax is used to re-throw an exception but it resets the stack trace to the point where the exception is re-thrown, which can make it harder to debug and track the original source of the error.
            //try
            //{
            //    int x = 10 / 0;
            //}
            //catch (Exception ex)
            //{
            //    throw ex; // This will re-throw the exception but it resets the stack trace to the point where the exception is re-thrown, which can make it harder to debug and track the original source of the error.
            //}



            #endregion

            #region Question 17: Stack and Heap Memory

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════


            // STACK : It is a region in memory that is organized and structured.It stores data types whose size is known at compile time like a box

            // HEAP : It is a region in memory where data is stored in an unstructured and dynamic way. It is used for objects and data whose size may not be known in advance like a barrel

            #endregion

            #region Question 18: Value Types vs Reference Types

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════

            // Value Types Example
            // Value Types: Value types are data types such as struct and enum
            // Their size is known at compile time and they are stored directly in the Stack memory

            //int X;
            //// CLR Will Allocate 4 Uninitialized Bytes For The Variable X In The Stack Memory
            //X = 5;

            //int Y = X;

            //X++;

            //Console.WriteLine(X); //Output: 6 
            //Console.WriteLine(Y); // Output: 5 (Y is a copy of X, so it remains unchanged when X is modified)



            // Reference Types Example
            // Reference Types: Reference types include string, class, object, array, and delegate Their size is not fixed or may vary They are stored in both Stack and Heap:
            // The reference(address) of the variable is stored in the Stack
            // The actual data(value) is stored in the Heap

            //Point P01 = new Point(); // A new Point object is created in the Heap, and P01 holds a reference to it in the Stack

            //Point P02 = new Point(); // A new Point object is created in the Heap, and P02 holds a reference to it in the Stack

            //P01.X = 10;
            //P01.Y = 50;

            //P02 = P01; // P02 now references the same Point object as P01, so both P01 and P02 point to the same object in the Heap

            //Console.WriteLine($"Point P02.X: {P02.X}"); // Output: 10 (P02 references the same object as P01, so it reflects the changes made to P01)
            //Console.WriteLine($"Point P02.Y: {P02.Y}"); // Output: 50 (P02 references the same object as P01, so it reflects the changes made to P01)

            //Console.WriteLine("=============="); // Separator for clarity

            //Console.WriteLine($"Point P02.X: {P01.X}"); // Output: 10 (P01 and P02 reference the same object, so changes to P01 are reflected in P02)
            //Console.WriteLine($"Point P02.Y: {P02.Y}"); // Output: 50 (P01 and P02 reference the same object, so changes to P01 are reflected in P02)


            #endregion

            #region Question 19: Object in C#

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // ══════════════════════════════════════════════════════════════════════

            // In C#, object is considered the base type of all types because all types value types and reference types ultimately derive from System.Object
            // This means that every type in C# inherits common functionality defined in object


            // Methods inherited from System.Object:

            // Every type in C# inherits these common methods:
            // ToString() → Returns a string representation of the object
            // Equals() → Compares two objects for equality
            // GetHashCode() → Returns a hash code for the object
            // GetType() → Returns the type of the object
            // Finalize() → Used for cleanup before garbage collection
            // MemberwiseClone() → Creates a shallow copy of the object

            #endregion

        }

        // Test Method 
        //void TestMethod()
        //{
        //    Console.WriteLine(MethodVariable); // This will cause a compile-time error because MethodVariable is not accessible outside the Main method
        //}

    }
}
