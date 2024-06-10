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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssyr_")]
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsyr_")]
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csyr_")]
    internal static extern void Csyr(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* a, int* lda);

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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsyr_")]
    internal static extern void Zsyr(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* a, int* lda);

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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssyr2_")]
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsyr2_")]
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csyr2_")]
    internal static extern void Csyr2(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* a, int* lda);

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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsyr2_")]
    internal static extern void Zsyr2(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* a, int* lda);

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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssyrk_")]
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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsyrk_")]
    internal static extern void Dsyrk(sbyte* uplo, sbyte* trans, int* n, int* k, double* alpha, double* a, int* lda, double* beta, double* c, int* ldc);

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
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsyrk_")]
    internal static extern void Zsyrk(sbyte* uplo, sbyte* trans, int* n, int* k, double* alpha, double* a, int* lda, double* beta, double* c, int* ldc);

    /// <summary>
    /// Performs the symmetric rank-2k update of a real single-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to specify whether the matrix is transposed.</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="k">Pointer to the number of columns in the matrix to be updated.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the product of the matrices.</param>
    /// <param name="a">Pointer to the first matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the first matrix.</param>
    /// <param name="b">Pointer to the second matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of the second matrix.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the matrix to be updated.</param>
    /// <param name="c">Pointer to the matrix to be updated.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix to be updated.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ssyr2k_")]
    internal static extern void Ssyr2k(sbyte* uplo, sbyte* trans, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the symmetric rank-2k update of a real double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to specify whether the matrix is transposed.</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="k">Pointer to the number of columns in the matrix to be updated.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the product of the matrices.</param>
    /// <param name="a">Pointer to the first matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the first matrix.</param>
    /// <param name="b">Pointer to the second matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of the second matrix.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the matrix to be updated.</param>
    /// <param name="c">Pointer to the matrix to be updated.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix to be updated.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dsyr2k_")]
    internal static extern void Dsyr2k(sbyte* uplo, sbyte* trans, int* n, int* k, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);

    /// <summary>
    /// Performs the symmetric rank-2k update of a complex single-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to specify whether the matrix is transposed.</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="k">Pointer to the number of columns in the matrix to be updated.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the product of the matrices.</param>
    /// <param name="a">Pointer to the first matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the first matrix.</param>
    /// <param name="b">Pointer to the second matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of the second matrix.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the matrix to be updated.</param>
    /// <param name="c">Pointer to the matrix to be updated.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix to be updated.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csyr2k_")]
    internal static extern void Csyr2k(sbyte* uplo, sbyte* trans, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c, int* ldc);

    /// <summary>
    /// Performs the symmetric rank-2k update of a complex double-precision matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the triangle of the matrix to be used ('U' for upper, 'L' for lower).</param>
    /// <param name="trans">Pointer to specify whether the matrix is transposed.</param>
    /// <param name="n">Pointer to the number of rows and columns in the matrix.</param>
    /// <param name="k">Pointer to the number of columns in the matrix to be updated.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the product of the matrices.</param>
    /// <param name="a">Pointer to the first matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the first matrix.</param>
    /// <param name="b">Pointer to the second matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of the second matrix.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the matrix to be updated.</param>
    /// <param name="c">Pointer to the matrix to be updated.</param>
    /// <param name="ldc">Pointer to the leading dimension of the matrix to be updated.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zsyr2k_")]
    internal static extern void Zsyr2k(sbyte* uplo, sbyte* trans, int* n, int* k, double* alpha, double* a, int* lda, double* b, int* ldb, double* beta, double* c, int* ldc);
}
