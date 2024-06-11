namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Swap the contents of two single-precision vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sswap")]
    internal static extern void Sswap(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Swap the contents of two double-precision vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first double-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second double-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dswap")]
    internal static extern void Dswap(int* n, double* x, int* incX, double* y, int* incY);

    /// <summary>
    /// Swap the contents of two single-precision complex vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cswap")]
    internal static extern void Cswap(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Swap the contents of two double-precision complex vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second double-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zswap")]
    internal static extern void Zswap(int* n, double* x, int* incX, double* y, int* incY);
}
