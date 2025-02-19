using LibraryOfClasses;
using System;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

class Program
{
    // Reflection in C# is a powerful feature that allows programs to inspect and manipulate metadata,
    // types, and objects at runtime. It is part of the System.Reflection namespace and is commonly
    // used for dynamic type discovery, late binding, and accessing private members.
    //Reflection is useful when:
    // - A) You need to inspect an assembly, module, or type at runtime.
    // - B) You want to create objects or invoke methods dynamically without knowing their types at compile time.
    // - C) You need to access private or non-public members for debugging or testing.
    // - D) You are working with attributes and need to retrieve metadata about them.

    static void Main()
    {   // A) Inspect an assembly, module, or type at runtime
        //Getting Type Info:
        //Type type = typeof(string);
        Type type = typeof(Animal);
        Console.WriteLine("Type Name: " + type.Name);
        Console.WriteLine("Namespace: " + type.Namespace);

        // List all methods
        MethodInfo[] methods = type.GetMethods();
        foreach (var m in methods)
        {
            Console.WriteLine(m.Name);
        }

        Console.WriteLine("************************************");
        // B) Create objects or invoke methods dynamically without knowing their types at compile time.
        type = typeof(Person);

        // Create an instance using reflection
        object obj = Activator.CreateInstance(type, "John Doe");

        // Invoke method using reflection
        MethodInfo method = type.GetMethod("Greet");
        method.Invoke(obj, null);

        Console.WriteLine("************************************");
        // C) Access private or non-public members for debugging or testing.
        // OPTION 1 - Use private method located in another assembly's internal class
        //by using [assembly: InternalsVisibleTo("AssemblyName")] attribute
        //Secret ob = new Secret();
        //Type t = ob.GetType();

        //// Access private field
        //FieldInfo field = t.GetField("secretMessage", BindingFlags.NonPublic | BindingFlags.Instance);
        //string value = (string)field.GetValue(ob);
        //Console.WriteLine(value);

        //OPTION 2 - Use Reflection with Non-Public Binding Flags
        // Load the external assembly dynamically
        Assembly targetAssembly = Assembly.Load("LibraryOfClasses");

        // Get the type of the internal class
        Type secretType = targetAssembly.GetType("LibraryOfClasses.Secret", throwOnError: true);

        // Create an instance of the internal class
        object secretInstance = Activator.CreateInstance(secretType, true);

        // Get the private method
        MethodInfo hiddenMethod = secretType.GetMethod("HiddenMethod", BindingFlags.NonPublic | BindingFlags.Instance);
        // Invoke the private method
        string result = (string)hiddenMethod.Invoke(secretInstance, null);
        Console.WriteLine(result);
        

        //Get the content of the secret field
        FieldInfo field = secretType.GetField("secretMessage", BindingFlags.NonPublic | BindingFlags.Instance);
        string value = (string)field.GetValue(secretInstance);
        Console.WriteLine(value);

        Console.WriteLine("************************************");
        // D) Work with attributes and need to retrieve metadata about them.
        type = typeof(Animal);
        object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), false);

        foreach (MyAttribute attr in attributes)
        {
            Console.WriteLine("Attribute Info: " + attr.Info);
        }
    }

}

