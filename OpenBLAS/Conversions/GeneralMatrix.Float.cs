using MathNet.Numerics.LinearAlgebra.Single;

namespace OpenBLAS.Conversions;

public static partial class GeneralMatrix
{
    /// <summary>
    /// Convert a General Matrix to a <see cref="DenseMatrix"/>
    /// </summary>
    public static DenseMatrix FromBlas(float[] matrix, int rows, int columns)
    {
        return DenseMatrix.OfArray(To2DArray(matrix, rows, columns));
    }

    /// <summary>
    /// Convert a <see cref="DenseMatrix"/> to a General Matrix
    /// </summary>
    public static float[] ToBlas(DenseMatrix matrix)
    {
        return matrix.AsColumnMajorArray();
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