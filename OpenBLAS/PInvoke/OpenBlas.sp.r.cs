﻿namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the rank-1 update of a single-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the single-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sspr_")]
    internal static extern void Sspr(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* ap);

    /// <summary>
    /// Performs the rank-1 update of a double-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the double-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dspr_")]
    internal static extern void Dspr(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* ap);

    /// <summary>
    /// Performs the rank-1 update of a single-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the single-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cspr_")]
    internal static extern void Cspr(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* ap);

    /// <summary>
    /// Performs the rank-1 update of a double-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="ap">Pointer to the double-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zspr_")]
    internal static extern void Zspr(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* ap);

    /// <summary>
    /// Performs the rank-2 update of a single-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the single-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sspr2_")]
    internal static extern void Sspr2(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* ap);

    /// <summary>
    /// Performs the rank-2 update of a double-precision symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the double-precision packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "dspr2_")]
    internal static extern void Dspr2(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* ap);

    /// <summary>
    /// Performs the rank-2 update of a single-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the single-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cspr2_")]
    internal static extern void Cspr2(sbyte* uplo, int* n, float* alpha, float* x, int* incX, float* y, int* incY, float* ap);

    /// <summary>
    /// Performs the rank-2 update of a double-precision complex symmetric packed matrix.
    /// </summary>
    /// <param name="uplo">Pointer to the storage format of the matrix ('U' for upper triangular, 'L' for lower triangular).</param>
    /// <param name="n">Pointer to the order of the matrix A.</param>
    /// <param name="alpha">Pointer to the scalar alpha.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="ap">Pointer to the double-precision complex packed matrix A.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zspr2_")]
    internal static extern void Zspr2(sbyte* uplo, int* n, double* alpha, double* x, int* incX, double* y, int* incY, double* ap);
}
