namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the rank-2 update A = alpha * x * y' + conj(alpha) * y * x' + A for single-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the single-precision complex Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cher2_")]
    internal static extern void Cher2(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* a, int* lda);

    /// <summary>
    /// Performs the rank-2 update A = alpha * x * y' + conj(alpha) * y * x' + A for double-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the double-precision complex Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zher2_")]
    internal static extern void Zher2(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* a, int* lda);

    /// <summary>
    /// Performs the rank-2k update C = alpha * A * B' + conj(alpha) * B * A' + beta * C for single-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix C is used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to the flag indicating the operation ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix C.</param>
    /// <param name="k">Pointer to the number of columns of the matrix A and B.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex Hermitian matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cher2k_")]
    internal static extern void Cher2k(sbyte* uplo, sbyte* trans, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the rank-2k update C = alpha * A * B' + conj(alpha) * B * A' + beta * C for double-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix C is used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to the flag indicating the operation ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix C.</param>
    /// <param name="k">Pointer to the number of columns of the matrix A and B.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex Hermitian matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zher2k_")]
    internal static extern void Zher2k(sbyte* uplo, sbyte* trans, int* n, int* k, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Performs the matrix-matrix operation C = alpha * A * B' + conj(alpha) * B * A' + beta * C for single-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="side">Pointer to the flag indicating whether A multiplies B from the left or right ('L' for left, 'R' for right).</param>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix C is used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to the flag indicating the operation ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="m">Pointer to the number of rows of the matrix C.</param>
    /// <param name="n">Pointer to the number of columns of the matrix C.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex Hermitian matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cher2m_")]
    internal static extern int Cher2m(sbyte* side, sbyte* uplo, sbyte* trans, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the matrix-matrix operation C = alpha * A * B' + conj(alpha) * B * A' + beta * C for double-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="side">Pointer to the flag indicating whether A multiplies B from the left or right ('L' for left, 'R' for right).</param>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix C is used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to the flag indicating the operation ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="m">Pointer to the number of rows of the matrix C.</param>
    /// <param name="n">Pointer to the number of columns of the matrix C.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex Hermitian matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zher2m_")]
    internal static extern int Zher2m(sbyte* side, sbyte* uplo, sbyte* trans, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);
}
