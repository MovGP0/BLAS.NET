namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cher2k")]
    internal static extern void Cher2k(sbyte* uplo, sbyte* trans, int* n, int* k, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* b, int* ldb, ComplexFloat* beta, ComplexFloat* c, int* ldc);

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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zher2k")]
    internal static extern void Zher2k(sbyte* uplo, sbyte* trans, int* n, int* k, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* b, int* ldb, ComplexDouble* beta, ComplexDouble* c, int* ldc);
}