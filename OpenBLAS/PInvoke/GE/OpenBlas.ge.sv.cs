namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Solves a system of linear equations A * X = B with a single-precision matrix A and multiple right-hand sides B.
    /// </summary>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, the matrix A is singular.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the matrix A is singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgesv")]
    internal static extern int Sgesv(int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations A * X = B with a double-precision matrix A and multiple right-hand sides B.
    /// </summary>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, the matrix A is singular.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the matrix A is singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgesv")]
    internal static extern int Dgesv(int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations A * X = B with a single-precision complex matrix A and multiple right-hand sides B.
    /// </summary>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, the matrix A is singular.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the matrix A is singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgesv")]
    internal static extern int Cgesv(int* n, int* nrhs, float* a, int* lda, int* ipiv, float* b, int* ldb, int* info);

    /// <summary>
    /// Solves a system of linear equations A * X = B with a double-precision complex matrix A and multiple right-hand sides B.
    /// </summary>
    /// <param name="n">Pointer to the number of linear equations, i.e., the order of the matrix A.</param>
    /// <param name="nrhs">Pointer to the number of right-hand sides, i.e., the number of columns of the matrix B.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="b">Pointer to the double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, the matrix A is singular.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the matrix A is singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgesv")]
    internal static extern int Zgesv(int* n, int* nrhs, double* a, int* lda, int* ipiv, double* b, int* ldb, int* info);
}
