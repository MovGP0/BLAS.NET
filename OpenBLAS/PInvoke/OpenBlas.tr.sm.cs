namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Solves a single-precision triangular matrix equation.
    /// </summary>
    /// <param name="side">Pointer to the side of the matrix (used internally by OpenBLAS).</param>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="transa">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="B">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "strsm_")]
    internal static extern void S_tr_sm(sbyte* side, sbyte* uplo, sbyte* transa, sbyte* diag, int* m, int* n, float* alpha, float* A, int* lda, float* B, int* ldb);

    /// <summary>
    /// Solves a double-precision triangular matrix equation.
    /// </summary>
    /// <param name="side">Pointer to the side of the matrix (used internally by OpenBLAS).</param>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="transa">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="B">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtrsm_")]
    internal static extern void D_tr_sm(sbyte* side, sbyte* uplo, sbyte* transa, sbyte* diag, int* m, int* n, double* alpha, double* A, int* lda, double* B, int* ldb);

    /// <summary>
    /// Solves a single-precision complex triangular matrix equation.
    /// </summary>
    /// <param name="side">Pointer to the side of the matrix (used internally by OpenBLAS).</param>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="transa">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="B">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctrsm_")]
    internal static extern void C_tr_sm(sbyte* side, sbyte* uplo, sbyte* transa, sbyte* diag, int* m, int* n, float* alpha, float* A, int* lda, float* B, int* ldb);

    /// <summary>
    /// Solves a double-precision complex triangular matrix equation.
    /// </summary>
    /// <param name="side">Pointer to the side of the matrix (used internally by OpenBLAS).</param>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="transa">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="m">Pointer to the number of rows of the matrix B.</param>
    /// <param name="n">Pointer to the number of columns of the matrix B.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="B">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztrsm_")]
    internal static extern void Z_tr_sm(sbyte* side, sbyte* uplo, sbyte* transa, sbyte* diag, int* m, int* n, double* alpha, double* A, int* lda, double* B, int* ldb);
}
