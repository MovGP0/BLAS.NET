namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Constructs the modified Givens plane rotation for single-precision floating-point numbers.
    /// </summary>
    /// <param name="d1">Pointer to the first single-precision floating-point value d1.</param>
    /// <param name="d2">Pointer to the second single-precision floating-point value d2.</param>
    /// <param name="x1">Pointer to the single-precision floating-point value x1.</param>
    /// <param name="y1">Pointer to the single-precision floating-point value y1.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srotmg")]
    internal static extern void Srotmg(float* d1, float* d2, float* x1, float* y1, float* param);

    /// <summary>
    /// Constructs the modified Givens plane rotation for double-precision floating-point numbers.
    /// </summary>
    /// <param name="d1">Pointer to the first double-precision floating-point value d1.</param>
    /// <param name="d2">Pointer to the second double-precision floating-point value d2.</param>
    /// <param name="x1">Pointer to the double-precision floating-point value x1.</param>
    /// <param name="y1">Pointer to the double-precision floating-point value y1.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drotmg")]
    internal static extern void Drotmg(double* d1, double* d2, double* x1, double* y1, double* param);
}