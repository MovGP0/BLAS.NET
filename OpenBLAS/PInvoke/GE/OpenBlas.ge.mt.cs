namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for single-precision matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgemt")]
    internal static extern int Sgemt(sbyte* trans, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for double-precision matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgemt")]
    internal static extern int Dgemt(sbyte* trans, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for single-precision complex matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgemt")]
    internal static extern int Cgemt(sbyte* trans, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb);

    /// <summary>
    /// Perform the operation C = alpha * A * B + beta * C for double-precision complex matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of matrix A and C.</param>
    /// <param name="n">Pointer to the number of columns of matrix B and C.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgemt")]
    internal static extern int Zgemt(sbyte* trans, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb);
}