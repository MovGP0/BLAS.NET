namespace OpenBLAS;

/// <summary>
/// Represents a complex number with single-precision floating-point components.
/// </summary>
[StructLayout(LayoutKind.Explicit, Size = 8)]
public struct ComplexFloat : IEquatable<ComplexFloat>
{
    public ComplexFloat()
    {
        Real = 0;
        Imaginary = 0;
    }

    public ComplexFloat(float real, float imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    /// <summary>
    /// The real part of the complex number.
    /// </summary>
    [FieldOffset(0)]
    public float Real;

    /// <summary>
    /// The imaginary part of the complex number.
    /// </summary>
    [FieldOffset(4)]
    public float Imaginary;

    #region IEquatable

    public bool Equals(ComplexFloat other)
    {
        return Real == other.Real
               && Imaginary == other.Imaginary;
    }

    public override bool Equals(object? obj)
    {
        if (obj is ComplexFloat complexFloat)
        {
            return Equals(complexFloat);
        }
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Real, Imaginary);

    public static bool operator ==(ComplexFloat left, ComplexFloat right) => left.Equals(right);

    public static bool operator !=(ComplexFloat left, ComplexFloat right) => !(left == right);

    public override string ToString() => $"{Real} + i{Imaginary}";

    #endregion
}
