namespace OpenBLAS.Tests;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class TestOfAttribute : Attribute
{
    public string Name { get; }

    public TestOfAttribute(string name) => Name = name;
}