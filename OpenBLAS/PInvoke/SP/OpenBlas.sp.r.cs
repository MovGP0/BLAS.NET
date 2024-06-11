namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the rank-1 update of a single-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the single-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sspr")]
    internal static extern void Sspr(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* ap);

    /// <summary>
    /// Performs the rank-1 update of a double-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the double-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dspr")]
    internal static extern void Dspr(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* ap);

    /// <summary>
    /// Performs the rank-1 update of a single-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the single-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cspr")]
    internal static extern void Cspr(sbyte* uplo, int* n, ComplexFloat* alpha, ComplexFloat* x, int* incX, ComplexFloat* ap);

    /// <summary>
    /// Performs the rank-1 update of a double-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the double-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zspr")]
    internal static extern void Zspr(sbyte* uplo, int* n, ComplexDouble* alpha, ComplexDouble* x, int* incX, ComplexDouble* ap);
}
