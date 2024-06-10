namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Finds the index of the minimum value in an array of single-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The index of the minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ismin_")]
    internal static extern int Ismin(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the index of the minimum value in an array of double-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The index of the minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "idmin_")]
    internal static extern int Idmin(int* n, double* x, int* incX);

    /// <summary>
    /// Finds the index of the minimum value in an array of single-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The index of the minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "icmin_")]
    internal static extern int Icmin(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the index of the minimum value in an array of double-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The index of the minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "izmin_")]
    internal static extern int Izmin(int* n, double* x, int* incX);

    /// <summary>
    /// Finds the minimum value in an array of single-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "smin_")]
    internal static extern float Smin(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the minimum value in an array of double-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dmin_")]
    internal static extern double Dmin(int* n, double* x, int* incX);

    /// <summary>
    /// Finds the minimum value in an array of single-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of single-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scmin_")]
    internal static extern float Scmin(int* n, float* x, int* incX);

    /// <summary>
    /// Finds the minimum value in an array of double-precision complex floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the array.</param>
    /// <param name="x">Pointer to the array of double-precision complex floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the array.</param>
    /// <returns>The minimum value in the array.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dzmin_")]
    internal static extern double Dzmin(int* n, double* x, int* incX);
}
