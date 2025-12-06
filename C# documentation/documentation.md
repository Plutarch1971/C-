In the Program.cs file, you'll notice the keyword namespace followed by the name of the app, CatWorx.BadgeMaker. Namespaces are used to organize and provide a level of separation in the code—something like modules in Node.js.

Think of namespaces as containers that have members. A member can be another nested namespace, a method, or a class (like in this case). After namespace CatWorx.BadgeMaker, everything inside the curly braces can be interpreted as members of that namespace.

Pro Tip

Common C# conventions are to use a company name for the root namespace in order to ensure that it is unique.

The System Namespace
On the very first line, with the using directive, we're importing a common namespace called System. Much like require or import when using modules in Node.js, in C# the using directive lets us use the corresponding namespace (System) without needing to qualify its use when using one of its members. For example, without this naming shortcut, every time Console is used, it would need to be preceded by System and a period.

The System namespace is part of the .NET framework. It is a collection of commonly used methods, data types, and data structures, which are the essential building blocks of a C# application.
## C## Namespace and using 
### The using System; 
Directive at the top allows the program to use classes from the System namespace.The using directive allows you to reference a namespace without fully qualifying its members
The using System; directive in C# allows your program to access the classes, methods, and other 
members of the System namespace without needing to fully qualify their names. The System namespace 
is a fundamental part of the .NET framework and provides many essential classes and utilities for 
building applications. Example: // Instead of writing System.Console.WriteLine,
Console.WriteLine("Hello, World!");

## Key Features of System Namespace:
Namespaces are essential for maintaining clean, organized, and scalable code, especially in larger 
projects or when integrating external libraries. They help avoid conflicts, improve readability, and 
make your codebase easier to manage.
Example: namespace ProjectA
{
    class Program { }
}

namespace ProjectB
{
    class Program { }
}
*/


##  Namespaces: 
Use a hierarchical naming structure that reflects the organization of your code.
Example: CatWorx.BadgeMaker
The namespace CatWorx.BadgeMaker defines a namespace for the application, which helps organize code and prevent naming conflicts.
In C#, namespaces are used to organize code and prevent naming conflicts. Here are some examples of namespace names that follow common conventions:

Company and Product Names: Use the company name followed by the product name.

Example: Microsoft.Office, Google.Cloud
Project and Module Names: Use the project name followed by the module or feature name.

Example: MyApp.Data, MyApp.Services
Hierarchical Structure: Use a hierarchical structure to reflect the organization of your code.

Example: CompanyName.ProjectName.ModuleName
Here are some specific examples:

For a company named "TechCorp" with a product named "BadgeMaker":
namespace TechCorp.BadgeMaker
{
    // Classes and methods go here
}

For a project named "ECommerce" with modules for "Orders" and "Customers":
namespace ECommerce.Orders
{
    // Classes and methods related to orders go here
}

namespace ECommerce.Customers
{
    // Classes and methods related to customers go here
}

For a library named "Utilities" with submodules for "IO" and "Networking":

By following these conventions, you can create clear and organized namespaces that make your code easier to navigate and maintain.

For a library named "Utilities" with submodules for "IO" and "Networking":

namespace Utilities.IO
{
    // Classes and methods related to IO go here
}

namespace Utilities.Networking
{
    // Classes and methods related to networking go here
}


By following these conventions, your code will be more readable and maintainable.

### In C# how to run another .cs file?

In C#, you can run code from another .cs file by including it in the same project and using the appropriate namespaces and classes. Here is a step-by-step guide:

Create another .cs file: Add a new C# file to your project. For example, create a file named Helper.cs.

Define a class and method in the new file:

Call the method from the new file in your Program.cs:

By following these steps, you can run code from another .cs file within your C# project. The Helper.PrintMessage() method from Helper.cs will be called and executed when you run your Program.cs.


CatWorx.BadgeMaker/Helper.cs
using System;

namespace CatWorx.BadgeMaker
{
    class Helper
    {
        public static void PrintMessage()
        {
            Console.WriteLine("Hello from Helper class!");
        }
    }
}
Call the method from the new file in your Program.cs:

// filepath: /Users/matthewmendez/bootcamp/continuation-course/badge-maker-app/CatWorx.BadgeMaker/Program.cs
// See https://aka.ms/new-console-template for more information
using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Existing code...
            double side = 3.14;
            double area = side * side;
            Console.WriteLine("Area: {0}", area);
            Console.WriteLine("Area is a {0}", area.GetType());
            //Math operations
            Console.WriteLine(2 * 3);
            Console.WriteLine(10 % 3);
            Console.WriteLine(1 + 2 * 3);
            Console.WriteLine(10 / 3.0);
            Console.WriteLine(10 / 3);
            Console.WriteLine("12" + "3");
            Console.WriteLine("================");

            //Call the method from Helper class
            Helper.PrintMessage();

            // Existing code...
            int num = 10;
            num += 100;
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);

            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice"); //output: drink
            Console.WriteLine(!isCold ? "drink" : "add ice"); //output: add ice

            Console.WriteLine("Data Conversion");
            Console.WriteLine("================");
            string stringNum = "2";
            int intNum = Convert.ToInt32(stringNum);
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());
        }
    }
}
By following these steps, you can run code from another .cs file within your C# project. The Helper.PrintMessage() method from Helper.cs will be called and executed when you run your Program.cs.
## What is the naming conventions for namespace in C#?
In C#, the naming conventions for an application typically follow the guidelines set by the .NET framework. Here are some key points:

PascalCase: Use PascalCase for class names, method names, and namespaces. Each word in the name starts with an uppercase letter.

Example: CatWorx.BadgeMaker, Program, Main
camelCase: Use camelCase for local variables and method parameters. The first word starts with a lowercase letter, and each subsequent word starts with an uppercase letter.

Example: side, area, args
Constants: Use PascalCase for constants.

Example: const double Pi = 3.14;
File Names: Match the file name with the class name it contains.

Example: Program.cs for the Program class.

