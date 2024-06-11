namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the matrix-matrix operation C = alpha * op(A) * op(B) + beta * C using an alternative algorithm for single-precision complex matrices.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="k">Pointer to the number of columns of op(A) and rows of op(B).</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgemm3m")]
    internal static extern void Cgemm3m(sbyte* transA, sbyte* transB, int* m, int* n, int* k, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* b, int* ldb, ComplexFloat* beta, ComplexFloat* c, int* ldc);

    /// <summary>
    /// Perform the matrix-matrix operation C = alpha * op(A) * op(B) + beta * C using an alternative algorithm for double-precision complex matrices.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="k">Pointer to the number of columns of op(A) and rows of op(B).</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgemm3m")]
    internal static extern void Zgemm3m(sbyte* transA, sbyte* transB, int* m, int* n, int* k, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* b, int* ldb, ComplexDouble* beta, ComplexDouble* c, int* ldc);
}