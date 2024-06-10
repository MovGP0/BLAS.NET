namespace OpenBLAS.PInvoke;

// Linear Algebra (LA) Swap
internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs a series of row interchanges on the matrix A with single-precision real numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="k1">Pointer to the first element of the pivot indices array.</param>
    /// <param name="k2">Pointer to the last element of the pivot indices array.</param>
    /// <param name="ipiv">Pointer to the array of pivot indices.</param>
    /// <param name="incX">Pointer to the increment between successive values of ipiv.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "slaswp_")]
    internal static extern int S_la_swp(int* n, float* a, int* lda, int* k1, int* k2, int* ipiv, int* incX);

    /// <summary>
    /// Performs a series of row interchanges on the matrix A with double-precision real numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="k1">Pointer to the first element of the pivot indices array.</param>
    /// <param name="k2">Pointer to the last element of the pivot indices array.</param>
    /// <param name="ipiv">Pointer to the array of pivot indices.</param>
    /// <param name="incX">Pointer to the increment between successive values of ipiv.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dlaswp_")]
    internal static extern int D_la_swp(int* n, double* a, int* lda, int* k1, int* k2, int* ipiv, int* incX);

    /// <summary>
    /// Performs a series of row interchanges on the matrix A with single-precision complex numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="k1">Pointer to the first element of the pivot indices array.</param>
    /// <param name="k2">Pointer to the last element of the pivot indices array.</param>
    /// <param name="ipiv">Pointer to the array of pivot indices.</param>
    /// <param name="incX">Pointer to the increment between successive values of ipiv.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "claswp_")]
    internal static extern int C_la_swp(int* n, float* a, int* lda, int* k1, int* k2, int* ipiv, int* incX);

    /// <summary>
    /// Performs a series of row interchanges on the matrix A with double-precision complex numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="k1">Pointer to the first element of the pivot indices array.</param>
    /// <param name="k2">Pointer to the last element of the pivot indices array.</param>
    /// <param name="ipiv">Pointer to the array of pivot indices.</param>
    /// <param name="incX">Pointer to the increment between successive values of ipiv.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zlaswp_")]
    internal static extern int Z_la_swp(int* n, double* a, int* lda, int* k1, int* k2, int* ipiv, int* incX);
}
