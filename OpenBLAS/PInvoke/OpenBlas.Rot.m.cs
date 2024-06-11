namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Applies the modified Givens plane rotation to a single-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srotm")]
    internal static extern void Srotm(int* n, float* x, int* incX, float* y, int* incY, float* param);

    /// <summary>
    /// Applies the modified Givens plane rotation to a double-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drotm")]
    internal static extern void Drotm(int* n, double* x, int* incX, double* y, int* incY, double* param);
}