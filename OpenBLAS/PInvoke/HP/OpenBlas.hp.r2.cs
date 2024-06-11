namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the rank-2 update operation for a complex Hermitian packed matrix with single-precision complex numbers.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the single-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "chpr2")]
    internal static extern void Chpr2(sbyte* uplo, int* n, ComplexFloat* alpha, ComplexFloat* x, int* incX, ComplexFloat* y, int* incY, ComplexFloat* ap);

    /// <summary>
    /// Performs the rank-2 update operation for a complex Hermitian packed matrix with double-precision complex numbers.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the double-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zhpr2")]
    internal static extern void Zhpr2(sbyte* uplo, int* n, ComplexDouble* alpha, ComplexDouble* x, int* incX, ComplexDouble* y, int* incY, ComplexDouble* ap);
}