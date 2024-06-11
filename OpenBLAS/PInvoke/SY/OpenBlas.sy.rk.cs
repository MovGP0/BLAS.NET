namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the symmetric rank-k update of a real single-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to specify whether the matrix is transposed.</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="k">Pointer to the number of columns in the matrix to be updated.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the product of the matrices.</param>
    /// <param name="a">Pointer to the first matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the first matrix.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the matrix to be updated.</param>
    /// <param name="c">Pointer to the matrix to be updated.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix to be updated.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssyrk")]
    internal static extern void Ssyrk(sbyte* uplo, sbyte* trans, int* n, int* k, float* alpha, float* a, int* lda, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the symmetric rank-k update of a real double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to specify whether the matrix is transposed.</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="k">Pointer to the number of columns in the matrix to be updated.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the product of the matrices.</param>
    /// <param name="a">Pointer to the first matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the first matrix.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the matrix to be updated.</param>
    /// <param name="c">Pointer to the matrix to be updated.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix to be updated.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsyrk")]
    internal static extern void Dsyrk(sbyte* uplo, sbyte* trans, int* n, int* k, double* alpha, double* a, int* lda, double* beta, double* c, int* ldc);

    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csyrk")]
    internal static extern void Csyrk(sbyte* uplo, sbyte* trans, int* n, int* k, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* beta, ComplexFloat* c, int* ldc);

    /// <summary>
    /// Performs the symmetric rank-k update of a complex double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to specify whether the matrix is transposed.</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="k">Pointer to the number of columns in the matrix to be updated.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the product of the matrices.</param>
    /// <param name="a">Pointer to the first matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the first matrix.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the matrix to be updated.</param>
    /// <param name="c">Pointer to the matrix to be updated.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix to be updated.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsyrk")]
    internal static extern void Zsyrk(sbyte* uplo, sbyte* trans, int* n, int* k, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* beta, ComplexDouble* c, int* ldc);
}