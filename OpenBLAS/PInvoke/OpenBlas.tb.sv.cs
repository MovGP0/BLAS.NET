namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Solves a single-precision triangular banded system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "stbsv_")]
    internal static extern void Stbsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, float* a, int* lda, float* x, int* incX);

    /// <summary>
    /// Solves a double-precision triangular banded system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dtbsv_")]
    internal static extern void Dtbsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, double* a, int* lda, double* x, int* incX);

    /// <summary>
    /// Solves a single-precision complex triangular banded system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ctbsv_")]
    internal static extern void Ctbsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, float* a, int* lda, float* x, int* incX);

    /// <summary>
    /// Solves a double-precision complex triangular banded system of linear equations.
    /// </summary>
    /// <param name="uplo">Pointer to specify whether the matrix is upper ('U') or lower ('L') triangular.</param>
    /// <param name="trans">Pointer to specify whether to transpose the matrix ('N' for no transpose, 'T' for transpose).</param>
    /// <param name="diag">Pointer to specify whether the matrix is unit triangular ('U') or non-unit triangular ('N').</param>
    /// <param name="n">Pointer to the order of the matrix (number of rows and columns).</param>
    /// <param name="k">Pointer to the number of super-diagonals or sub-diagonals.</param>
    /// <param name="a">Pointer to the matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix.</param>
    /// <param name="x">Pointer to the right-hand side vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the vector x.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ztbsv_")]
    internal static extern void Ztbsv(sbyte* uplo, sbyte* trans, sbyte* diag, int* n, int* k, double* a, int* lda, double* x, int* incX);
}
