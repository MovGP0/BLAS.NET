﻿namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Performs the matrix-vector operation y = alpha * A * x + beta * y for single-precision complex Hermitian packed matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the single-precision complex scalar alpha.</param>
    /// <param name="ap">Pointer to the single-precision complex packed matrix A.</param>
    /// <param name="x">Pointer to the single-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the single-precision complex scalar beta.</param>
    /// <param name="y">Pointer to the single-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "chpmv_")]
    internal static extern void Chpmv(sbyte* uplo, int* n, float* alpha, float* ap, float* x, int* incX, float* beta, float* y, int* incY);

    /// <summary>
    /// Performs the matrix-vector operation y = alpha * A * x + beta * y for double-precision complex Hermitian packed matrices.
    /// </summary>
    /// <param name="uplo">Pointer to the flag indicating whether the upper or lower triangular part of the Hermitian matrix A is used ('U' for upper, 'L' for lower).</param>
    /// <param name="n">Pointer to the number of rows and columns of the matrix A.</param>
    /// <param name="alpha">Pointer to the double-precision complex scalar alpha.</param>
    /// <param name="ap">Pointer to the double-precision complex packed matrix A.</param>
    /// <param name="x">Pointer to the double-precision complex vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="beta">Pointer to the double-precision complex scalar beta.</param>
    /// <param name="y">Pointer to the double-precision complex vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zhpmv_")]
    internal static extern void Zhpmv(sbyte* uplo, int* n, double* alpha, double* ap, double* x, int* incX, double* beta, double* y, int* incY);
}
