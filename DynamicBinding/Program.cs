using System;

namespace DynamicBinding // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            //obj.GethashCode()

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);
        }
    }
}


/*
 
Programming languages are divided into two types —

statically-typed languages and dynamically-typed languages.

Or in short, we can say static languages or dynamic languages.

Examples of static languages are C# and Java.

Dynamic languages are like Ruby,

Javascript, Python, and so on.



Type Resolution


But what's the difference?

The difference is in static languages — resolution of types,

members, properties, methods is done at compile-time.

So if we try to access a method that is not defined in an object,

when we compile the application,

we are getting an immediate feedback that's telling us

that method or property is not found on that object.

With dynamic languages — the resolution of types,

properties, members, methods is done at run-time.

But what's the benefit of that?


- dynamic languages are a little bit easier and faster to write code with.

Without dynamics, you have to use reflection.

What is reflection?

Reflection is a way to inspect the metadata about the type,

and access properties and methods.

 */