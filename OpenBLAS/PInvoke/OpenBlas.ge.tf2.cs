namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Computes an LU factorization of a general single-precision matrix using partial pivoting with row interchanges.
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, U(info,info) is exactly zero. The factorization has been completed, but the factor U is exactly singular, and division by zero will occur if it is used to solve a system of equations.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the factor U is exactly singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgetf2_")]
    internal static extern int Sgetf2(int* m, int* n, float* a, int* lda, int* ipiv, int* info);

    /// <summary>
    /// Computes an LU factorization of a general double-precision matrix using partial pivoting with row interchanges.
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, U(info,info) is exactly zero. The factorization has been completed, but the factor U is exactly singular, and division by zero will occur if it is used to solve a system of equations.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the factor U is exactly singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgetf2_")]
    internal static extern int Dgetf2(int* m, int* n, double* a, int* lda, int* ipiv, int* info);

    /// <summary>
    /// Computes an LU factorization of a general single-precision complex matrix using partial pivoting with row interchanges.
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, U(info,info) is exactly zero. The factorization has been completed, but the factor U is exactly singular, and division by zero will occur if it is used to solve a system of equations.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the factor U is exactly singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgetf2_")]
    internal static extern int Cgetf2(int* m, int* n, float* a, int* lda, int* ipiv, int* info);

    /// <summary>
    /// Computes an LU factorization of a general double-precision complex matrix using partial pivoting with row interchanges.
    /// </summary>
    /// <param name="m">Pointer to the number of rows of the matrix A.</param>
    /// <param name="n">Pointer to the number of columns of the matrix A.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ipiv">Pointer to the pivot indices that define the permutation matrix P; for each column i of the matrix A, row i was interchanged with row ipiv[i].</param>
    /// <param name="info">Pointer to the output information. If info = 0, the execution is successful. If info &gt; 0, U(info,info) is exactly zero. The factorization has been completed, but the factor U is exactly singular, and division by zero will occur if it is used to solve a system of equations.</param>
    /// <returns>Returns 0 if the execution is successful, or a positive integer if the factor U is exactly singular.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgetf2_")]
    internal static extern int Zgetf2(int* m, int* n, double* a, int* lda, int* ipiv, int* info);
}
