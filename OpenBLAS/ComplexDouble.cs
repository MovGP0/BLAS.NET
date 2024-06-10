namespace OpenBLAS;

/// <summary>
/// Represents a complex number with double-precision components.
/// </summary>
[StructLayout(LayoutKind.Explicit, Size = 16)]
public struct ComplexDouble
{
    public ComplexDouble()
    {
        Real = 0;
        Imaginary = 0;
    }

    public ComplexDouble(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    /// <summary>
    /// The real part of the complex number.
    /// </summary>
    [FieldOffset(0)]
    public double Real;

    /// <summary>
    /// The imaginary part of the complex number.
    /// </summary>
    [FieldOffset(8)]
    public double Imaginary;
}
