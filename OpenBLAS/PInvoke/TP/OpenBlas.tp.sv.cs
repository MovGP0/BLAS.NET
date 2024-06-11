namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Solves a single-precision triangular packed system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "stpsv")]
    internal static extern void Stpsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, float* ap, float* x, int* incX);

    /// <summary>
    /// Solves a double-precision triangular packed system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtpsv")]
    internal static extern void Dtpsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, double* ap, double* x, int* incX);

    /// <summary>
    /// Solves a single-precision complex triangular packed system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctpsv")]
    internal static extern void Ctpsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexFloat* ap, ComplexFloat* x, int* incX);

    /// <summary>
    /// Solves a double-precision complex triangular packed system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztpsv")]
    internal static extern void Ztpsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexDouble* ap, ComplexDouble* x, int* incX);
}
