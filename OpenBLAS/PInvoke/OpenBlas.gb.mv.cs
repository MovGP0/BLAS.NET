namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation y = alpha * A * x + beta * y for a single-precision band matrix.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="kl">Pointer to the number of sub-diagonals of the matrix A.</param>
    /// <param name="ku">Pointer to the number of super-diagonals of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="y">Pointer to the single-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgbmv_")]
    internal static extern void S_gb_mv(sbyte* trans, int* m, int* n, int* kl, int* ku, float* alpha, float* a, int* lda, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Perform the operation y = alpha * A * x + beta * y for a double-precision band matrix.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="kl">Pointer to the number of sub-diagonals of the matrix A.</param>
    /// <param name="ku">Pointer to the number of super-diagonals of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="y">Pointer to the double-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgbmv_")]
    internal static extern void D_gb_mv(sbyte* trans, int* m, int* n, int* kl, int* ku, double* alpha, double* a, int* lda, double* x, int* incX, double* beta, double* y, int* incY);

    /// <summary>
    /// Perform the operation y = alpha * A * x + beta * y for a single-precision complex band matrix.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="kl">Pointer to the number of sub-diagonals of the matrix A.</param>
    /// <param name="ku">Pointer to the number of super-diagonals of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the single-precision scalar beta.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgbmv_")]
    internal static extern void C_gb_mv(sbyte* trans, int* m, int* n, int* kl, int* ku, float* alpha, float* a, int* lda, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Perform the operation y = alpha * A * x + beta * y for a double-precision complex band matrix.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="kl">Pointer to the number of sub-diagonals of the matrix A.</param>
    /// <param name="ku">Pointer to the number of super-diagonals of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the double-precision scalar beta.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgbmv_")]
    internal static extern void Z_gb_mv(sbyte* trans, int* m, int* n, int* kl, int* ku, double* alpha, double* a, int* lda, double* x, int* incX, double* beta, double* y, int* incY);
}
