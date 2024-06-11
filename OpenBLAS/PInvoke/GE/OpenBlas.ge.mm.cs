namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the matrix-matrix operation C = alpha * op(A) * op(B) + beta * C for single-precision matrices.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="k">Pointer to the number of columns of op(A) and rows of op(B).</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="c">Pointer to the single-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgemm")]
    internal static extern void Sgemm(sbyte* transA, sbyte* transB, int* m, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Perform the matrix-matrix operation C = alpha * op(A) * op(B) + beta * C for double-precision matrices.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="k">Pointer to the number of columns of op(A) and rows of op(B).</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="c">Pointer to the double-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgemm")]
    internal static extern void Dgemm(sbyte* transA, sbyte* transB, int* m, int* n, int* k, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Perform the matrix-matrix operation C = alpha * op(A) * op(B) + beta * C for single-precision complex matrices.
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgemm")]
    internal static extern void Cgemm(sbyte* transA, sbyte* transB, int* m, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Perform the matrix-matrix operation C = alpha * op(A) * op(B) + beta * C for double-precision complex matrices.
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgemm")]
    internal static extern void Zgemm(sbyte* transA, sbyte* transB, int* m, int* n, int* k, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

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
    internal static extern void Cgemm3m(sbyte* transA, sbyte* transB, int* m, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

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
    internal static extern void Zgemm3m(sbyte* transA, sbyte* transB, int* m, int* n, int* k, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Perform a general matrix-matrix multiplication for single-precision matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="transC">Pointer to the transpose operation flag for matrix C.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="c">Pointer to the single-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sge2mm")]
    internal static extern int Sge2mm(sbyte* transA, sbyte* transB, sbyte* transC, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Perform a general matrix-matrix multiplication for double-precision matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="transC">Pointer to the transpose operation flag for matrix C.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="c">Pointer to the double-precision matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dge2mm")]
    internal static extern int Dge2mm(sbyte* transA, sbyte* transB, sbyte* transC, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Perform a general matrix-matrix multiplication for single-precision complex matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="transC">Pointer to the transpose operation flag for matrix C.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cge2mm")]
    internal static extern int Cge2mm(sbyte* transA, sbyte* transB, sbyte* transC, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Perform a general matrix-matrix multiplication for double-precision complex matrices with an additional transpose option.
    /// </summary>
    /// <param name="transA">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="transB">Pointer to the transpose operation flag for matrix B.</param>
    /// <param name="transC">Pointer to the transpose operation flag for matrix C.</param>
    /// <param name="m">Pointer to the number of rows of matrix C and op(A).</param>
    /// <param name="n">Pointer to the number of columns of matrix C and op(B).</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zge2mm")]
    internal static extern int Zge2mm(sbyte* transA, sbyte* transB, sbyte* transC, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);
}
