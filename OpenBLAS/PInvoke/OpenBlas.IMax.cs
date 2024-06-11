namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Find the maximum value in a single-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The maximum value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ismax")]
    internal static extern int Ismax(int* n, float* x, int* incX);

    /// <summary>
    /// Find the maximum value in a double-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The maximum value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "idmax")]
    internal static extern int Idmax(int* n, double* x, int* incX);

    /// <summary>
    /// Find the maximum value in a single-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The maximum value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "icmax")]
    internal static extern int Icmax(int* n, ComplexFloat* x, int* incX);

    /// <summary>
    /// Find the maximum value in a double-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The maximum value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "izmax")]
    internal static extern int Izmax(int* n, ComplexDouble* x, int* incX);
}