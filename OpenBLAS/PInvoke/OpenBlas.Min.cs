namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Finds the minimum value in an array of single-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "smin")]
    internal static extern float Smin(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the minimum value in an array of double-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dmin")]
    internal static extern double Dmin(int* n, double* x, int* incX);

    /// <summary>
    /// Finds the minimum value in an array of single-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scmin")]
    internal static extern ComplexFloat Scmin(int* n, ComplexFloat* x, int* incX);

    /// <summary>
    /// Finds the minimum value in an array of double-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dzmin")]
    internal static extern ComplexDouble Dzmin(int* n, ComplexDouble* x, int* incX);
}
