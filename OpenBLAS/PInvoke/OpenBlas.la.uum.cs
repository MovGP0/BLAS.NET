namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Computes the product U * U' or L' * L using block algorithm for a single-precision triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the single-precision triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "slauum")]
    internal static extern int Slauum(sbyte* uplo, int* n, float* a, int* lda, int* info);

    /// <summary>
    /// Computes the product U * U' or L' * L using block algorithm for a double-precision triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the double-precision triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dlauum")]
    internal static extern int Dlauum(sbyte* uplo, int* n, double* a, int* lda, int* info);

    /// <summary>
    /// Computes the product U * U' or L' * L using block algorithm for a single-precision complex triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the single-precision complex triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "clauum")]
    internal static extern int Clauum(sbyte* uplo, int* n, ComplexFloat* a, int* lda, int* info);

    /// <summary>
    /// Computes the product U * U' or L' * L using block algorithm for a double-precision complex triangular matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the matrix U (upper triangular) or L (lower triangular) is used.</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="a">Pointer to the double-precision complex triangular matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status code of the operation.</param>
    /// <returns>Status code of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zlauum")]
    internal static extern int Zlauum(sbyte* uplo, int* n, ComplexDouble* a, int* lda, int* info);
}