namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation y = alpha * A * x + beta * y for a single-precision Hermitian band matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangle is used.</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="k">Pointer to the number of super/sub-diagonals of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="y">Pointer to the single-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "chbmv")]
    internal static extern void C_hb_mv(sbyte* uplo, int* n, int* k, float* alpha, float* a, int* lda, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Perform the operation y = alpha * A * x + beta * y for a double-precision Hermitian band matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangle is used.</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="k">Pointer to the number of super/sub-diagonals of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision Hermitian matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="y">Pointer to the double-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zhbmv")]
    internal static extern void Z_hb_mv(sbyte* uplo, int* n, int* k, double* alpha, double* a, int* lda, double* x, int* incX, double* beta, double* y, int* incY);
}
