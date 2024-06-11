namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Find the index of the element with the minimum absolute value in a single-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "isamin")]
    internal static extern int Isamin(int* n, float* x, int* incX);

    /// <summary>
    /// Find the index of the element with the minimum absolute value in a double-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "idamin")]
    internal static extern int Idamin(int* n, double* x, int* incX);

    /// <summary>
    /// Find the index of the element with the minimum absolute value in a complex single-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the complex single-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "icamin")]
    internal static extern int Icamin(int* n, ComplexFloat* x, int* incX);

    /// <summary>
    /// Find the index of the element with the minimum absolute value in a complex double-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the complex double-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "izamin")]
    internal static extern int Izamin(int* n, ComplexDouble* x, int* incX);
}
