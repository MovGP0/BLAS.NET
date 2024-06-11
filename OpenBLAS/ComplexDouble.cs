namespace OpenBLAS;

/// <summary>
/// Represents a complex number with double-precision components.
/// </summary>
[StructLayout(LayoutKind.Explicit, Size = 16)]
public struct ComplexDouble : IEquatable<ComplexDouble>
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

    #region IEquatable

    public bool Equals(ComplexDouble other)
    {
        return Real == other.Real
               && Imaginary == other.Imaginary;
    }

    public override bool Equals(object? obj)
    {
        if (obj is ComplexDouble complexFloat)
        {
            return Equals(complexFloat);
        }
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Real, Imaginary);

    public static bool operator ==(ComplexDouble left, ComplexDouble right) => left.Equals(right);

    public static bool operator !=(ComplexDouble left, ComplexDouble right) => !(left == right);

    public override string ToString() => $"{Real} + i{Imaginary}";

    #endregion
}
