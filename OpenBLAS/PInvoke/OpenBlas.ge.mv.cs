namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the matrix-vector operation y = alpha * op(A) * x + beta * y for single-precision matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="m">Pointer to the number of rows of matrix A.</param>
    /// <param name="n">Pointer to the number of columns of matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="y">Pointer to the single-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgemv_")]
    internal static extern void Sgemv(sbyte* trans, int* m, int* n, float* alpha, float* a, int* lda, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Perform the matrix-vector operation y = alpha * op(A) * x + beta * y for double-precision matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="m">Pointer to the number of rows of matrix A.</param>
    /// <param name="n">Pointer to the number of columns of matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="y">Pointer to the double-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgemv_")]
    internal static extern void Dgemv(sbyte* trans, int* m, int* n, double* alpha, double* a, int* lda, double* x, int* incX, double* beta, double* y, int* incY);

    /// <summary>
    /// Perform the matrix-vector operation y = alpha * op(A) * x + beta * y for single-precision complex matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="m">Pointer to the number of rows of matrix A.</param>
    /// <param name="n">Pointer to the number of columns of matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgemv_")]
    internal static extern void Cgemv(sbyte* trans, int* m, int* n, float* alpha, float* a, int* lda, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Perform the matrix-vector operation y = alpha * op(A) * x + beta * y for double-precision complex matrices.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag for matrix A.</param>
    /// <param name="m">Pointer to the number of rows of matrix A.</param>
    /// <param name="n">Pointer to the number of columns of matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of matrix A.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgemv_")]
    internal static extern void Zgemv(sbyte* trans, int* m, int* n, double* alpha, double* a, int* lda, double* x, int* incX, double* beta, double* y, int* incY);
}
