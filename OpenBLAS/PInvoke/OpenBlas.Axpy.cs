namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation <c>y = a * x + y</c>, where <c>x</c> and <c>y</c> are single-precision vectors, and <c>a</c> is a single-precision scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="a">Pointer to the single-precision scalar.</param>
    /// <param name="x">Pointer to the first single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "saxpy")]
    internal static extern void Saxpy(int* n, float* a, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Perform the operation <c>y = a * x + y</c>, where <c>x</c> and <c>y</c> are double-precision vectors, and <c>a</c> is a double-precision scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="a">Pointer to the double-precision scalar.</param>
    /// <param name="x">Pointer to the first double-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second double-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "daxpy")]
    internal static extern void Daxpy(int* n, double* a, double* x, int* incX, double* y, int* incY);

    /// <summary>
    /// Perform the operation <c>y = a * x + y</c>, where <c>x</c> and <c>y</c> are single-precision complex vectors, and <c>a</c> is a single-precision complex scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="a">Pointer to the single-precision complex scalar.</param>
    /// <param name="x">Pointer to the first single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "caxpy")]
    internal static extern void Caxpy(int* n, ComplexFloat* a, ComplexFloat* x, int* incX, ComplexFloat* y, int* incY);

    /// <summary>
    /// Perform the operation <c>y = a * x + y</c>, where <c>x</c> and <c>y</c> are double-precision complex vectors, and <c>a</c> is a double-precision complex scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="a">Pointer to the double-precision complex scalar.</param>
    /// <param name="x">Pointer to the first double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second double-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zaxpy")]
    internal static extern void Zaxpy(int* n, ComplexDouble* a, ComplexDouble* x, int* incX, ComplexDouble* y, int* incY);

    /// <summary>
    /// Perform the operation <c>y = a* * x + y</c>, where <c>x</c> and <c>y</c> are single-precision complex conjugate vectors, and <c>a</c> is a single-precision complex scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="a">Pointer to the single-precision complex scalar.</param>
    /// <param name="x">Pointer to the first single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [Obsolete("not supported", true)]
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "caxpyc")]
    internal static extern void Caxpyc(int* n, ComplexFloat* a, ComplexFloat* x, int* incX, ComplexFloat* y, int* incY);

    /// <summary>
    /// Perform the operation <c>y = a* * x + y</c>, where <c>x</c> and <c>y</c> are double-precision complex conjugate vectors, and <c>a</c> is a double-precision complex scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="a">Pointer to the double-precision complex scalar.</param>
    /// <param name="xConjungated">Pointer to the first double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="yConjungated">Pointer to the second double-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [Obsolete("not supported", true)]
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zaxpyc")]
    internal static extern void Zaxpyc(int* n, ComplexDouble* a, ComplexDouble* xConjungated, int* incX, ComplexDouble* yConjungated, int* incY);
}
