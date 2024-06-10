namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Compute the sum of absolute values of elements in a single-precision vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sasum_")]
    internal static extern float Sasum(int* n, float* x, int* incX);

    /// <summary>
    /// Compute the sum of absolute values of elements in a double-precision vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dasum_")]
    internal static extern double Dasum(int* n, double* x, int* incX);

    /// <summary>
    /// Compute the sum of absolute values of elements in a single-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scasum_")]
    internal static extern float Casum(int* n, ComplexFloat* x, int* incX);

    /// <summary>
    /// Compute the sum of absolute values of elements in a double-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dzasum_")]
    internal static extern double Zasum(int* n, ComplexDouble* x, int* incX);
}
