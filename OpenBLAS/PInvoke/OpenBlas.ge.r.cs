namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the rank-1 update A = alpha * x * y' + A for single-precision matrices.
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sger_")]
    internal static extern void Sger(int* m, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* a, int* lda);

    /// <summary>
    /// Perform the rank-1 update A = alpha * x * y' + A for double-precision matrices.
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dger_")]
    internal static extern void Dger(int* m, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* a, int* lda);

    /// <summary>
    /// Perform the rank-1 update A = alpha * x * y' + A for single-precision complex matrices (unconjugated).
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgeru_")]
    internal static extern void Cgeru(int* m, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* a, int* lda);

    /// <summary>
    /// Perform the rank-1 update A = alpha * x * y' + A for single-precision complex matrices (conjugated).
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgerc_")]
    internal static extern void Cgerc(int* m, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* a, int* lda);

    /// <summary>
    /// Perform the rank-1 update A = alpha * x * y' + A for double-precision complex matrices (unconjugated).
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgeru_")]
    internal static extern void Zgeru(int* m, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* a, int* lda);

    /// <summary>
    /// Perform the rank-1 update A = alpha * x * y' + A for double-precision complex matrices (conjugated).
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgerc_")]
    internal static extern void Zgerc(int* m, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* a, int* lda);
}
