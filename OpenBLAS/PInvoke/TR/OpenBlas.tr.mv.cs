namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs a single-precision triangular matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="a">Pointer to the triangular matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "strmv")]
    internal static extern void S_tr_mv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, float* a, int* lda, float* x, int* incX);

    /// <summary>
    /// Performs a double-precision triangular matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="a">Pointer to the triangular matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtrmv")]
    internal static extern void D_tr_mv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, double* a, int* lda, double* x, int* incX);

    /// <summary>
    /// Performs a single-precision complex triangular matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="a">Pointer to the triangular matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctrmv")]
    internal static extern void C_tr_mv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexFloat* a, int* lda, ComplexFloat* x, int* incX);

    /// <summary>
    /// Performs a double-precision complex triangular matrix-vector multiplication.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="a">Pointer to the triangular matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the vector to be multiplied.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztrmv")]
    internal static extern void Z_tr_mv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexDouble* a, int* lda, ComplexDouble* x, int* incX);
}
