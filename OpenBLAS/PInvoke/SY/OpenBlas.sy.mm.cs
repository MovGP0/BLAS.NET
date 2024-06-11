namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs a symmetric matrix-matrix operation using single-precision floating point numbers.
    /// </summary>
    /// <param name="side">Pointer to a character specifying whether the symmetric matrix is on the left or right.</param>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="m">Pointer to an integer specifying the number of rows of the matrix.</param>
    /// <param name="n">Pointer to an integer specifying the number of columns of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the symmetric matrix.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to an integer specifying the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="c">Pointer to the matrix C.</param>
    /// <param name="ldc">Pointer to an integer specifying the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssymm")]
    internal static extern void Ssymm(sbyte* side, sbyte* uplo, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs a symmetric matrix-matrix operation using double-precision floating point numbers.
    /// </summary>
    /// <param name="side">Pointer to a character specifying whether the symmetric matrix is on the left or right.</param>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="m">Pointer to an integer specifying the number of rows of the matrix.</param>
    /// <param name="n">Pointer to an integer specifying the number of columns of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the symmetric matrix.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to an integer specifying the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="c">Pointer to the matrix C.</param>
    /// <param name="ldc">Pointer to an integer specifying the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsymm")]
    internal static extern void Dsymm(sbyte* side, sbyte* uplo, int* m, int* n, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Performs a symmetric matrix-matrix operation using single-precision complex numbers.
    /// </summary>
    /// <param name="side">Pointer to a character specifying whether the symmetric matrix is on the left or right.</param>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="m">Pointer to an integer specifying the number of rows of the matrix.</param>
    /// <param name="n">Pointer to an integer specifying the number of columns of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the symmetric matrix.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to an integer specifying the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="c">Pointer to the matrix C.</param>
    /// <param name="ldc">Pointer to an integer specifying the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csymm")]
    internal static extern void Csymm(sbyte* side, sbyte* uplo, int* m, int* n, ComplexFloat* alpha, ComplexFloat* a, int* lda, ComplexFloat* b, int* ldb, ComplexFloat* beta, ComplexFloat* c, int* ldc);

    /// <summary>
    /// Performs a symmetric matrix-matrix operation using double-precision complex numbers.
    /// </summary>
    /// <param name="side">Pointer to a character specifying whether the symmetric matrix is on the left or right.</param>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="m">Pointer to an integer specifying the number of rows of the matrix.</param>
    /// <param name="n">Pointer to an integer specifying the number of columns of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the symmetric matrix.</param>
    /// <param name="b">Pointer to the matrix B.</param>
    /// <param name="ldb">Pointer to an integer specifying the leading dimension of matrix B.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="c">Pointer to the matrix C.</param>
    /// <param name="ldc">Pointer to an integer specifying the leading dimension of matrix C.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsymm")]
    internal static extern void Zsymm(sbyte* side, sbyte* uplo, int* m, int* n, ComplexDouble* alpha, ComplexDouble* a, int* lda, ComplexDouble* b, int* ldb, ComplexDouble* beta, ComplexDouble* c, int* ldc);
}
