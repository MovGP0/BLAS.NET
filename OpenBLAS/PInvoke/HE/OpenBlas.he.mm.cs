namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the matrix-matrix operation C = alpha * A * B + beta * C for single-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="side">Pointer to the flag indicating whether A multiplies B from the left or right ('L' for left, 'R' for right).</param>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="m">Pointer to the number of rows of the matrix C.</param>
    /// <param name="n">Pointer to the number of columns of the matrix C.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "chemm")]
    internal static extern void Chemm(sbyte* side, sbyte* uplo, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the matrix-matrix operation C = alpha * A * B + beta * C for double-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="side">Pointer to the flag indicating whether A multiplies B from the left or right ('L' for left, 'R' for right).</param>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="m">Pointer to the number of rows of the matrix C.</param>
    /// <param name="n">Pointer to the number of columns of the matrix C.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zhemm")]
    internal static extern void Zhemm(sbyte* side, sbyte* uplo, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Performs the matrix-matrix operation C = alpha * A * B + beta * C using an alternative algorithm for single-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="side">Pointer to the flag indicating whether A multiplies B from the left or right ('L' for left, 'R' for right).</param>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="m">Pointer to the number of rows of the matrix C.</param>
    /// <param name="n">Pointer to the number of columns of the matrix C.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "chemm3m")]
    internal static extern void Chemm3m(sbyte* side, sbyte* uplo, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the matrix-matrix operation C = alpha * A * B + beta * C using an alternative algorithm for double-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="side">Pointer to the flag indicating whether A multiplies B from the left or right ('L' for left, 'R' for right).</param>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="m">Pointer to the number of rows of the matrix C.</param>
    /// <param name="n">Pointer to the number of columns of the matrix C.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zhemm3m")]
    internal static extern void Zhemm3m(sbyte* side, sbyte* uplo, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);
}
