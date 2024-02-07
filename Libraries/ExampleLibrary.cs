using Oxide.Core.Libraries;

namespace Oxide.Ext.ExampleExtension.Libraries
{
    public class ExampleLibrary: Library
    {
        [LibraryFunction(nameof(Add))]
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        [LibraryProperty(nameof(Foo))]
        public string Foo => "Bar";
    }
}