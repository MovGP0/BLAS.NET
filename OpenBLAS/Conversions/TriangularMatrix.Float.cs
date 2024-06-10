using MathNet.Numerics.LinearAlgebra.Single;

namespace OpenBLAS.Conversions;

public static partial class TriangularMatrix
{
    public static DenseMatrix FromBlas(float[] matrix, int size, bool upper)
    {
        var denseMatrix = DenseMatrix.OfArray(To2DArray(matrix, size, size));
        return upper ? UpperTriangularToFull(denseMatrix) : LowerTriangularToFull(denseMatrix);
    }

    public static float[] ToBlas(DenseMatrix matrix, bool upper)
    {
        return upper
            ? matrix.UpperTriangle().AsColumnMajorArray()
            : matrix.LowerTriangle().AsColumnMajorArray();
    }

    public static float[] ToBlas(DiagonalMatrix matrix)
    {
        return matrix.Diagonal().ToArray();
    }

    private static DenseMatrix UpperTriangularToFull(DenseMatrix matrix)
    {
        var size = matrix.RowCount;
        for (var i = 0; i < size; i++)
        {
            for (var j = i + 1; j < size; j++)
            {
                matrix[j, i] = 0.0f;
            }
        }
        return matrix;
    }

    private static DenseMatrix LowerTriangularToFull(DenseMatrix matrix)
    {
        var size = matrix.RowCount;
        for (var i = 0; i < size; i++)
        {
            for (var j = i + 1; j < size; j++)
            {
                matrix[i, j] = 0.0f;
            }
        }
        return matrix;
    }

    private static float[,] To2DArray(float[] array, int rows, int columns)
    {
        var result = new float[rows, columns];
        for (var i = 0; i < array.Length; i++)
        {
            result[i / columns, i % columns] = array[i];
        }
        return result;
    }
}