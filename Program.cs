using System.Runtime.InteropServices;

IFoo obj = new IFoo();
obj.SayHello();


[ComImport, CoClass(typeof(Foo))]
[Guid("00000000-0000-0000-0000-000123456789")]
interface IFoo
{
    void SayHello();
}

class Foo : IFoo
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}
