using MathNet.Numerics.LinearAlgebra.Single;

namespace OpenBLAS.Conversions;

public static partial class SymmetricMatrix
{
    public static DenseMatrix FromBlas(float[] matrix, int size)
    {
        var denseMatrix = DenseMatrix.OfArray(To2DArray(matrix, size, size));
        return SymmetricToFull(denseMatrix);
    }

    public static float[] ToBlas(DenseMatrix matrix)
    {
        return matrix.UpperTriangle().AsColumnMajorArray();
    }

    private static DenseMatrix SymmetricToFull(DenseMatrix matrix)
    {
        var size = matrix.RowCount;
        for (var i = 0; i < size; i++)
        {
            for (var j = i + 1; j < size; j++)
            {
                matrix[j, i] = matrix[i, j];
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