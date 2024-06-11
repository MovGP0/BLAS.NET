namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the symmetric rank-2 update of a real single-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the first vector used for the rank-2 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second vector used for the rank-2 update.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssyr2")]
    internal static extern void Ssyr2(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* a, int* lda);

    /// <summary>
    /// Performs the symmetric rank-2 update of a real double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the first vector used for the rank-2 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second vector used for the rank-2 update.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsyr2")]
    internal static extern void Dsyr2(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* a, int* lda);

    /// <summary>
    /// Performs the symmetric rank-2 update of a complex single-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the first vector used for the rank-2 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second vector used for the rank-2 update.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csyr2")]
    internal static extern void Csyr2(sbyte* uplo, int* n, ComplexFloat* alpha, ComplexFloat* x, int* incX, ComplexFloat* y, int* incY, ComplexFloat* a, int* lda);

    /// <summary>
    /// Performs the symmetric rank-2 update of a complex double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the first vector used for the rank-2 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of the first vector.</param>
    /// <param name="y">Pointer to the second vector used for the rank-2 update.</param>
    /// <param name="incY">Pointer to the increment for the elements of the second vector.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsyr2")]
    internal static extern void Zsyr2(sbyte* uplo, int* n, ComplexDouble* alpha, ComplexDouble* x, int* incX, ComplexDouble* y, int* incY, ComplexDouble* a, int* lda);
}