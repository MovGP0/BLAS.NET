namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Perform the operation of copying a single-precision matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "somatcopy")]
    internal static extern void Somatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, float* alpha, float* a, int* lda, float* b, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "domatcopy")]
    internal static extern void Domatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, double* alpha, double* a, int* lda, double* b, int* ldb);

    /// <summary>
    /// Perform the operation of copying a single-precision complex matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "comatcopy")]
    internal static extern void Comatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* b, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision complex matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zomatcopy")]
    internal static extern void Zomatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* b, int* ldb);
}