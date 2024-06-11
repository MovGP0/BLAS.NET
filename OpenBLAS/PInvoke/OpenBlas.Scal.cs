namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Scales a single-precision floating-point vector by a given scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="alpha">Scalar multiplier.</param>
    /// <param name="x">Pointer to the single-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sscal")]
    internal static extern void Sscal(int* n, float alpha, float* x, int* incX);

    /// <summary>
    /// Scales a double-precision floating-point vector by a given scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="alpha">Scalar multiplier.</param>
    /// <param name="x">Pointer to the double-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dscal")]
    internal static extern void Dscal(int* n, double alpha, double* x, int* incX);

    /// <summary>
    /// Scales a single-precision complex floating-point vector by a given scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="alpha">Scalar multiplier.</param>
    /// <param name="x">Pointer to the single-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cscal")]
    internal static extern void Cscal(int* n, ComplexFloat alpha, ComplexFloat* x, int* incX);

    /// <summary>
    /// Scales a double-precision complex floating-point vector by a given scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="alpha">Scalar multiplier.</param>
    /// <param name="x">Pointer to the double-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zscal")]
    internal static extern void Zscal(int* n, ComplexDouble alpha, ComplexDouble* x, int* incX);

    /// <summary>
    /// Scales a single-precision complex floating-point vector by a given single-precision scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="alpha">Scalar multiplier.</param>
    /// <param name="x">Pointer to the single-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csscal")]
    internal static extern void Csscal(int* n, float alpha, ComplexFloat* x, int* incX);

    /// <summary>
    /// Scales a double-precision complex floating-point vector by a given double-precision scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="alpha">Scalar multiplier.</param>
    /// <param name="x">Pointer to the double-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zdscal")]
    internal static extern void Zdscal(int* n, double alpha, ComplexDouble* x, int* incX);
}
