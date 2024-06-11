namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for single-precision general matrices with conjugate transpose options.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="k">Pointer to the common dimension of matrices A and B.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="c">Pointer to the single-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    /// <param name="work">Pointer to the workspace.</param>
    /// <param name="lwork">Pointer to the length of the workspace.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgemc")]
    internal static extern int Sgemc(sbyte* transA, sbyte* transB, int* m, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc, float* work, float* lwork);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for double-precision general matrices with conjugate transpose options.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="k">Pointer to the common dimension of matrices A and B.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="c">Pointer to the double-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    /// <param name="work">Pointer to the workspace.</param>
    /// <param name="lwork">Pointer to the length of the workspace.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgemc")]
    internal static extern int Dgemc(sbyte* transA, sbyte* transB, int* m, int* n, int* k, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc, double* work, double* lwork);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for single-precision complex general matrices with conjugate transpose options.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="k">Pointer to the common dimension of matrices A and B.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    /// <param name="work">Pointer to the workspace.</param>
    /// <param name="lwork">Pointer to the length of the workspace.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgemc")]
    internal static extern int Cgemc(sbyte* transA, sbyte* transB, int* m, int* n, int* k, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* b, int* ldb, ComplexFloat* beta, ComplexFloat* c, int* ldc, ComplexFloat* work, ComplexFloat* lwork);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for double-precision complex general matrices with conjugate transpose options.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="k">Pointer to the common dimension of matrices A and B.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    /// <param name="work">Pointer to the workspace.</param>
    /// <param name="lwork">Pointer to the length of the workspace.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgemc")]
    internal static extern int Zgemc(sbyte* transA, sbyte* transB, int* m, int* n, int* k, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* b, int* ldb, ComplexDouble* beta, ComplexDouble* c, int* ldc, ComplexDouble* work, ComplexDouble* lwork);
}