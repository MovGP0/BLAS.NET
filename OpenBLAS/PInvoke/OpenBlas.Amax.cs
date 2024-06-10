namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Find the index of the element with the maximum absolute value in a single-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "isamax")]
    internal static extern int Isamax(int* n, float* x, int* incX);

    /// <summary>
    /// Find the index of the element with the maximum absolute value in a double-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "idamax")]
    internal static extern int Idamax(int* n, double* x, int* incX);

    /// <summary>
    /// Find the index of the element with the maximum absolute value in a single-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "icamax")]
    internal static extern int Icamax(int* n, ComplexFloat* x, int* incX);

    /// <summary>
    /// Find the index of the element with the maximum absolute value in a double-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "izamax")]
    internal static extern int Izamax(int* n, ComplexDouble* x, int* incX);
}
