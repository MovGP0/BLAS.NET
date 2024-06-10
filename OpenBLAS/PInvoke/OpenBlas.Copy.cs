namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Copy the contents of one single-precision vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source single-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination single-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "scopy_")]
    internal static extern void Scopy(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Copy the contents of one double-precision vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source double-precision vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination double-precision vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dcopy_")]
    internal static extern void Dcopy(int* n, double* x, int* incX, double* y, int* incY);

    /// <summary>
    /// Copy the contents of one single-precision complex vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source single-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination single-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ccopy_")]
    internal static extern void Ccopy(int* n, float* x, int* incX, float* y, int* incY);

    /// <summary>
    /// Copy the contents of one double-precision complex vector to another.
    /// </summary>
    /// <param name="n">Pointer to the number of elements to copy.</param>
    /// <param name="x">Pointer to the source double-precision complex vector.</param>
    /// <param name="incX">Pointer to the increment for the elements of the source vector.</param>
    /// <param name="y">Pointer to the destination double-precision complex vector.</param>
    /// <param name="incY">Pointer to the increment for the elements of the destination vector.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zcopy_")]
    internal static extern void Zcopy(int* n, double* x, int* incX, double* y, int* incY);

    /// <summary>
    /// Perform the operation of copying a single-precision matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination single-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "somatcopy_")]
    internal static extern void Somatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, float* alpha, float* a, int* lda, float* b, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination double-precision matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "domatcopy_")]
    internal static extern void Domatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, double* alpha, double* a, int* lda, double* b, int* ldb);

    /// <summary>
    /// Perform the operation of copying a single-precision complex matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination single-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "comatcopy_")]
    internal static extern void Comatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, float* alpha, float* a, int* lda, float* b, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision complex matrix with possible transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="b">Pointer to the destination double-precision complex matrix B.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zomatcopy_")]
    internal static extern void Zomatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, double* alpha, double* a, int* lda, double* b, int* ldb);

    /// <summary>
    /// Perform the operation of copying a single-precision matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination single-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "simatcopy_")]
    internal static extern void Simatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, float* alpha, float* a, int* lda, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination double-precision matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dimatcopy_")]
    internal static extern void Dimatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, double* alpha, double* a, int* lda, int* ldb);

    /// <summary>
    /// Perform the operation of copying a single-precision complex matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the single-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination single-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cimatcopy_")]
    internal static extern void Cimatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, float* alpha, float* a, int* lda, int* ldb);

    /// <summary>
    /// Perform the operation of copying a double-precision complex matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">Pointer to the transpose operation flag.</param>
    /// <param name="order">Pointer to the matrix order flag.</param>
    /// <param name="rows">Pointer to the number of rows in the matrix.</param>
    /// <param name="cols">Pointer to the number of columns in the matrix.</param>
    /// <param name="alpha">Pointer to the double-precision scalar alpha.</param>
    /// <param name="a">Pointer to the source and destination double-precision complex matrix A.</param>
    /// <param name="lda">Pointer to the leading dimension of the matrix A.</param>
    /// <param name="ldb">Pointer to the leading dimension of the matrix B.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zimatcopy_")]
    internal static extern void Zimatcopy(sbyte* trans, sbyte* order, int* rows, int* cols, double* alpha, double* a, int* lda, int* ldb);
}
