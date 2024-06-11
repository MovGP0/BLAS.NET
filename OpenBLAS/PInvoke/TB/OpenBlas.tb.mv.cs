namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs a single-precision triangular band matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "stbmv")]
    internal static extern void Stbmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, float* a, int* lda, float* x, int* incX);

    /// <summary>
    /// Performs a double-precision triangular band matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtbmv")]
    internal static extern void Dtbmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, double* a, int* lda, double* x, int* incX);

    /// <summary>
    /// Performs a single-precision complex triangular band matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctbmv")]
    internal static extern void Ctbmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, ComplexFloat* a, int* lda, ComplexFloat* x, int* incX);

    /// <summary>
    /// Performs a double-precision complex triangular band matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztbmv")]
    internal static extern void Ztbmv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, ComplexDouble* a, int* lda, ComplexDouble* x, int* incX);
}
