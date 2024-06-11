namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Computes the Euclidean norm of a vector with single-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the vector of single-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the vector.</param>
    /// <returns>The Euclidean norm of the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "snrm2")]
    internal static extern float Snrm2(int* n, float* x, int* incX);

    /// <summary>
    /// Computes the Euclidean norm of a vector with single-precision complex numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the vector of single-precision complex numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the vector.</param>
    /// <returns>The Euclidean norm of the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scnrm2")]
    internal static extern float Scnrm2(int* n, float* x, int* incX);

    /// <summary>
    /// Computes the Euclidean norm of a vector with double-precision floating-point numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the vector of double-precision floating-point numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the vector.</param>
    /// <returns>The Euclidean norm of the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dnrm2")]
    internal static extern double Dnrm2(int* n, double* x, int* incX);

    /// <summary>
    /// Computes the Euclidean norm of a vector with double-precision complex numbers.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the vector of double-precision complex numbers.</param>
    /// <param name="incX">Pointer to the increment between elements of the vector.</param>
    /// <returns>The Euclidean norm of the vector.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dznrm2")]
    internal static extern double Dznrm2(int* n, double* x, int* incX);
}
