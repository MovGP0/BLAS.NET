using MathNet.Numerics.LinearAlgebra.Double;

namespace OpenBLAS.Conversions;

public static partial class SymmetricMatrix
{
    public static DenseMatrix FromBlas(double[] matrix, int size)
    {
        var denseMatrix = DenseMatrix.OfArray(To2DArray(matrix, size, size));
        return SymmetricToFull(denseMatrix);
    }

    public static double[] ToBlas(DenseMatrix matrix)
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

    private static double[,] To2DArray(double[] array, int rows, int columns)
    {
        var result = new double[rows, columns];
        for (var i = 0; i < array.Length; i++)
        {
            result[i / columns, i % columns] = array[i];
        }
        return result;
    }
}