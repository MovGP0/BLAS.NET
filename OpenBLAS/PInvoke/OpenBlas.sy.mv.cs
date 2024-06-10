namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs a symmetric matrix-vector operation using single-precision floating point numbers.
    /// </summary>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="n">Pointer to an integer specifying the order of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector x.</param>
    /// <param name="incX">Pointer to an integer specifying the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the vector y.</param>
    /// <param name="incY">Pointer to an integer specifying the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssymv_")]
    internal static extern void Ssymv(sbyte* uplo, int* n, float* alpha, float* a, int* lda, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Performs a symmetric matrix-vector operation using double-precision floating point numbers.
    /// </summary>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="n">Pointer to an integer specifying the order of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector x.</param>
    /// <param name="incX">Pointer to an integer specifying the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the vector y.</param>
    /// <param name="incY">Pointer to an integer specifying the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsymv_")]
    internal static extern void Dsymv(sbyte* uplo, int* n, double* alpha, double* a, int* lda, double* x, int* incX, double* beta, double* y, int* incY);

    /// <summary>
    /// Performs a symmetric matrix-vector operation using single-precision complex numbers.
    /// </summary>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="n">Pointer to an integer specifying the order of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector x.</param>
    /// <param name="incX">Pointer to an integer specifying the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the vector y.</param>
    /// <param name="incY">Pointer to an integer specifying the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csymv_")]
    internal static extern void Csymv(sbyte* uplo, int* n, float* alpha, float* a, int* lda, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Performs a symmetric matrix-vector operation using double-precision complex numbers.
    /// </summary>
    /// <param name="uplo">Pointer to a character specifying whether the upper or lower triangular part of the symmetric matrix is used.</param>
    /// <param name="n">Pointer to an integer specifying the order of the matrix.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="a">Pointer to the symmetric matrix.</param>
    /// <param name="lda">Pointer to an integer specifying the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the vector x.</param>
    /// <param name="incX">Pointer to an integer specifying the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the scalar beta.</param>
    /// <param name="y">Pointer to the vector y.</param>
    /// <param="incY">Pointer to an integer specifying the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsymv_")]
    internal static extern void Zsymv(sbyte* uplo, int* n, double* alpha, double* a, int* lda, double* x, int* incX, double* beta, double* y, int* incY);
}
