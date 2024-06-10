namespace OpenBLAS;

/// <summary>
/// Specifies which part of a matrix is being referenced.
/// </summary>
[EnumExtensions]
public enum MatrixPart
{
    /// <summary>
    /// Indicates the upper part of a matrix.
    /// </summary>
    Upper = 121,

    /// <summary>
    /// Indicates the lower part of a matrix.
    /// </summary>
    Lower = 122
}
