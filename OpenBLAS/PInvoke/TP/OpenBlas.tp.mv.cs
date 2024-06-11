namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs a single-precision triangular packed matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "stpmv")]
    internal static extern void Stpmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, float* ap, float* x, int* incX);

    /// <summary>
    /// Performs a double-precision triangular packed matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtpmv")]
    internal static extern void Dtpmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, double* ap, double* x, int* incX);

    /// <summary>
    /// Performs a single-precision complex triangular packed matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctpmv")]
    internal static extern void Ctpmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexFloat* ap, ComplexFloat* x, int* incX);

    /// <summary>
    /// Performs a double-precision complex triangular packed matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="ap">Pointer to the packed triangular matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztpmv")]
    internal static extern void Ztpmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexDouble* ap, ComplexDouble* x, int* incX);
}
