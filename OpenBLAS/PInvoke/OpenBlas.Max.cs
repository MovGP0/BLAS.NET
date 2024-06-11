namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Finds the maximum value in an array of single-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "smax")]
    internal static extern float Smax(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the maximum value in an array of double-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dmax")]
    internal static extern double Dmax(int* n, double* x, int* incX);

    /// <summary>
    /// Finds the maximum value in an array of single-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scmax")]
    internal static extern ComplexFloat Scmax(int* n, ComplexFloat* x, int* incX);

    /// <summary>
    /// Finds the maximum value in an array of double-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dzmax")]
    internal static extern ComplexDouble Dzmax(int* n, ComplexDouble* x, int* incX);
}
