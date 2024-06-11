namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Applies a plane rotation to a single-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srot")]
    internal static extern void Srot(int* n, float* x, int* incX, float* y, int* incY, float* c, float* s);

    /// <summary>
    /// Applies a plane rotation to a double-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drot")]
    internal static extern void Drot(int* n, double* x, int* incX, double* y, int* incY, double* c, double* s);

    /// <summary>
    /// Applies a plane rotation to a single-precision complex floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csrot")]
    internal static extern void Csrot(int* n, ComplexFloat* x, int* incX, ComplexFloat* y, int* incY, ComplexFloat* c, ComplexFloat* s);

    /// <summary>
    /// Applies a plane rotation to a double-precision complex floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zdrot")]
    internal static extern void Zdrot(int* n, ComplexDouble* x, int* incX, ComplexDouble* y, int* incY, ComplexDouble* c, ComplexDouble* s);
}
