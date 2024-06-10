namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs matrix addition for single-precision floating-point numbers.
    /// </summary>
    /// <param name="rows">Pointer to the number of rows in the matrices.</param>
    /// <param name="columns">Pointer to the number of columns in the matrices.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">Pointer to the first single-precision floating-point matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of matrixA.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">Pointer to the second single-precision floating-point matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrixB.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sgeadd")]
    internal static extern void S_ge_add(int* rows, int* columns, float* alpha, float* matrixA, int* lda, float* beta, float* matrixB, int* ldb);

    /// <summary>
    /// Performs matrix addition for double-precision floating-point numbers.
    /// </summary>
    /// <param name="rows">Pointer to the number of rows in the matrices.</param>
    /// <param name="columns">Pointer to the number of columns in the matrices.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">Pointer to the first double-precision floating-point matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of matrixA.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">Pointer to the second double-precision floating-point matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrixB.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dgeadd_")]
    internal static extern void D_ge_add(int* rows, int* columns, double* alpha, double* matrixA, int* lda, double* beta, double* matrixB, int* ldb);

    /// <summary>
    /// Performs matrix addition for complex single-precision floating-point numbers.
    /// </summary>
    /// <param name="rows">Pointer to the number of rows in the matrices.</param>
    /// <param name="columns">Pointer to the number of columns in the matrices.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">Pointer to the first complex single-precision floating-point matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of matrixA.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">Pointer to the second complex single-precision floating-point matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrixB.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cgeadd_")]
    internal static extern void C_ge_add(int* rows, int* columns, ComplexFloat* alpha, ComplexFloat* matrixA, int* lda, ComplexFloat* beta, ComplexFloat* matrixB, int* ldb);

    /// <summary>
    /// Performs matrix addition for complex double-precision floating-point numbers.
    /// </summary>
    /// <param name="rows">Pointer to the number of rows in the matrices.</param>
    /// <param name="columns">Pointer to the number of columns in the matrices.</param>
    /// <param name="alpha">Pointer to the scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">Pointer to the first complex double-precision floating-point matrix.</param>
    /// <param name="lda">Pointer to the leading dimension of matrixA.</param>
    /// <param name="beta">Pointer to the scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">Pointer to the second complex double-precision floating-point matrix.</param>
    /// <param name="ldb">Pointer to the leading dimension of matrixB.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zgeadd_")]
    internal static extern void Z_ge_add(int* rows, int* columns, ComplexDouble* alpha, ComplexDouble* matrixA, int* lda, ComplexDouble* beta, ComplexDouble* matrixB, int* ldb);
}
