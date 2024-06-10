using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Performs matrix addition for single-precision floating-point numbers.
    /// </summary>
    /// <param name="alpha">The scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">The first single-precision floating-point matrix.</param>
    /// <param name="beta">The scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">The second single-precision floating-point matrix.</param>
    public static float[,] Add(float alpha, float[,] matrixA, float beta, float[,] matrixB)
    {
        var rows = matrixA.GetLength(0);
        var columns = matrixA.GetLength(1);

        if (matrixB.GetLength(0) != rows || matrixB.GetLength(1) != columns)
        {
            throw new ArgumentException("Matrix dimensions must agree.");
        }

        var lda = columns;
        var ldb = columns;

        var resultMatrix = new float[rows, columns];

        unsafe
        {
            fixed (float* pMatrixA = matrixA, pMatrixB = matrixB)
            {
                OpenBlas.S_ge_add(&rows, &columns, &alpha, pMatrixA, &lda, &beta, pMatrixB, &ldb);
                Convert.ToManaged(pMatrixB, resultMatrix);
            }
        }

        return resultMatrix;
    }

    /// <summary>
    /// Performs matrix addition for double-precision floating-point numbers.
    /// </summary>
    /// <param name="alpha">The scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">The first double-precision floating-point matrix.</param>
    /// <param name="beta">The scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">The second double-precision floating-point matrix.</param>
    public static double[,] Add(double alpha, double[,] matrixA, double beta, double[,] matrixB)
    {
        var rows = matrixA.GetLength(0);
        var columns = matrixA.GetLength(1);

        if (matrixB.GetLength(0) != rows || matrixB.GetLength(1) != columns)
        {
            throw new ArgumentException("Matrix dimensions must agree.");
        }

        var lda = columns;
        var ldb = columns;
        var resultMatrix = new double[rows, columns];

        unsafe
        {
            fixed (double* pMatrixA = matrixA, pMatrixB = matrixB)
            {
                OpenBlas.D_ge_add(&rows, &columns, &alpha, pMatrixA, &lda, &beta, pMatrixB, &ldb);
                Convert.ToManaged(pMatrixB, resultMatrix);
            }
        }

        return resultMatrix;
    }

    /// <summary>
    /// Performs matrix addition for complex single-precision floating-point numbers.
    /// </summary>
    /// <param name="alpha">The scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">The first complex single-precision floating-point matrix.</param>
    /// <param name="beta">The scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">The second complex single-precision floating-point matrix.</param>
    public static ComplexFloat[,] Add(ComplexFloat alpha, ComplexFloat[,] matrixA, ComplexFloat beta, ComplexFloat[,] matrixB)
    {
        var rows = matrixA.GetLength(0);
        var columns = matrixA.GetLength(1);

        if (matrixB.GetLength(0) != rows || matrixB.GetLength(1) != columns)
        {
            throw new ArgumentException("Matrix dimensions must agree.");
        }

        var lda = columns;
        var ldb = columns;
        var resultMatrix = new ComplexFloat[rows, columns];

        unsafe
        {
            fixed (ComplexFloat* pMatrixA = matrixA, pMatrixB = matrixB)
            {
                OpenBlas.C_ge_add(&rows, &columns, &alpha, pMatrixA, &lda, &beta, pMatrixB, &ldb);
                Convert.ToManaged(pMatrixB, resultMatrix);
            }
        }

        return resultMatrix;
    }

    /// <summary>
    /// Performs matrix addition for complex double-precision floating-point numbers.
    /// </summary>
    /// <param name="alpha">The scalar multiplier for the first matrix.</param>
    /// <param name="matrixA">The first complex double-precision floating-point matrix.</param>
    /// <param name="beta">The scalar multiplier for the second matrix.</param>
    /// <param name="matrixB">The second complex double-precision floating-point matrix.</param>
    /// <returns>A new matrix containing the result of the operation.</returns>
    public static ComplexDouble[,] Add(ComplexDouble alpha, ComplexDouble[,] matrixA, ComplexDouble beta, ComplexDouble[,] matrixB)
    {
        var rows = matrixA.GetLength(0);
        var columns = matrixA.GetLength(1);
        var lda = columns;
        var ldb = columns;
        var resultMatrix = new ComplexDouble[rows, columns];

        unsafe
        {
            fixed (ComplexDouble* pMatrixA = matrixA, pMatrixB = matrixB)
            {
                OpenBlas.Z_ge_add(&rows, &columns, &alpha, pMatrixA, &lda, &beta, pMatrixB, &ldb);
                Convert.ToManaged(pMatrixB, resultMatrix);
            }
        }

        return resultMatrix;
    }
}
