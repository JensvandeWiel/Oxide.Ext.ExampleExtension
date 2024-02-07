# Why
I wanted to make my own extension, since there are no good examples of how to make one, I decided to make one myself.

:warning: Extensions should be avoided if possible, you should use Plugins instead. Only use Extensions if you want to add extra functionality to Oxide or if its impossible to do it in an plugin.

For more in depth information about Extensions, see the Sources section.

# How to use
1. Clone this repository
2. Open the solution in Visual Studio
3. Build the solution
4. Copy the .dll from the bin/Debug folder to your RustDedicated_Data\Managed folder
5. Start your server

## ExampleExtension.cs 
This file contains the definition of a simple extension

## ./Libraries and ./Libraries/ExampleLibrary.cs
A Library is a way to expose functions to the plugins, ExampleLibrary.cs contains a simple function that adds a and b.

you can use the function in a plugin like this:
```csharp
using Oxide.Ext.ExampleExtension.Libraries.ExampleLibrary;
using Oxide.Core;
...
ExampleLibrary exampleLibrary = Interface.Oxide.GetLibrary<ExampleLibrary>();
exampleLibrary.Add(1, 2); // returns 3
``` 
same goes for Properties:
```csharp
using Oxide.Ext.ExampleExtension.Libraries.ExampleLibrary;
using Oxide.Core;
...
ExampleLibrary exampleLibrary = Interface.Oxide.GetLibrary<ExampleLibrary>();
exampleLibrary.Foo; // returns "bar"
```
# Contributing
If you want to contribute to this example/template, feel free to make a pull request or open an issue.

# Sources
- [Oxide Documentation](https://umod.org/documentation)
- [Oxide Discord Extension](https://github.com/dassjosh/Oxide.Ext.Discord)
- [Oxide Rust Extension](https://github.com/OxideMod/Oxide.Rust)
- [Oxide](https://github.com/OxideMod/Oxide.Core)