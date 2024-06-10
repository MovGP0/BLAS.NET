namespace OpenBLAS;

/// <summary>
/// Specifies the data ordering of a matrix.
/// </summary>
[EnumExtensions]
public enum Order
{
    /// <summary>
    /// Indicates row-major order (C-style).
    /// </summary>
    RowMajor = 101,

    /// <summary>
    /// Indicates column-major order (Fortran-style).
    /// </summary>
    ColMajor = 102
}
