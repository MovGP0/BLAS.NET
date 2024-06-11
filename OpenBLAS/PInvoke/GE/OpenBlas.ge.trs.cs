namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Solves a system of linear equations A * X = B or A' * X = B for single-precision matrices, using the LU factorization computed by Sgetrf.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the single-precision matrix A as computed by Sgetrf.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices from Sgetrf; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful.</param>
    /// <returns>Returns 0 if the execution is successful.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgetrs")]
    internal static extern int Sgetrs(sbyte* trans, int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations A * X = B or A' * X = B for double-precision matrices, using the LU factorization computed by Dgetrf.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the double-precision matrix A as computed by Dgetrf.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices from Dgetrf; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful.</param>
    /// <returns>Returns 0 if the execution is successful.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgetrs")]
    internal static extern int Dgetrs(sbyte* trans, int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations A * X = B or A' * X = B for single-precision complex matrices, using the LU factorization computed by Cgetrf.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A as computed by Cgetrf.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices from Cgetrf; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful.</param>
    /// <returns>Returns 0 if the execution is successful.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgetrs")]
    internal static extern int Cgetrs(sbyte* trans, int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations A * X = B or A' * X = B for double-precision complex matrices, using the LU factorization computed by Zgetrf.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A as computed by Zgetrf.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices from Zgetrf; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful.</param>
    /// <returns>Returns 0 if the execution is successful.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgetrs")]
    internal static extern int Zgetrs(sbyte* trans, int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info);
}
