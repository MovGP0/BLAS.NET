using MathNet.Numerics.LinearAlgebra.Double;

namespace OpenBLAS.Conversions;

public static partial class GeneralMatrix
{
    /// <summary>
    /// Convert a General Matrix to a <see cref="DenseMatrix"/>
    /// </summary>
    public static DenseMatrix FromBlas(double[] matrix, int rows, int columns)
    {
        return DenseMatrix.OfArray(To2DArray(matrix, rows, columns));
    }

    /// <summary>
    /// Convert a <see cref="DenseMatrix"/> to a General Matrix
    /// </summary>
    public static double[] ToBlas(DenseMatrix matrix)
    {
        return matrix.AsColumnMajorArray();
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