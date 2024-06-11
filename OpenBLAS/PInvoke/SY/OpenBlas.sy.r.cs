namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the symmetric rank-1 update of a real single-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the vector used for the rank-1 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssyr")]
    internal static extern void Ssyr(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* a, int* lda);

    /// <summary>
    /// Performs the symmetric rank-1 update of a real double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the vector used for the rank-1 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsyr")]
    internal static extern void Dsyr(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* a, int* lda);

    /// <summary>
    /// Performs the symmetric rank-1 update of a complex single-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the vector used for the rank-1 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csyr")]
    internal static extern void Csyr(sbyte* uplo, int* n, ComplexFloat* alpha, ComplexFloat* x, int* incX, ComplexFloat* a, int* lda);

    /// <summary>
    /// Performs the symmetric rank-1 update of a complex double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="alpha">Pointer to the scalar multiplier.</param>
    /// <param name="x">Pointer to the vector used for the rank-1 update.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="a">Pointer to the matrix to be updated.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsyr")]
    internal static extern void Zsyr(sbyte* uplo, int* n, ComplexDouble* alpha, ComplexDouble* x, int* incX, ComplexDouble* a, int* lda);
}
