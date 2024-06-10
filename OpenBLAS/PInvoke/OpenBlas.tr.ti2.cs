namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Computes the inverse of a single-precision triangular matrix using the unblocked algorithm.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status of the operation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "strti2_")]
    internal static extern int S_tr_ti2(sbyte* uplo, sbyte* diag, int* n, float* A, int* lda, int* info);

    /// <summary>
    /// Computes the inverse of a double-precision triangular matrix using the unblocked algorithm.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status of the operation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtrti2_")]
    internal static extern int D_tr_ti2(sbyte* uplo, sbyte* diag, int* n, double* A, int* lda, int* info);

    /// <summary>
    /// Computes the inverse of a single-precision complex triangular matrix using the unblocked algorithm.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="info">Pointer to the status of the operation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctrti2_")]
    internal static extern int C_tr_ti2(sbyte* uplo, sbyte* diag, int* n, ComplexFloat* A, int* lda, int* info);

    /// <summary>
    /// Computes the inverse of a double-precision complex triangular matrix using the unblocked algorithm.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param="info">Pointer to the status of the operation.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztrti2_")]
    internal static extern int Z_tr_ti2(sbyte* uplo, sbyte* diag, int* n, ComplexDouble* A, int* lda, int* info);
}
