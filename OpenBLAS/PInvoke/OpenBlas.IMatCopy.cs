namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation of copying a single-precision matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simatcopy")]
    internal static extern void Simatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, float* alpha, float* a, int* lda, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dimatcopy")]
    internal static extern void Dimatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, double* alpha, double* a, int* lda, int* ldb);

    /// <summary>
    /// Perform the operation of copying a single-precision complex matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cimatcopy")]
    internal static extern void Cimatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, ComplexFloat* alpha, ComplexFloat* a, int* lda, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision complex matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zimatcopy")]
    internal static extern void Zimatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, ComplexDouble* alpha, ComplexDouble* a, int* lda, int* ldb);
}