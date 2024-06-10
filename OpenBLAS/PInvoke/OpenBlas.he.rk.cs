namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the Hermitian rank-k update C = alpha * A * A' + beta * C for single-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix C is used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to the flag indicating the operation ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix C.</param>
    /// <param name="k">Pointer to the number of columns of the matrix A if trans = 'N', and the number of rows of the matrix A if trans = 'T' or 'C'.</param>
    /// <param name="alpha">Pointer to the single-precision real scalar alpha.</param>
    /// <param name="a">Pointer to the single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="beta">Pointer to the single-precision real scalar beta.</param>
    /// <param name="c">Pointer to the single-precision complex Hermitian matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cherk_")]
    internal static extern void Cherk(sbyte* uplo, sbyte* trans, int* n, int* k, float* alpha, float* a, int* lda, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the Hermitian rank-k update C = alpha * A * A' + beta * C for double-precision complex Hermitian matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix C is used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to the flag indicating the operation ('N' for no transpose, 'T' for transpose, 'C' for conjugate transpose).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix C.</param>
    /// <param name="k">Pointer to the number of columns of the matrix A if trans = 'N', and the number of rows of the matrix A if trans = 'T' or 'C'.</param>
    /// <param name="alpha">Pointer to the double-precision real scalar alpha.</param>
    /// <param name="a">Pointer to the double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="beta">Pointer to the double-precision real scalar beta.</param>
    /// <param name="c">Pointer to the double-precision complex Hermitian matrix C.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zherk_")]
    internal static extern void Zherk(sbyte* uplo, sbyte* trans, int* n, int* k, double* alpha, double* a, int* lda, double* beta, double* c, int* ldc);
}
