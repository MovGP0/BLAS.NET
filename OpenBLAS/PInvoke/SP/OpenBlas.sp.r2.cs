namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the rank-2 update of a single-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the single-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sspr2")]
    internal static extern void Sspr2(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* ap);

    /// <summary>
    /// Performs the rank-2 update of a double-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the double-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dspr2")]
    internal static extern void Dspr2(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* ap);

    /// <summary>
    /// Performs the rank-2 update of a single-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the single-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cspr2")]
    internal static extern void Cspr2(sbyte* uplo, int* n, ComplexFloat* alpha, ComplexFloat* x, int* incX, ComplexFloat* y, int* incY, ComplexFloat* ap);

    /// <summary>
    /// Performs the rank-2 update of a double-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the double-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zspr2")]
    internal static extern void Zspr2(sbyte* uplo, int* n, ComplexDouble* alpha, ComplexDouble* x, int* incX, ComplexDouble* y, int* incY, ComplexDouble* ap);
}