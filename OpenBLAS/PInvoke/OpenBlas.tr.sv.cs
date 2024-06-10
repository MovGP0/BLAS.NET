namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Solves a single-precision triangular system of equations with a single right-hand side.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="trans">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the right-hand side vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "strsv_")]
    internal static extern void S_tr_sv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, float* A, int* lda, float* x, int* incX);

    /// <summary>
    /// Solves a double-precision triangular system of equations with a single right-hand side.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="trans">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the right-hand side vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtrsv_")]
    internal static extern void D_tr_sv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, double* A, int* lda, double* x, int* incX);

    /// <summary>
    /// Solves a single-precision complex triangular system of equations with a single right-hand side.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="trans">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the right-hand side vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctrsv_")]
    internal static extern void C_tr_sv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexFloat* A, int* lda, ComplexFloat* x, int* incX);

    /// <summary>
    /// Solves a double-precision complex triangular system of equations with a single right-hand side.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle part of the matrix (upper or lower).</param>
    /// <param name="trans">Pointer to the transpose operation to be performed.</param>
    /// <param name="diag">Pointer to the diagonal type (unit or non-unit).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="A">Pointer to the matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="x">Pointer to the right-hand side vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztrsv_")]
    internal static extern void Z_tr_sv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, ComplexDouble* A, int* lda, ComplexDouble* x, int* incX);
}
