namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Computes the product U * U' or L' * L for a single-precision triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the single-precision triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "slauu2")]
    internal static extern int Slauu2(sbyte* uplo, int* n, float* a, int* lda, int* info);

    /// <summary>
    /// Computes the product U * U' or L' * L for a double-precision triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the double-precision triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dlauu2")]
    internal static extern int Dlauu2(sbyte* uplo, int* n, double* a, int* lda, int* info);

    /// <summary>
    /// Computes the product U * U' or L' * L for a single-precision complex triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the single-precision complex triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "clauu2")]
    internal static extern int Clauu2(sbyte* uplo, int* n, ComplexFloat* a, int* lda, int* info);

    /// <summary>
    /// Computes the product U * U' or L' * L for a double-precision complex triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the double-precision complex triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zlauu2")]
    internal static extern int Zlauu2(sbyte* uplo, int* n, ComplexDouble* a, int* lda, int* info);
}