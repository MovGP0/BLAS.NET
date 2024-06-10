namespace OpenBLAS;

/// <summary>
/// Specifies how a matrix should be transposed in an operation.
/// </summary>
[EnumExtensions]
public enum Transpose
{
    /// <summary>
    /// Indicates no transposition.
    /// </summary>
    NoTransposition = 111,

    /// <summary>
    /// Indicates transposition.
    /// </summary>
    Transposition = 112,

    /// <summary>
    /// Indicates conjugate transposition.
    /// </summary>
    ConjugateTransposition = 113,

    /// <summary>
    /// Indicates conjugate but no transposition.
    /// </summary>
    ConjugateNoTransposition = 114
}
