namespace OpenBLAS.PInvoke;

// Triangular factor (Cholesky factorization).
internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Computes the Cholesky factorization of a real single-precision matrix using a block algorithm.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "spotrf")]
    internal static extern int S_po_trf(sbyte* uplo, int* n, float* a, int* lda, int* info);

    /// <summary>
    /// Computes the Cholesky factorization of a real double-precision matrix using a block algorithm.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "dpotrf")]
    internal static extern int D_po_trf(sbyte* uplo, int* n, double* a, int* lda, int* info);

    /// <summary>
    /// Computes the Cholesky factorization of a complex single-precision matrix using a block algorithm.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "cpotrf")]
    internal static extern int C_po_trf(sbyte* uplo, int* n, ComplexFloat* a, int* lda, int* info);

    /// <summary>
    /// Computes the Cholesky factorization of a complex double-precision matrix using a block algorithm.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "zpotrf")]
    internal static extern int Z_po_trf(sbyte* uplo, int* n, ComplexDouble* a, int* lda, int* info);
}
