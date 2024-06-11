namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for single-precision floats.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision float vector X.</param>
    /// <param name="incX">Pointer to the increment for the elements of X.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the single-precision float vector Y.</param>
    /// <param name="incY">Pointer to the increment for the elements of Y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "saxpby")]
    internal static extern void Saxpby(int* n, float* alpha, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for double-precision floats.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision float vector X.</param>
    /// <param name="incX">Pointer to the increment for the elements of X.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the double-precision float vector Y.</param>
    /// <param name="incY">Pointer to the increment for the elements of Y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "daxpby")]
    internal static extern void Daxpby(int* n, double* alpha, double* x, int* incX, double* beta, double* y, int* incY);

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for single-precision complex floats.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex float vector X.</param>
    /// <param name="incX">Pointer to the increment for the elements of X.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the single-precision complex float vector Y.</param>
    /// <param name="incY">Pointer to the increment for the elements of Y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "caxpby")]
    internal static extern void Caxpby(int* n, ComplexFloat* alpha, ComplexFloat* x, int* incX, ComplexFloat* beta, ComplexFloat* y, int* incY);

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for double-precision complex floats.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex float vector X.</param>
    /// <param name="incX">Pointer to the increment for the elements of X.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the double-precision complex float vector Y.</param>
    /// <param name="incY">Pointer to the increment for the elements of Y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zaxpby")]
    internal static extern void Zaxpby(int* n, ComplexDouble* alpha, ComplexDouble* x, int* incX, ComplexDouble* beta, ComplexDouble* y, int* incY);
}