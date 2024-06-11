namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs a single-precision triangular matrix-matrix multiplication.
    /// </summary>
    /// <param name="side">Pointer to specify whether the matrix is on the left ('L') or right ('R') side.</param>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="a">Pointer to the triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "strmm")]
    internal static extern void S_tr_mm(sbyte* side, sbyte* uplo, sbyte* trans, sbyte* diag, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb);

    /// <summary>
    /// Performs a double-precision triangular matrix-matrix multiplication.
    /// </summary>
    /// <param name="side">Pointer to specify whether the matrix is on the left ('L') or right ('R') side.</param>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="a">Pointer to the triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtrmm")]
    internal static extern void D_tr_mm(sbyte* side, sbyte* uplo, sbyte* trans, sbyte* diag, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb);

    /// <summary>
    /// Performs a single-precision complex triangular matrix-matrix multiplication.
    /// </summary>
    /// <param name="side">Pointer to specify whether the matrix is on the left ('L') or right ('R') side.</param>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="a">Pointer to the triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctrmm")]
    internal static extern void C_tr_mm(sbyte* side, sbyte* uplo, sbyte* trans, sbyte* diag, int* m, int* n, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* b, int* ldb);

    /// <summary>
    /// Performs a double-precision complex triangular matrix-matrix multiplication.
    /// </summary>
    /// <param name="side">Pointer to specify whether the matrix is on the left ('L') or right ('R') side.</param>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="a">Pointer to the triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztrmm")]
    internal static extern void Z_tr_mm(sbyte* side, sbyte* uplo, sbyte* trans, sbyte* diag, int* m, int* n, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* b, int* ldb);
}
