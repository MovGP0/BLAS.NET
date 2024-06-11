namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Copy the contents of one single-precision vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination single-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scopy")]
    internal static extern void Scopy(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Copy the contents of one double-precision vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source double-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination double-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dcopy")]
    internal static extern void Dcopy(int* n, double* x, int* incX, double* y, int* incY);

    /// <summary>
    /// Copy the contents of one single-precision complex vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination single-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ccopy")]
    internal static extern void Ccopy(int* n, ComplexFloat* x, int* incX, ComplexFloat* y, int* incY);

    /// <summary>
    /// Copy the contents of one double-precision complex vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination double-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zcopy")]
    internal static extern void Zcopy(int* n, ComplexDouble* x, int* incX, ComplexDouble* y, int* incY);
}
