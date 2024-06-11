namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Computes the Euclidean norm of a single-precision floating-point vector.
    /// </summary>
    /// <param name="order">Pointer to the order of the matrix (used internally by OpenBLAS).</param>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <param name="x">Pointer to the single-precision floating-point vector.</param>
    /// <param name="result">Pointer to the result (the norm) of the computation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "snorm")]
    internal static extern int Snorm(sbyte* order, int* n, int* incX, float* x, int* result);

    /// <summary>
    /// Computes the Euclidean norm of a double-precision floating-point vector.
    /// </summary>
    /// <param name="order">Pointer to the order of the matrix (used internally by OpenBLAS).</param>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <param name="x">Pointer to the double-precision floating-point vector.</param>
    /// <param name="result">Pointer to the result (the norm) of the computation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dnorm")]
    internal static extern int Dnorm(sbyte* order, int* n, int* incX, double* x, int* result);

    /// <summary>
    /// Computes the Euclidean norm of a single-precision complex vector.
    /// </summary>
    /// <param name="order">Pointer to the order of the matrix (used internally by OpenBLAS).</param>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <param name="x">Pointer to the single-precision complex vector.</param>
    /// <param name="result">Pointer to the result (the norm) of the computation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cnorm")]
    internal static extern int Cnorm(sbyte* order, int* n, int* incX, float* x, int* result);

    /// <summary>
    /// Computes the Euclidean norm of a double-precision complex vector.
    /// </summary>
    /// <param name="order">Pointer to the order of the matrix (used internally by OpenBLAS).</param>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector.</param>
    /// <param name="x">Pointer to the double-precision complex vector.</param>
    /// <param name="result">Pointer to the result (the norm) of the computation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "znorm")]
    internal static extern int Znorm(sbyte* order, int* n, int* incX, double* x, int* result);
}