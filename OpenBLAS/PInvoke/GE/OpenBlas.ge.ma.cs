namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for single-precision matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="c">Pointer to the single-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgema")]
    internal static extern int Sgema(sbyte* transA, sbyte* transB, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for double-precision matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="c">Pointer to the double-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgema")]
    internal static extern int Dgema(sbyte* transA, sbyte* transB, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for single-precision complex matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgema")]
    internal static extern int Cgema(sbyte* transA, sbyte* transB, int* m, int* n, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* b, int* ldb, ComplexFloat* beta, ComplexFloat* c, int* ldc);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for double-precision complex matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgema")]
    internal static extern int Zgema(sbyte* transA, sbyte* transB, int* m, int* n, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* b, int* ldb, ComplexDouble* beta, ComplexDouble* c, int* ldc);
}