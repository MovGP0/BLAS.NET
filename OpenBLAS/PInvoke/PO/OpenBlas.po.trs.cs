namespace OpenBLAS.PInvoke;

// Triangular solve (Solves a system of linear equations A×X=B using the Cholesky factorization)
internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Solves a system of linear equations with a single-precision real symmetric positive-definite matrix using the Cholesky factorization.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="b">Pointer to the right-hand side matrix data.</param>
    /// <param name="ldb">Pointer to the leading dimension of the right-hand side matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "spotrs")]
    internal static extern int S_po_trs(sbyte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations with a double-precision real symmetric positive-definite matrix using the Cholesky factorization.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="b">Pointer to the right-hand side matrix data.</param>
    /// <param name="ldb">Pointer to the leading dimension of the right-hand side matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "dpotrs")]
    internal static extern int D_po_trs(sbyte* uplo, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations with a single-precision complex symmetric positive-definite matrix using the Cholesky factorization.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="b">Pointer to the right-hand side matrix data.</param>
    /// <param name="ldb">Pointer to the leading dimension of the right-hand side matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "cpotrs")]
    internal static extern int C_po_trs(sbyte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations with a double-precision complex symmetric positive-definite matrix using the Cholesky factorization.
    /// </summary>
    /// <param name="uplo">Specifies whether the upper or lower triangular part of the matrix is stored.</param>
    /// <param name="n">Pointer to the order of the matrix.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides.</param>
    /// <param name="a">Pointer to the matrix data.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="b">Pointer to the right-hand side matrix data.</param>
    /// <param name="ldb">Pointer to the leading dimension of the right-hand side matrix.</param>
    /// <param name="info">Pointer to the output info parameter.</param>
    /// <returns>Returns an integer indicating the success of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl , EntryPoint = "zpotrs")]
    internal static extern int Z_po_trs(sbyte* uplo, int* n, int* nrhs, double* a, int* lda, double* b, int* ldb, int* info);
}
