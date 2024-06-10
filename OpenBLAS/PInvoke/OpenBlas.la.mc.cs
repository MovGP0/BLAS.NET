namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Returns the value of the specified single-precision floating-point parameter.
    /// </summary>
    /// <param name="param">Pointer to the character specifying the parameter to be returned.</param>
    /// <returns>The value of the specified single-precision floating-point parameter.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "slamch_")]
    internal static extern float Slamch(sbyte* param);

    /// <summary>
    /// Returns the value of the specified double-precision floating-point parameter.
    /// </summary>
    /// <param name="param">Pointer to the character specifying the parameter to be returned.</param>
    /// <returns>The value of the specified double-precision floating-point parameter.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dlamch_")]
    internal static extern double Dlamch(sbyte* param);

    /// <summary>
    /// Adds two single-precision floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the first single-precision floating-point number.</param>
    /// <param name="b">Pointer to the second single-precision floating-point number.</param>
    /// <returns>The sum of the two single-precision floating-point numbers.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "slamc3_")]
    internal static extern float Slamc3(float* a, float* b);

    /// <summary>
    /// Adds two double-precision floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the first double-precision floating-point number.</param>
    /// <param name="b">Pointer to the second double-precision floating-point number.</param>
    /// <returns>The sum of the two double-precision floating-point numbers.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dlamc3_")]
    internal static extern double Dlamc3(double* a, double* b);
}
