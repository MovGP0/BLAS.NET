namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the matrix-vector operation y := alpha*A*x + beta*y for a single-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="ap">Pointer to the single-precision packed matrix A.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the single-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sspmv_")]
    internal static extern void Sspmv(sbyte* uplo, int* n, float* alpha, float* ap, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Performs the matrix-vector operation y := alpha*A*x + beta*y for a double-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="ap">Pointer to the double-precision packed matrix A.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the double-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dspmv_")]
    internal static extern void Dspmv(sbyte* uplo, int* n, double* alpha, double* ap, double* x, int* incX, double* beta, double* y, int* incY);

    /// <summary>
    /// Performs the matrix-vector operation y := alpha*A*x + beta*y for a single-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="ap">Pointer to the single-precision complex packed matrix A.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cspmv_")]
    internal static extern void Cspmv(sbyte* uplo, int* n, float* alpha, float* ap, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Performs the matrix-vector operation y := alpha*A*x + beta*y for a double-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="ap">Pointer to the double-precision complex packed matrix A.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zspmv_")]
    internal static extern void Zspmv(sbyte* uplo, int* n, double* alpha, double* ap, double* x, int* incX, double* beta, double* y, int* incY);
}
