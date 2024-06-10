namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Compute the dot product of two single-precision vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sdot_")]
    internal static extern float Sdot(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Compute the dot product of two single-precision vectors, with an added single-precision scalar.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="scalar">Pointer to the single-precision scalar added to the dot product.</param>
    /// <param name="x">Pointer to the first single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <returns>The dot product of the two vectors plus the scalar.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sdsdot_")]
    internal static extern float Sdsdot(int* n, float* scalar, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Compute the dot product of two single-precision vectors, returning a double-precision result.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <returns>The double-precision dot product of the two single-precision vectors.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsdot_")]
    internal static extern double Dsdot(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Compute the dot product of two double-precision vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first double-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second double-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <returns>The dot product of the two double-precision vectors.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ddot_")]
    internal static extern double Ddot(int* n, double* x, int* incX, double* y, int* incY);

    /// <summary>
    /// Compute the unconjugated dot product of two single-precision complex vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <returns>The unconjugated dot product of the two single-precision complex vectors.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cdotu_")]
    internal static extern float Cdotu(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Compute the conjugated dot product of two single-precision complex vectors.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second single-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <returns>The conjugated dot product of the two single-precision complex vectors.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cdotc_")]
    internal static extern ComplexFloat Cdotc(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Compute the unconjugated dot product of two double-precision complex vectors.
    /// </summary>
    /// <param name="result">Pointer to store the result of the dot product.</param>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second double-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zdotu_")]
    internal static extern void Zdotu(IntPtr result, int* n, double* x, int* incX, double* y, int* incY);

    /// <summary>
    /// Compute the conjugated dot product of two double-precision complex vectors.
    /// </summary>
    /// <param name="result">Pointer to store the result of the dot product.</param>
    /// <param name="n">Pointer to the number of elements in the vectors.</param>
    /// <param name="x">Pointer to the first double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second double-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zdotc_")]
    internal static extern void Zdotc(IntPtr result, int* n, double* x, int* incX, double* y, int* incY);
}
