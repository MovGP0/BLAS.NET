namespace OpenBLAS;

/// <summary>
/// Specifies whether a matrix is unit triangular or non-unit triangular.
/// </summary>
[EnumExtensions]
public enum Diag
{
    /// <summary>
    /// Indicates a non-unit triangular matrix.
    /// </summary>
    NonUnit = 131,

    /// <summary>
    /// Indicates a unit triangular matrix.
    /// </summary>
    Unit = 132
}
