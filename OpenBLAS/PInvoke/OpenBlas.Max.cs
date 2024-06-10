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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ismax_")]
    internal static extern int Ismax(int* n, float* x, int* incX);

    /// <summary>
    /// Find the maximum value in a double-precision float vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision float vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The maximum value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "idmax_")]
    internal static extern int Idmax(int* n, double* x, int* incX);

    /// <summary>
    /// Find the maximum value in a single-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The maximum value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "icmax_")]
    internal static extern int Icmax(int* n, float* x, int* incX);

    /// <summary>
    /// Find the maximum value in a double-precision complex vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <returns>The maximum value in the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "izmax_")]
    internal static extern int Izmax(int* n, double* x, int* incX);

    /// <summary>
    /// Finds the maximum value in an array of single-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "smax_")]
    internal static extern float Smax(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the maximum value in an array of double-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dmax_")]
    internal static extern double Dmax(int* n, double* x, int* incX);

    /// <summary>
    /// Finds the maximum value in an array of single-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scmax_")]
    internal static extern float Scmax(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the maximum value in an array of double-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The maximum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dzmax_")]
    internal static extern double Dzmax(int* n, double* x, int* incX);
}
