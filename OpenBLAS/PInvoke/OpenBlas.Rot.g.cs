namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Constructs a Givens plane rotation for single-precision floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the single-precision floating-point value a.</param>
    /// <param name="b">Pointer to the single-precision floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srotg")]
    internal static extern void Srotg(float* a, float* b, float* c, float* s);

    /// <summary>
    /// Constructs a Givens plane rotation for double-precision floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the double-precision floating-point value a.</param>
    /// <param name="b">Pointer to the double-precision floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drotg")]
    internal static extern void Drotg(double* a, double* b, double* c, double* s);

    /// <summary>
    /// Constructs a Givens plane rotation for single-precision complex floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the single-precision complex floating-point value a.</param>
    /// <param name="b">Pointer to the single-precision complex floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "crotg")]
    internal static extern void Crotg(ComplexFloat* a, ComplexFloat* b, ComplexFloat* c, ComplexFloat* s);

    /// <summary>
    /// Constructs a Givens plane rotation for double-precision complex floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the double-precision complex floating-point value a.</param>
    /// <param name="b">Pointer to the double-precision complex floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zrotg")]
    internal static extern void Zrotg(ComplexDouble* a, ComplexDouble* b, ComplexDouble* c, ComplexDouble* s);
}